using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Boggle
{
    public partial class Options : Form
    {
        
        ScoringMode scoreMode = ScoringMode.STANDARD;
        BoardSize boardSize = BoardSize.STANDARD;
        BoundaryMode boundMode = BoundaryMode.STANDARD;
        int timeLimit = 3 * 60000;
        int wordMin = 3;
        BoggleGUI boggle;
        public string customDice = null;
        public string customWords = null;
        public Options()
        {
            InitializeComponent();
            
            
        }

        private void Options_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            boggle = new BoggleGUI(this, btnColorValid.BackColor, btnColorSelected.BackColor,scoreMode,boardSize, boundMode, timeLimit, wordMin);
            boggle.Show();
            this.Hide();
        }

        private void radModeStandard_CheckedChanged(object sender, EventArgs e)
        {
            if (radModeStandard.Checked)
            {
                scoreMode = ScoringMode.STANDARD;
               
            }
        }

        private void radModeScrabble_CheckedChanged(object sender, EventArgs e)
        {
            if (radModeScrabble.Checked)
            {
                scoreMode = ScoringMode.SCRABBLE;
            }
        }

        private void radModePointPer_CheckedChanged(object sender, EventArgs e)
        {
            if (radModePointPer.Checked)
            {
                scoreMode = ScoringMode.POINTPERLETTER;
            }
        }

        private void Options_FormClosed(object sender, FormClosedEventArgs e)
        {
            
           
        }

        private void btnColorValid_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btnColorValid.BackColor = colorDialog1.Color;

        }

        private void btnColorSelected_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btnColorSelected.BackColor = colorDialog1.Color;
        }

        
        private void Options_Activated(object sender, EventArgs e)
        {
            this.Show();
        }

        private void radSizeStandard_CheckedChanged(object sender, EventArgs e)
        {
            if (radSizeStandard.Checked)
            {
                boardSize = BoardSize.STANDARD;
            }
        }

        private void radSizeBig_CheckedChanged(object sender, EventArgs e)
        {
            if (radSizeBig.Checked)
            {
                boardSize = BoardSize.BIGBOGGLE;
            }
        }

        private void radBoundStandard_CheckedChanged(object sender, EventArgs e)
        {
            if (radBoundStandard.Checked)
            {
                boundMode = BoundaryMode.STANDARD;
            }
        }

        private void radBoundPeriod_CheckedChanged(object sender, EventArgs e)
        {
            if (radBoundPeriod.Checked)
            {
                boundMode = BoundaryMode.PERIODIC;
            }
        }

        private void numLength_ValueChanged(object sender, EventArgs e)
        {
            wordMin = (int)numLength.Value;
        }

        private void numTime_ValueChanged(object sender, EventArgs e)
        {
            timeLimit = (int)numTime.Value * 60000;
        }

        private void radEasy_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Enabled = false;

            radBoundStandard.Checked = true;
            radSizeBig.Checked = true;
            radModeStandard.Checked = true;
            numLength.Value = 2;
            numTime.Value = 4;
            customWords = null;
            customDice = null;
        }

        private void radMedium_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Enabled = false;

            radBoundStandard.Checked = true;
            radSizeStandard.Checked = true;
            radModeStandard.Checked = true;
            numLength.Value = 3;
            numTime.Value = 3;
            customWords = null;
            customDice = null;
        }

        private void radHard_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Enabled = false;

            radBoundStandard.Checked = true;
            radSizeBig.Checked = true;
            radModeStandard.Checked = true;
            numLength.Value = 4;
            numTime.Value = 3;
            customWords = null;
            customDice = null;
        }

        private void radCustom_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Enabled = true;
        }

        private void btnCustomDice_Click(object sender, EventArgs e)
        {
            of_DiceSets.ShowDialog(this);
            customDice = of_DiceSets.FileName;
        }

        private void btnCustomWords_Click(object sender, EventArgs e)
        {
            of_WordList.ShowDialog();
            customWords = of_WordList.FileName;
            
        }

        private void Options_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible && boggle != null)
            {
                boggle.Close();
            }
        }

       
    }
}
