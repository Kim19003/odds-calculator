
namespace Odds_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.leftPerCentBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resetButton = new System.Windows.Forms.Button();
            this.breakpointBox = new System.Windows.Forms.ComboBox();
            this.rightOddsLabel = new System.Windows.Forms.Label();
            this.leftOddsLabel = new System.Windows.Forms.Label();
            this.proceedButton = new System.Windows.Forms.Button();
            this.rightPerCentBox = new System.Windows.Forms.TextBox();
            this.upperTeamNameDisplayBox = new System.Windows.Forms.TextBox();
            this.lowerTeamNameDisplayBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rightTeamNameBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.leftTeamNameBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPerCentBox
            // 
            this.leftPerCentBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftPerCentBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.leftPerCentBox.Location = new System.Drawing.Point(234, 48);
            this.leftPerCentBox.MaxLength = 2;
            this.leftPerCentBox.Name = "leftPerCentBox";
            this.leftPerCentBox.Size = new System.Drawing.Size(43, 29);
            this.leftPerCentBox.TabIndex = 0;
            this.leftPerCentBox.TabStop = false;
            this.leftPerCentBox.Text = "%";
            this.leftPerCentBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.leftPerCentBox.TextChanged += new System.EventHandler(this.leftPerCentBox_TextChanged);
            this.leftPerCentBox.Enter += new System.EventHandler(this.leftPerCentBox_Enter);
            this.leftPerCentBox.Leave += new System.EventHandler(this.leftPerCentBox_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.resetButton);
            this.panel1.Controls.Add(this.breakpointBox);
            this.panel1.Controls.Add(this.proceedButton);
            this.panel1.Controls.Add(this.rightPerCentBox);
            this.panel1.Controls.Add(this.leftPerCentBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(29, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 260);
            this.panel1.TabIndex = 1;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Transparent;
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(254, 221);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(49, 23);
            this.resetButton.TabIndex = 6;
            this.resetButton.TabStop = false;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // breakpointBox
            // 
            this.breakpointBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakpointBox.FormattingEnabled = true;
            this.breakpointBox.Items.AddRange(new object[] {
            "1.82",
            "1.83",
            "1.84",
            "1.85",
            "1.86",
            "1.87",
            "1.88",
            "1.89",
            "1.90",
            "1.91",
            "1.92",
            "1.93",
            "1.94",
            "1.95"});
            this.breakpointBox.Location = new System.Drawing.Point(254, 18);
            this.breakpointBox.MaxDropDownItems = 14;
            this.breakpointBox.Name = "breakpointBox";
            this.breakpointBox.Size = new System.Drawing.Size(49, 24);
            this.breakpointBox.TabIndex = 5;
            this.breakpointBox.TabStop = false;
            // 
            // rightOddsLabel
            // 
            this.rightOddsLabel.AutoSize = true;
            this.rightOddsLabel.BackColor = System.Drawing.Color.OldLace;
            this.rightOddsLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightOddsLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rightOddsLabel.Location = new System.Drawing.Point(241, 48);
            this.rightOddsLabel.Name = "rightOddsLabel";
            this.rightOddsLabel.Size = new System.Drawing.Size(36, 18);
            this.rightOddsLabel.TabIndex = 4;
            this.rightOddsLabel.Text = "1.55";
            this.rightOddsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // leftOddsLabel
            // 
            this.leftOddsLabel.AutoSize = true;
            this.leftOddsLabel.BackColor = System.Drawing.Color.OldLace;
            this.leftOddsLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftOddsLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.leftOddsLabel.Location = new System.Drawing.Point(241, 14);
            this.leftOddsLabel.Name = "leftOddsLabel";
            this.leftOddsLabel.Size = new System.Drawing.Size(36, 18);
            this.leftOddsLabel.TabIndex = 3;
            this.leftOddsLabel.Text = "1.55";
            this.leftOddsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // proceedButton
            // 
            this.proceedButton.BackColor = System.Drawing.Color.Transparent;
            this.proceedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proceedButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceedButton.Location = new System.Drawing.Point(234, 85);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(92, 29);
            this.proceedButton.TabIndex = 2;
            this.proceedButton.TabStop = false;
            this.proceedButton.Text = "Proceed";
            this.proceedButton.UseVisualStyleBackColor = false;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // rightPerCentBox
            // 
            this.rightPerCentBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightPerCentBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.rightPerCentBox.Location = new System.Drawing.Point(283, 48);
            this.rightPerCentBox.MaxLength = 2;
            this.rightPerCentBox.Name = "rightPerCentBox";
            this.rightPerCentBox.Size = new System.Drawing.Size(43, 29);
            this.rightPerCentBox.TabIndex = 1;
            this.rightPerCentBox.TabStop = false;
            this.rightPerCentBox.Text = "%";
            this.rightPerCentBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rightPerCentBox.TextChanged += new System.EventHandler(this.rightPerCentBox_TextChanged);
            this.rightPerCentBox.Enter += new System.EventHandler(this.rightPerCentBox_Enter);
            this.rightPerCentBox.Leave += new System.EventHandler(this.rightPerCentBox_Leave);
            // 
            // upperTeamNameDisplayBox
            // 
            this.upperTeamNameDisplayBox.BackColor = System.Drawing.Color.OldLace;
            this.upperTeamNameDisplayBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.upperTeamNameDisplayBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.upperTeamNameDisplayBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upperTeamNameDisplayBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.upperTeamNameDisplayBox.Location = new System.Drawing.Point(11, 13);
            this.upperTeamNameDisplayBox.MaxLength = 26;
            this.upperTeamNameDisplayBox.Multiline = true;
            this.upperTeamNameDisplayBox.Name = "upperTeamNameDisplayBox";
            this.upperTeamNameDisplayBox.Size = new System.Drawing.Size(209, 20);
            this.upperTeamNameDisplayBox.TabIndex = 7;
            this.upperTeamNameDisplayBox.TabStop = false;
            this.upperTeamNameDisplayBox.Text = "South Korea";
            // 
            // lowerTeamNameDisplayBox
            // 
            this.lowerTeamNameDisplayBox.BackColor = System.Drawing.Color.OldLace;
            this.lowerTeamNameDisplayBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lowerTeamNameDisplayBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lowerTeamNameDisplayBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowerTeamNameDisplayBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lowerTeamNameDisplayBox.Location = new System.Drawing.Point(11, 47);
            this.lowerTeamNameDisplayBox.MaxLength = 26;
            this.lowerTeamNameDisplayBox.Multiline = true;
            this.lowerTeamNameDisplayBox.Name = "lowerTeamNameDisplayBox";
            this.lowerTeamNameDisplayBox.Size = new System.Drawing.Size(209, 20);
            this.lowerTeamNameDisplayBox.TabIndex = 8;
            this.lowerTeamNameDisplayBox.TabStop = false;
            this.lowerTeamNameDisplayBox.Text = "Hong Kong";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OldLace;
            this.panel2.Controls.Add(this.lowerTeamNameDisplayBox);
            this.panel2.Controls.Add(this.upperTeamNameDisplayBox);
            this.panel2.Controls.Add(this.leftOddsLabel);
            this.panel2.Controls.Add(this.rightOddsLabel);
            this.panel2.Location = new System.Drawing.Point(134, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 78);
            this.panel2.TabIndex = 9;
            // 
            // rightTeamNameBox
            // 
            this.rightTeamNameBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rightTeamNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rightTeamNameBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightTeamNameBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rightTeamNameBox.Location = new System.Drawing.Point(6, 4);
            this.rightTeamNameBox.MaxLength = 26;
            this.rightTeamNameBox.Name = "rightTeamNameBox";
            this.rightTeamNameBox.Size = new System.Drawing.Size(179, 22);
            this.rightTeamNameBox.TabIndex = 11;
            this.rightTeamNameBox.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.rightTeamNameBox);
            this.panel3.Location = new System.Drawing.Point(333, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(190, 30);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel4.Controls.Add(this.leftTeamNameBox);
            this.panel4.Location = new System.Drawing.Point(38, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(190, 30);
            this.panel4.TabIndex = 13;
            // 
            // leftTeamNameBox
            // 
            this.leftTeamNameBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.leftTeamNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.leftTeamNameBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftTeamNameBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.leftTeamNameBox.Location = new System.Drawing.Point(6, 4);
            this.leftTeamNameBox.MaxLength = 26;
            this.leftTeamNameBox.Name = "leftTeamNameBox";
            this.leftTeamNameBox.Size = new System.Drawing.Size(179, 22);
            this.leftTeamNameBox.TabIndex = 11;
            this.leftTeamNameBox.TabStop = false;
            this.leftTeamNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 329);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Odds Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox leftPerCentBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox rightPerCentBox;
        private System.Windows.Forms.Button proceedButton;
        private System.Windows.Forms.Label leftOddsLabel;
        private System.Windows.Forms.Label rightOddsLabel;
        private System.Windows.Forms.ComboBox breakpointBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox upperTeamNameDisplayBox;
        private System.Windows.Forms.TextBox lowerTeamNameDisplayBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox rightTeamNameBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox leftTeamNameBox;
    }
}

