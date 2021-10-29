
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPerCentBox
            // 
            this.leftPerCentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftPerCentBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.leftPerCentBox.Location = new System.Drawing.Point(15, 43);
            this.leftPerCentBox.MaxLength = 2;
            this.leftPerCentBox.Name = "leftPerCentBox";
            this.leftPerCentBox.Size = new System.Drawing.Size(43, 31);
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
            this.panel1.Controls.Add(this.resetButton);
            this.panel1.Controls.Add(this.breakpointBox);
            this.panel1.Controls.Add(this.rightOddsLabel);
            this.panel1.Controls.Add(this.leftOddsLabel);
            this.panel1.Controls.Add(this.proceedButton);
            this.panel1.Controls.Add(this.rightPerCentBox);
            this.panel1.Controls.Add(this.leftPerCentBox);
            this.panel1.Location = new System.Drawing.Point(64, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 228);
            this.panel1.TabIndex = 1;
            // 
            // resetButton
            // 
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.Location = new System.Drawing.Point(35, 192);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(49, 23);
            this.resetButton.TabIndex = 6;
            this.resetButton.TabStop = false;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // breakpointBox
            // 
            this.breakpointBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.breakpointBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.breakpointBox.Location = new System.Drawing.Point(35, 13);
            this.breakpointBox.MaxDropDownItems = 14;
            this.breakpointBox.Name = "breakpointBox";
            this.breakpointBox.Size = new System.Drawing.Size(49, 24);
            this.breakpointBox.TabIndex = 5;
            this.breakpointBox.TabStop = false;
            // 
            // rightOddsLabel
            // 
            this.rightOddsLabel.AutoSize = true;
            this.rightOddsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.rightOddsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightOddsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.rightOddsLabel.Location = new System.Drawing.Point(64, 119);
            this.rightOddsLabel.Name = "rightOddsLabel";
            this.rightOddsLabel.Size = new System.Drawing.Size(45, 24);
            this.rightOddsLabel.TabIndex = 4;
            this.rightOddsLabel.Text = "1.55";
            this.rightOddsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // leftOddsLabel
            // 
            this.leftOddsLabel.AutoSize = true;
            this.leftOddsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.leftOddsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftOddsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.leftOddsLabel.Location = new System.Drawing.Point(13, 119);
            this.leftOddsLabel.Name = "leftOddsLabel";
            this.leftOddsLabel.Size = new System.Drawing.Size(45, 24);
            this.leftOddsLabel.TabIndex = 3;
            this.leftOddsLabel.Text = "1.55";
            this.leftOddsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // proceedButton
            // 
            this.proceedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proceedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceedButton.Location = new System.Drawing.Point(15, 80);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(92, 29);
            this.proceedButton.TabIndex = 2;
            this.proceedButton.TabStop = false;
            this.proceedButton.Text = "Proceed";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // rightPerCentBox
            // 
            this.rightPerCentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightPerCentBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.rightPerCentBox.Location = new System.Drawing.Point(64, 43);
            this.rightPerCentBox.MaxLength = 2;
            this.rightPerCentBox.Name = "rightPerCentBox";
            this.rightPerCentBox.Size = new System.Drawing.Size(43, 31);
            this.rightPerCentBox.TabIndex = 1;
            this.rightPerCentBox.TabStop = false;
            this.rightPerCentBox.Text = "%";
            this.rightPerCentBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rightPerCentBox.TextChanged += new System.EventHandler(this.rightPerCentBox_TextChanged);
            this.rightPerCentBox.Enter += new System.EventHandler(this.rightPerCentBox_Enter);
            this.rightPerCentBox.Leave += new System.EventHandler(this.rightPerCentBox_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 298);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Odds Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}

