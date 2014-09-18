using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Timers;

namespace Boggle
{
    public enum ScoringMode { STANDARD, SCRABBLE, POINTPERLETTER };
    public enum GameStatus { PRE_GAME, RUNNING, ENDED };
    public enum BoardSize { STANDARD = 16, BIGBOGGLE = 25 }
    public enum BoundaryMode { STANDARD, PERIODIC };
    public class Boggle
    {

        
        

       // public static int BOARD_SIZE = 25;
        private int[] SCORE_GUIDE = { 0, 0, 0, 1, 1, 2, 3, 5, 11 }; //Scoring guide based on length using standard Boggle rules
        private Dictionary<char, int> SCABBLE_SCORING_GUIDE = new Dictionary<char, int>() //Scoring guide using Scabble letter values
        {
            { 'A' , 1 }, { 'B' , 3 }, { 'C' , 3 }, { 'D' , 2 }, { 'E' , 1 }, { 'F' , 4 }, { 'G' , 2 }, { 'H' , 4 },
            { 'I' , 1 }, { 'J' , 8 }, { 'K' , 5 }, { 'L' , 1 }, { 'M' , 3 }, { 'N' , 1 }, { 'O' , 1 }, { 'P' , 3 },
            { 'Q' , 10 },{ 'R' , 1 }, { 'S' , 1 }, { 'T' , 1 }, { 'U' , 1 }, { 'V' , 4 }, { 'W' , 4 }, { 'X' , 8 },
            { 'Y' , 4 }, { 'Z' , 10 },
        };
        
        private Random rnd = new Random();
        private TextReader tr;

        private string[,] dice ; //Create the array to hold dice values
        private int[] position ; //Array of positions on board
        private string[] board ; //Array containing the layout of the board
        public ArrayList wordList = new ArrayList(); //Array of all valid words
        private ArrayList usedLetters = new ArrayList();
        private string current_dice_set;
        private string current_word_list = null;
        private ArrayList usedWords = new ArrayList();

        private Timer gameTimer = new Timer();
       
        public int score { get; private set; } // Games current score

        public GameStatus status{ get; private set; }
        public ScoringMode mode { get; private set; } //Method used for scoring words
        
        public BoardSize size { get; private set; } //Size of the playing board
        public int minLength { get; private set; } // Minimum valid word length; 2 letters is ABSOLUTE minimum
        public int gameLength { get; private set; } //Time limit for game in milliseconds e.g. 1 second = 1000
        public BoundaryMode bound { get; private set; }
        
       

        public Boggle(ScoringMode score_mode = ScoringMode.SCRABBLE, BoardSize board_size = BoardSize.BIGBOGGLE, BoundaryMode bound_mode = BoundaryMode.STANDARD, int time_limit = 180000, int min_length = 3)
        {
            status = GameStatus.PRE_GAME;

            score = 0;
            mode = score_mode;
            size = board_size;
            minLength = min_length;
            gameLength = time_limit;
            bound = bound_mode;


            dice = new string[(int)size, 6]; //Create the array to hold dice values
            position = new int[(int)size]; //Array of positions on board
            board = new string[(int)size]; //Array containing the layout of the board
            

            gameTimer.Enabled = false;
            gameTimer.Interval = (double)gameLength;
            gameTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);

            current_word_list = "../../enable2k.txt";

            if (size == BoardSize.STANDARD)
            {
                current_dice_set = "../../BoggleDice.txt";
            }
            else
            {
                current_dice_set = "../../BigBoggleDice.txt";
            }

            LoadDice();
            LoadWordList();
            ShuffleBoard();

     

        } // End Constructor
        public bool ChangeWordList(string list)
        {
            /**
             * Try to change the current word list
             * list: file path for new word list
             * */
            if (status != GameStatus.RUNNING) //Can only change when game is not running
            {
                try //Try to load new word list
                {
                    current_word_list = list;
                    LoadWordList();
                    return true;
                }
                catch //If an error occurs revert to default list
                {
                    current_word_list = "../../enable2k.txt";
                    LoadWordList();
                    return false;
                }
            }
            return false;
            
            
        }
        public bool ChangeDiceSet(string dice)
        {
            /**
             * Try to change the current dice set
             * dice: file path for dice file
             * */
            if (status != GameStatus.RUNNING) //Can only change dice if the game is not running
            {
                try //Try to load new dice
                {
                    current_word_list = dice;
                    LoadWordList();
                    return true;
                }
                catch //If there is an error, revert to defualt dice
                {
                    current_dice_set = "../../BigBoggleDice.txt";
                    LoadDice();
                    return false;
                }
            }
            return false;
        }
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            EndGame();
        }
        public void EndGame()
        {
            status = GameStatus.ENDED;
        }
        public void StartGame()
        {

            status = GameStatus.RUNNING;
            gameTimer.Enabled = true;
            gameTimer.Start();
        }
        public string[] GetBoard()
        {          
            return board;
        } // End GetBoard

        public bool CheckWord(string word)
        {
            // Searches through the word list and returns true if the word is found
            bool isWord = false;
            if (wordList.BinarySearch(word.ToLower()) > 0) 
                isWord = true;

            return isWord;

        } // End CheckWord

        private int ScoreWord_Standard(string word)
        {
            //Does not check validity of a word
            
            int wordScore = 0;

            if (word.Length <= 8)
                wordScore = SCORE_GUIDE[word.Length];//Score based on word length
            else
                wordScore = SCORE_GUIDE[8]; //Score for long words
            return wordScore;
            
        } // End ScoreWord_Standard

        private int ScoreWord_Scrabble(string word) //Score word using Scrabble rules
        {
            //Does not check validity of a word
            int wordScore = 0;
            
            char[] wordLetters = word.ToArray(); //Turn word string into an array of chars

            foreach (char letter in wordLetters)
            {
                wordScore += SCABBLE_SCORING_GUIDE[letter]; //Checks each letter against the Scrabble letter scoring guide
            }

            return wordScore;
        } // End ScoreWord_Scrabble

        private int ScoreWord_PointPer(string word)
        {
            //Does not check validity of a word
            
            int wordScore = word.Length; //Word length is score; QU character counts for 2 points as intended

            return wordScore;
        } //End ScoreWord_PointPer

        public int ScoreWord(string word) 
            /**
             * ScoreWord will return an integer representing the point value of the parameter 'word'. 
             * It does not check the submitted word for validity 
             * It does not play the word
             * The score will not be affected by calling this method
             * */
        {
            word.Trim(); //Remove any extra whitespace
            word = word.ToUpper(); //Ensure the word is in all capitals

            switch (mode) //Send the word for scoring based on current scoring mode
            {
                case ScoringMode.STANDARD:
                    return ScoreWord_Standard(word);
                    
                case ScoringMode.SCRABBLE:
                    return ScoreWord_Scrabble(word);
                    
                case ScoringMode.POINTPERLETTER:
                    return ScoreWord_PointPer(word);
                    
                default:
                    return 0;
            }
               
               

        }
        
        public bool PlayWord(string word)
        {
            /**
             * PlayWord validates a word and increasing the score if appropriate
             * Returns TRUE if word was played 
             * Returns FALSE if word was not played
             * */
            bool validPlay = false;
            usedLetters.Clear();
            if (status == GameStatus.RUNNING) //Check to see if game is running
            {
                if (!usedWords.Contains(word)) // Check if word is already used
                {
                    if (word.Length >= minLength && CheckWord(word)) // Check if word is long enough AND is in current Word List
                    {
                        //If a valid word then...
                        score += ScoreWord(word); ; // Increase score
                        usedWords.Add(word); // Add word to used word list
                        validPlay = true; // Return true
                        
                    }
                }
            }
            return validPlay;
            
        } //End PlayWord

        private void LoadDice()
        {
            tr = new StreamReader(current_dice_set); // Create stream reader with selected dice set

            string input = tr.ReadLine(); // Load first line

            for (int line = 0; line < (int)size; line++) // Read line
            {
                for (int letter = 0; letter < input.Length; letter++) // Read each letter in the line
                {
                    if (input != null) // If we haven't reached the end of file
                    {
                        dice[line, letter] = input.Substring(letter, 1); // Load dice by line and letter
                        if (dice[line, letter].Equals("Q")) // For this game all Q's will be QU
                        {
                            dice[line, letter] = "QU";
                        }
                    }
                }
                input = tr.ReadLine(); //Read the next line
                
            }
            tr.Close(); //Close the text reader
        } // End LoadDice

        private void LoadWordList()
        {
            string input = null;
            wordList.Clear();
            wordList.Capacity = 0;
            

            tr = new StreamReader(current_word_list);
            input = null;
            input = tr.ReadLine();
            
            while (input != null)
            {
                //Console.WriteLine(input);
                wordList.Add(input);
                input = tr.ReadLine();
            }
            wordList.Sort();
            tr.Close();
        }
        private void ShuffleBoard()
        {
            // Creates an array of integers to control what spot on the board a die will be in
            for (int i = 0; i < (int)size; i++)
                position[i] = i;

            // Shuffle the die positions on the board using Fisher-Yates
            for (int i = position.Length - 1; i > 0; i--)
            {
                int random = rnd.Next(0, i);

                int temp = position[i];
                position[i] = position[random];
                position[random] = temp;
            }

            // Arrange the die on the board
            for (int i = 0; i < (int)size; i++)
            {
                board[i] = dice[position[i], rnd.Next(0, 6)];
            }
        }
        

        public void setWordList(string list)
        {
            current_word_list = list;
            LoadWordList();
        }
        public ArrayList UsedWords()
        {
            return usedWords;
        }
        public string LastWord()
        {
            return usedWords[usedWords.Count - 1].ToString();
        }

        public ArrayList PlayLetter(int l)
        {
            int letter = l;
            ArrayList moves = new ArrayList(); ; // 0 disabled, 1 enable, 2 current letter, 3 used letter
            for (int count = 0; count < (int)size; count++)
            {
                moves.Add(0);
            }
            
            ArrayList valid;
            if(usedLetters.Contains(letter))
            {
                return null;
            }
            usedLetters.Add(letter);
            for (int count = 0; count < moves.Count; count++)
            {
                moves[count] = 0;
            }
            if (size == BoardSize.STANDARD)
            {
                valid = ValidMoves_Standard(letter);
            }
            else
            {
                valid = ValidMoves_Big(letter);
            }
            for (int count = 0; count < valid.Count; count++)
            {
                int current = letter + (int)valid[count];  
                moves[current] = 1;        
            }
            foreach (int i in usedLetters)
            {
                moves[i] = 3;
            }
            moves[letter] = 2;
 
            return moves; 
        }
       
        private ArrayList ValidMoves_Big(int current)
        {
            ArrayList moves = new ArrayList();
            current++;
            moves.Add(-1);
            moves.Add(-4);
            moves.Add(-5);
            moves.Add(-6);
            moves.Add(1);
            moves.Add(4);
            moves.Add(5);
            moves.Add(6);

            if (bound == BoundaryMode.PERIODIC)
            {
                moves.Add(19);
                moves.Add(20);
                moves.Add(21);

                moves.Add(-19);
                moves.Add(-20);
                moves.Add(-21);

                if ((current % 5) == 1) //First Column
                {
                    moves.Remove(11);
                    moves.Remove(-6);
                    moves.Remove(15);
                    moves.Remove(19);
                    
                    moves.Add(9);
                    moves.Add(-16);
                }

                if ((current % 5) == 0) //Last Column
                {
                    moves.Remove(-11);
                    moves.Remove(6);
                    moves.Remove(-15);
                    moves.Remove(-19);

                    moves.Add(-9);
                    moves.Add(16);
                }
            }

            current--; // Restore current to original number

            bool removed;
            do //Remove any moves that are outside the board
            {
                removed = false;
                for (int m = 0; m < moves.Count; m++)
                {
                    if ((current + (int)moves[m]) < 0 || ((current + (int)moves[m]) > 24))
                    {
                        moves.RemoveAt(m);
                        removed = true;
                    }
                }
            }
            while (removed);

            
            return moves;

        }

        private ArrayList ValidMoves_Standard(int current)
        {
            ArrayList moves = new ArrayList();
            current++; //Increase current so that first die is 1 not 0
            moves.Add(-1);
            moves.Add(-3);
            moves.Add(-4);
            moves.Add(-5);
            moves.Add(1);
            moves.Add(3);
            moves.Add(4);
            moves.Add(5);

            if (bound == BoundaryMode.PERIODIC)
            {
                moves.Add(11);
                moves.Add(12);
                moves.Add(13);

                moves.Add(-11);
                moves.Add(-12);
                moves.Add(-13);

                if ((current % 4) == 1) //First Column
                {
                    moves.Remove(11);
                    moves.Remove(-5);
                    moves.Add(-9);
                    moves.Add(7);
                    moves.Add(15);
                }

                if ((current % 4) == 0) //Last Column
                {
                    moves.Remove(-11);
                    moves.Remove(5);
                    moves.Add(9);
                    moves.Add(-7);
                    moves.Add(-15);
                }
            }

            current--; // Restore current to original number

            bool removed;
            do //Remove any moves that are outside the board
            {
                removed = false;
                for (int m = 0; m < moves.Count; m++)
                {
                    if ((current + (int)moves[m]) < 0 || ((current + (int)moves[m]) > 15)) 
                    {
                        moves.RemoveAt(m);
                        removed = true;
                    }
                }              
            }
            while (removed);

            return moves;

        }
    }
}
