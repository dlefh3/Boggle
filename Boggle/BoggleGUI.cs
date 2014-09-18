using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Collections;


namespace Boggle
{

    public partial class BoggleGUI : Form
    {
        public static Boggle game = null;
        Button[] btnArray;
        ArrayList usedDie = new ArrayList();
        public static Color colorValid = Color.Lime;
        public static Color colorSelected = Color.Green;
        ScoringMode scoreMode;
        BoardSize boardSize;
        BoundaryMode boundMode;
        int timeLimit;
        int wordMin;
        
        Options caller;

        public BoggleGUI(Options c, Color valid_move, Color selected_move, ScoringMode score_mode = ScoringMode.SCRABBLE, BoardSize board_size = BoardSize.BIGBOGGLE,
            BoundaryMode bound_mode = BoundaryMode.STANDARD, int t_limit = 180000, int min_length = 3)
        {
            InitializeComponent();

            caller = (Options)c;
            colorValid = valid_move;
            colorSelected = selected_move;
            scoreMode = score_mode;
            boardSize = board_size;
            boundMode = bound_mode;
            timeLimit = t_limit;
            wordMin = min_length;
            string dice = caller.customDice;
            string word = caller.customWords;
            
            //Create psuedo control array
            btnArray = new Button[(int)boardSize];

            btnArray[0] = button1;
            btnArray[1] = button2;
            btnArray[2] = button3;
            btnArray[3] = button4;
            btnArray[4] = button5;
            btnArray[5] = button6;
            btnArray[6] = button7;
            btnArray[7] = button8;
            btnArray[8] = button9;
            btnArray[9] = button10;
            btnArray[10] = button11;
            btnArray[11] = button12;
            btnArray[12] = button13;
            btnArray[13] = button14;
            btnArray[14] = button15;
            btnArray[15] = button16;
            if (boardSize == BoardSize.BIGBOGGLE) // If Big Boggle need all the buttons
            {

                btnArray[16] = button17;
                btnArray[17] = button18;
                btnArray[18] = button19;
                btnArray[19] = button20;
                btnArray[20] = button21;
                btnArray[21] = button22;
                btnArray[22] = button23;
                btnArray[23] = button24;
                btnArray[24] = button25;

            }
            else // Else if Standard hide the extra buttons
            {
                button17.Visible = false;
                button18.Visible = false;
                button19.Visible = false;
                button20.Visible = false;
                button21.Visible = false;
                button22.Visible = false;
                button23.Visible = false;
                button24.Visible = false;
                button25.Visible = false;
                int btnNumber = 0;
                for (int row = 0; row < 4; row++) //Rearrange the buttons into a 4x4 grid
                {
                    for (int col = 0; col < 4; col++)
                    {
                        Point myPoint = new Point(41 * (col % 4), (41 * row));
                        btnArray[btnNumber].Location = myPoint;
                        btnNumber++;
                    }



                }
            }


        }



        private void BoggleGUI_Load(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
           
            if (game.status != GameStatus.RUNNING)
            {
                panel1.Enabled = false;
                timer1.Stop();
            }

        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (game.PlayWord(txtWord.Text)) //If word was played
            {

                txtScore.Text = game.score.ToString(); //Update score
                txtUsedWords.Text += game.LastWord() + "\n"; //Add word to used word list
            }
            txtWord.Text = ""; //Clear current word
            foreach (Button b in btnArray) // Reset buttons
            {
                b.Enabled = true;
                b.FlatStyle = FlatStyle.Standard;
                b.FlatAppearance.BorderSize = 1;
                b.UseVisualStyleBackColor = true;
            }
            usedDie.Clear(); //Clear used letters
            
        }

        private void txtScore_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Key(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) //Alows spacebar to submit word
            {
                e.Handled = true;
                btnSubmit_Click(sender, e);
            }
        }

        private void MasterClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            ArrayList moves = game.PlayLetter((int)b.Tag);
            if (moves != null)
            {
                txtWord.Text += b.Text; //Add letter to current word
                for (int count = 0; count < (int)boardSize; count++)
                {
                    btnArray[count].BackColor = SystemColors.Control; //Reset color        
                    btnArray[count].UseVisualStyleBackColor = true; //Reset style
                    btnArray[count].Enabled = true;

                    switch ((int)moves[count])
                    {
                        case 0:
                            btnArray[count].Enabled = false;
                            break;
                        case 1:
                            btnArray[count].BackColor = colorValid;
                            break;
                        case 2:
                            btnArray[count].BackColor = colorSelected;
                            break;
                        case 3:
                            btnArray[count].Enabled = false; //Disable used buttons
                            btnArray[count].FlatStyle = FlatStyle.Flat;
                            btnArray[count].FlatAppearance.BorderSize = 2;
                            break;
                        default:
                            btnArray[count].BackColor = Color.HotPink;
                            break;
                    }


                }
            }

        }



       

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BoggleGUI_EnabledChanged(object sender, EventArgs e)
        {
            if (this.Enabled)
            {
                panel1.Visible = true;
                if (game != null)
                    timer1.Start();
            }
            else
            {
                timer1.Stop();
            }

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

            game = new Boggle(scoreMode, boardSize, boundMode, timeLimit, wordMin);
            string[] board = game.GetBoard();

            for (int i = 0; i < btnArray.Length; i++)
            {
                btnArray[i].Tag = i;
                btnArray[i].Click += new EventHandler(MasterClick);
                btnArray[i].Text = board[i];

                btnArray[i].BackColor = SystemColors.Control; //Reset color        
                btnArray[i].UseVisualStyleBackColor = true; //Reset style
                btnArray[i].FlatAppearance.BorderSize = 1;
                btnArray[i].FlatStyle = FlatStyle.Standard;

                btnArray[i].Enabled = true;

                usedDie.Clear();
                txtWord.Text = "";
            }

            if (caller.customDice != null)
            {
                game.ChangeDiceSet(caller.customDice);
            }

            if (caller.customWords != null)
            {
                game.ChangeWordList(caller.customWords);
            }

            timer1.Start();
            progressBar1.Value = 0;
            progressBar1.Maximum = game.gameLength;
            panel1.Enabled = true;
            game.StartGame();
        }

        private void BoggleGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            caller.Show();
            
        }

        private void optionsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            caller.Show();
            this.Close();
        }





    }
}
