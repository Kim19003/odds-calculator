using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odds_Calculator
{
    public partial class Form1 : Form
    {
        public const string AppName = "Odds Calculator";

        public Form1()
        {
            InitializeComponent();

            //Reset();

            selectTeamComboBox.SelectedItem = "Unibet";
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Location = new Point(Properties.Settings.Default.Location.X, Properties.Settings.Default.Location.Y);
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Location = Location;
            Properties.Settings.Default.Save();
        }

        private void leftPerCentBox_TextChanged(object sender, EventArgs e)
        {
            if (leftPerCentBox.ForeColor == SystemColors.GrayText)
            {
                leftPerCentBox.ForeColor = SystemColors.WindowText;
            }

            try
            {
                rightPerCentBox.Text = NumberForerunner(int.Parse(leftPerCentBox.Text)).ToString();
            }
            catch
            {
            }

            if (string.IsNullOrEmpty(leftPerCentBox.Text) && !rightPerCentBox.Focused)
            {
                rightPerCentBox.Text = "";

                //TryToAddPlaceholder(rightPerCentBox, false);
            }
        }

        private void rightPerCentBox_TextChanged(object sender, EventArgs e)
        {
            if (rightPerCentBox.ForeColor == SystemColors.GrayText)
            {
                rightPerCentBox.ForeColor = SystemColors.WindowText;
            }

            try
            {
                leftPerCentBox.Text = NumberForerunner(int.Parse(rightPerCentBox.Text)).ToString();
            }
            catch
            {
            }

            if (string.IsNullOrEmpty(rightPerCentBox.Text) && !leftPerCentBox.Focused)
            {
                leftPerCentBox.Text = "";

                //TryToAddPlaceholder(leftPerCentBox, false);
            }
        }

        private void leftPerCentBox_Enter(object sender, EventArgs e)
        {
            //TryToAddPlaceholder(leftPerCentBox, true);
        }

        private void leftPerCentBox_Leave(object sender, EventArgs e)
        {
            //TryToAddPlaceholder(leftPerCentBox, false);
        }

        private void rightPerCentBox_Enter(object sender, EventArgs e)
        {
            //TryToAddPlaceholder(rightPerCentBox, true);
        }

        private void rightPerCentBox_Leave(object sender, EventArgs e)
        {
            //TryToAddPlaceholder(rightPerCentBox, false);
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            Proceed();
        }

        private void Proceed()
        {
            if (ValuesAllowed(leftPerCentBox, rightPerCentBox))
            {
                CalculateOdds(double.Parse(breakpointBox.Text.Replace('.', ',')));
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Reset values?", AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Reset();
            }
        }

        private void CalculateOdds(double breakpoint)
        {
            int leftPercentage = int.Parse(leftPerCentBox.Text);
            double leftOdds = Math.Round(Math.Round(breakpoint / 2.0, 3) / (leftPercentage / 100.0), 2);

            if (leftOdds > 1.00)
            {
                leftOddsLabel.Text = leftOdds.ToString("0.00").Replace(',', '.');
            }
            else
            {
                leftOddsLabel.Text = "";
            }

            int rightPercentage = int.Parse(rightPerCentBox.Text);
            double rightOdds = Math.Round(Math.Round(breakpoint / 2.0, 3) / (rightPercentage / 100.0), 2);

            if (rightOdds > 1.00)
            {
                rightOddsLabel.Text = rightOdds.ToString("0.00").Replace(',', '.');
            }
            else
            {
                rightOddsLabel.Text = "";
            }
        }

        private bool ValuesAllowed(TextBox leftPerCentBox, TextBox rightPerCentBox)
        {
            try
            {
                if (!(int.Parse(leftPerCentBox.Text) == 0 || int.Parse(rightPerCentBox.Text) == 0))
                {
                    return true;
                }
            }
            catch
            {
            }

            return false;
        }

        private int NumberForerunner(int numberToForerun)
        {
            int result = (100 - numberToForerun);

            if (result > 0)
            {
                return result;
            }

            return 0;
        }

        private void TryToAddPlaceholder(TextBox textBox, bool isEntering)
        {
            if (isEntering)
            {
                if (textBox.Text == "%")
                {
                    textBox.ForeColor = SystemColors.WindowText;
                    textBox.Text = "";
                }
            }
            else
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.ForeColor = SystemColors.GrayText;
                    textBox.Text = "%";
                }
            }
        }

        private void Reset()
        {
            leftPerCentBox.Text = "50";
            rightPerCentBox.Text = "50";

            leftOddsLabel.Text = "1.87";
            rightOddsLabel.Text = "1.87";

            upperTeamNameDisplayBox.Text = "ENCE";
            lowerTeamNameDisplayBox.Text = "NiP Gaming";

            breakpointBox.Text = "1.87";

            matchDateTextBox.Text = "Today";
            matchTimeTextBox.Text = "20:00";
        }

        private void participant1OddsMinusButton_Click(object sender, EventArgs e)
        {
            try
            {
                int newPercentage = int.Parse(leftPerCentBox.Text) - 1;

                if (newPercentage >= 0 && newPercentage <= 100)
                {
                    leftPerCentBox.Text = newPercentage.ToString();
                }
            }
            catch
            {
            }
        }

        private void participant1OddsPlusButton_Click(object sender, EventArgs e)
        {
            try
            {
                int newPercentage = int.Parse(leftPerCentBox.Text) + 1;

                if (newPercentage >= 0 && newPercentage <= 100)
                {
                    leftPerCentBox.Text = newPercentage.ToString();
                }
            }
            catch
            {
            }
        }

        private void participant2OddsMinusButton_Click(object sender, EventArgs e)
        {
            try
            {
                int newPercentage = int.Parse(rightPerCentBox.Text) - 1;

                if (newPercentage >= 0 && newPercentage <= 100)
                {
                    rightPerCentBox.Text = newPercentage.ToString();
                }
            }
            catch
            {
            }
        }

        private void participant2OddsPlusButton_Click(object sender, EventArgs e)
        {
            try
            {
                int newPercentage = int.Parse(rightPerCentBox.Text) + 1;

                if (newPercentage >= 0 && newPercentage <= 100)
                {
                    rightPerCentBox.Text = newPercentage.ToString();
                }
            }
            catch
            {
            }
        }

        private void leftTeamNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Proceed();

                e.Handled = true;
            }
        }

        private void rightTeamNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Proceed();

                e.Handled = true;
            }
        }

        private void selectTeamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // All themes: Unibet, Betsson, Betway, Veikkaus, GGBet
        }

        private void oddsLeftParticipantPictureBox_Click(object sender, EventArgs e)
        {
            SetImageForPictureBoxFromLocalSource(oddsLeftParticipantPictureBox);
        }

        private void oddsRightParticipantPictureBox_Click(object sender, EventArgs e)
        {
            SetImageForPictureBoxFromLocalSource(oddsRightParticipantPictureBox);
        }

        private void SetImageForPictureBoxFromLocalSource(PictureBox pictureBox)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;",
                RestoreDirectory = true
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(fileDialog.FileName);
            }
        }

        private void unibetLeftOddsPanel_MouseEnter(object sender, EventArgs e)
        {
            unibetLeftOddsPanel.BackColor = UnibetHoverButtonBackColor();
        }

        private void unibetLeftOddsPanel_MouseLeave(object sender, EventArgs e)
        {
            unibetLeftOddsPanel.BackColor = UnibetDefaultButtonBackColor();
        }

        private void unibetRightOddsPanel_MouseEnter(object sender, EventArgs e)
        {
            unibetRightOddsPanel.BackColor = UnibetHoverButtonBackColor();
        }

        private void unibetRightOddsPanel_MouseLeave(object sender, EventArgs e)
        {
            unibetRightOddsPanel.BackColor = UnibetDefaultButtonBackColor();
        }

        private void leftOddsLabel_MouseEnter(object sender, EventArgs e)
        {
            unibetLeftOddsPanel.BackColor = UnibetHoverButtonBackColor();
        }

        private void leftOddsLabel_MouseLeave(object sender, EventArgs e)
        {
            unibetLeftOddsPanel.BackColor = UnibetDefaultButtonBackColor();
        }

        private void rightOddsLabel_MouseEnter(object sender, EventArgs e)
        {
            unibetRightOddsPanel.BackColor = UnibetHoverButtonBackColor();
        }

        private void rightOddsLabel_MouseLeave(object sender, EventArgs e)
        {
            unibetRightOddsPanel.BackColor = UnibetDefaultButtonBackColor();
        }

        private Color UnibetDefaultButtonBackColor()
        {
            return Color.FromArgb(20, 123, 69);
        }
        
        private Color UnibetHoverButtonBackColor()
        {
            return Color.FromArgb(0, 88, 44);
        }

        private void showSettingsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!showSettingsCheckBox.Checked)
            {
                settingsPanel.Visible = false;
            }
            else
            {
                settingsPanel.Visible = true;
            }
        }
    }
}
