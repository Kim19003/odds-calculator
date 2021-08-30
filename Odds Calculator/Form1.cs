﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odds_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Reset();
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

                TryToAddPlaceholder(rightPerCentBox, false);
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

                TryToAddPlaceholder(leftPerCentBox, false);
            }
        }

        private void leftPerCentBox_Enter(object sender, EventArgs e)
        {
            TryToAddPlaceholder(leftPerCentBox, true);
        }

        private void leftPerCentBox_Leave(object sender, EventArgs e)
        {
            TryToAddPlaceholder(leftPerCentBox, false);
        }

        private void rightPerCentBox_Enter(object sender, EventArgs e)
        {
            TryToAddPlaceholder(rightPerCentBox, true);
        }

        private void rightPerCentBox_Leave(object sender, EventArgs e)
        {
            TryToAddPlaceholder(rightPerCentBox, false);
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            if (ValuesAllowed(leftPerCentBox, rightPerCentBox))
            {
                CalculateOdds(double.Parse(breakpointBox.Text.Replace('.', ',')));
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void CalculateOdds(double breakpoint)
        {
            int leftPercentage = int.Parse(leftPerCentBox.Text);
            double leftOdds = Math.Round(Math.Round(breakpoint / 2.0, 3) / (leftPercentage / 100.0), 2);

            if (leftOdds > 1.00)
            {
                leftOddsLabel.Text = leftOdds.ToString("0.00");
            }
            else
            {
                leftOddsLabel.Text = "";
            }

            int rightPercentage = int.Parse(rightPerCentBox.Text);
            double rightOdds = Math.Round(Math.Round(breakpoint / 2.0, 3) / (rightPercentage / 100.0), 2);

            if (rightOdds > 1.00)
            {
                rightOddsLabel.Text = rightOdds.ToString("0.00");
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
            leftPerCentBox.Text = "%";
            leftPerCentBox.ForeColor = SystemColors.GrayText;
            rightPerCentBox.Text = "%";
            rightPerCentBox.ForeColor = SystemColors.GrayText;

            leftOddsLabel.Text = "";
            rightOddsLabel.Text = "";

            breakpointBox.Text = "1.85";
        }
    }
}