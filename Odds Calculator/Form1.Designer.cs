
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
            this.showSettingsCheckBox = new System.Windows.Forms.CheckBox();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.proceedButton = new System.Windows.Forms.Button();
            this.rightPerCentBox = new System.Windows.Forms.TextBox();
            this.participant2OddsMinusButton = new System.Windows.Forms.Button();
            this.breakpointBox = new System.Windows.Forms.ComboBox();
            this.participant2OddsPlusButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.participant1OddsMinusButton = new System.Windows.Forms.Button();
            this.startingOddsLabel = new System.Windows.Forms.Label();
            this.participant1OddsPlusButton = new System.Windows.Forms.Button();
            this.selectTeamComboBox = new System.Windows.Forms.ComboBox();
            this.percentageSymbolLabel2 = new System.Windows.Forms.Label();
            this.selectThemeLabel = new System.Windows.Forms.Label();
            this.percentageSymbolLabel1 = new System.Windows.Forms.Label();
            this.screenshotAreaPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.oddsLeftParticipantPictureBox = new System.Windows.Forms.PictureBox();
            this.oddsRightParticipantPictureBox = new System.Windows.Forms.PictureBox();
            this.unibetRightOddsPanel = new System.Windows.Forms.Panel();
            this.rightOddsLabel = new System.Windows.Forms.Label();
            this.unibetLeftOddsPanel = new System.Windows.Forms.Panel();
            this.leftOddsLabel = new System.Windows.Forms.Label();
            this.lowerTeamNameDisplayBox = new System.Windows.Forms.TextBox();
            this.upperTeamNameDisplayBox = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.matchTimeTextBox = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.matchDateTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.screenshotAreaPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oddsLeftParticipantPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oddsRightParticipantPictureBox)).BeginInit();
            this.unibetRightOddsPanel.SuspendLayout();
            this.unibetLeftOddsPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPerCentBox
            // 
            this.leftPerCentBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftPerCentBox.ForeColor = System.Drawing.Color.Black;
            this.leftPerCentBox.Location = new System.Drawing.Point(139, 91);
            this.leftPerCentBox.MaxLength = 2;
            this.leftPerCentBox.Name = "leftPerCentBox";
            this.leftPerCentBox.Size = new System.Drawing.Size(43, 26);
            this.leftPerCentBox.TabIndex = 0;
            this.leftPerCentBox.TabStop = false;
            this.leftPerCentBox.Text = "50";
            this.leftPerCentBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.leftPerCentBox.TextChanged += new System.EventHandler(this.leftPerCentBox_TextChanged);
            this.leftPerCentBox.Enter += new System.EventHandler(this.leftPerCentBox_Enter);
            this.leftPerCentBox.Leave += new System.EventHandler(this.leftPerCentBox_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.showSettingsCheckBox);
            this.panel1.Controls.Add(this.settingsPanel);
            this.panel1.Controls.Add(this.screenshotAreaPanel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 468);
            this.panel1.TabIndex = 1;
            // 
            // showSettingsCheckBox
            // 
            this.showSettingsCheckBox.AutoSize = true;
            this.showSettingsCheckBox.Checked = true;
            this.showSettingsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showSettingsCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showSettingsCheckBox.Location = new System.Drawing.Point(540, 448);
            this.showSettingsCheckBox.Name = "showSettingsCheckBox";
            this.showSettingsCheckBox.Size = new System.Drawing.Size(98, 17);
            this.showSettingsCheckBox.TabIndex = 32;
            this.showSettingsCheckBox.Text = "Show settings?";
            this.showSettingsCheckBox.UseVisualStyleBackColor = true;
            this.showSettingsCheckBox.CheckedChanged += new System.EventHandler(this.showSettingsCheckBox_CheckedChanged);
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.settingsPanel.Controls.Add(this.proceedButton);
            this.settingsPanel.Controls.Add(this.leftPerCentBox);
            this.settingsPanel.Controls.Add(this.rightPerCentBox);
            this.settingsPanel.Controls.Add(this.participant2OddsMinusButton);
            this.settingsPanel.Controls.Add(this.breakpointBox);
            this.settingsPanel.Controls.Add(this.participant2OddsPlusButton);
            this.settingsPanel.Controls.Add(this.resetButton);
            this.settingsPanel.Controls.Add(this.participant1OddsMinusButton);
            this.settingsPanel.Controls.Add(this.startingOddsLabel);
            this.settingsPanel.Controls.Add(this.participant1OddsPlusButton);
            this.settingsPanel.Controls.Add(this.selectTeamComboBox);
            this.settingsPanel.Controls.Add(this.percentageSymbolLabel2);
            this.settingsPanel.Controls.Add(this.selectThemeLabel);
            this.settingsPanel.Controls.Add(this.percentageSymbolLabel1);
            this.settingsPanel.Location = new System.Drawing.Point(131, 167);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(380, 268);
            this.settingsPanel.TabIndex = 30;
            // 
            // proceedButton
            // 
            this.proceedButton.BackColor = System.Drawing.Color.Transparent;
            this.proceedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proceedButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceedButton.Location = new System.Drawing.Point(115, 123);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(143, 29);
            this.proceedButton.TabIndex = 2;
            this.proceedButton.TabStop = false;
            this.proceedButton.Text = "Calculate odds";
            this.proceedButton.UseVisualStyleBackColor = false;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // rightPerCentBox
            // 
            this.rightPerCentBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightPerCentBox.ForeColor = System.Drawing.Color.Black;
            this.rightPerCentBox.Location = new System.Drawing.Point(188, 91);
            this.rightPerCentBox.MaxLength = 2;
            this.rightPerCentBox.Name = "rightPerCentBox";
            this.rightPerCentBox.Size = new System.Drawing.Size(43, 26);
            this.rightPerCentBox.TabIndex = 1;
            this.rightPerCentBox.TabStop = false;
            this.rightPerCentBox.Text = "50";
            this.rightPerCentBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rightPerCentBox.TextChanged += new System.EventHandler(this.rightPerCentBox_TextChanged);
            this.rightPerCentBox.Enter += new System.EventHandler(this.rightPerCentBox_Enter);
            this.rightPerCentBox.Leave += new System.EventHandler(this.rightPerCentBox_Leave);
            // 
            // participant2OddsMinusButton
            // 
            this.participant2OddsMinusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.participant2OddsMinusButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.participant2OddsMinusButton.Location = new System.Drawing.Point(188, 66);
            this.participant2OddsMinusButton.Name = "participant2OddsMinusButton";
            this.participant2OddsMinusButton.Size = new System.Drawing.Size(22, 24);
            this.participant2OddsMinusButton.TabIndex = 27;
            this.participant2OddsMinusButton.TabStop = false;
            this.participant2OddsMinusButton.Text = "-";
            this.participant2OddsMinusButton.UseVisualStyleBackColor = true;
            this.participant2OddsMinusButton.Click += new System.EventHandler(this.participant2OddsMinusButton_Click);
            // 
            // breakpointBox
            // 
            this.breakpointBox.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.breakpointBox.Location = new System.Drawing.Point(217, 25);
            this.breakpointBox.MaxDropDownItems = 14;
            this.breakpointBox.Name = "breakpointBox";
            this.breakpointBox.Size = new System.Drawing.Size(49, 24);
            this.breakpointBox.TabIndex = 5;
            this.breakpointBox.TabStop = false;
            this.breakpointBox.Text = "1.87";
            // 
            // participant2OddsPlusButton
            // 
            this.participant2OddsPlusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.participant2OddsPlusButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.participant2OddsPlusButton.Location = new System.Drawing.Point(209, 66);
            this.participant2OddsPlusButton.Name = "participant2OddsPlusButton";
            this.participant2OddsPlusButton.Size = new System.Drawing.Size(22, 24);
            this.participant2OddsPlusButton.TabIndex = 26;
            this.participant2OddsPlusButton.TabStop = false;
            this.participant2OddsPlusButton.Text = "+";
            this.participant2OddsPlusButton.UseVisualStyleBackColor = true;
            this.participant2OddsPlusButton.Click += new System.EventHandler(this.participant2OddsPlusButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Transparent;
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(161, 158);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(49, 23);
            this.resetButton.TabIndex = 6;
            this.resetButton.TabStop = false;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // participant1OddsMinusButton
            // 
            this.participant1OddsMinusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.participant1OddsMinusButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.participant1OddsMinusButton.Location = new System.Drawing.Point(160, 66);
            this.participant1OddsMinusButton.Name = "participant1OddsMinusButton";
            this.participant1OddsMinusButton.Size = new System.Drawing.Size(22, 24);
            this.participant1OddsMinusButton.TabIndex = 25;
            this.participant1OddsMinusButton.TabStop = false;
            this.participant1OddsMinusButton.Text = "-";
            this.participant1OddsMinusButton.UseVisualStyleBackColor = true;
            this.participant1OddsMinusButton.Click += new System.EventHandler(this.participant1OddsMinusButton_Click);
            // 
            // startingOddsLabel
            // 
            this.startingOddsLabel.AutoSize = true;
            this.startingOddsLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.startingOddsLabel.Location = new System.Drawing.Point(107, 28);
            this.startingOddsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startingOddsLabel.Name = "startingOddsLabel";
            this.startingOddsLabel.Size = new System.Drawing.Size(105, 18);
            this.startingOddsLabel.TabIndex = 14;
            this.startingOddsLabel.Text = "Starting odds:";
            // 
            // participant1OddsPlusButton
            // 
            this.participant1OddsPlusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.participant1OddsPlusButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.participant1OddsPlusButton.Location = new System.Drawing.Point(139, 66);
            this.participant1OddsPlusButton.Name = "participant1OddsPlusButton";
            this.participant1OddsPlusButton.Size = new System.Drawing.Size(22, 24);
            this.participant1OddsPlusButton.TabIndex = 24;
            this.participant1OddsPlusButton.TabStop = false;
            this.participant1OddsPlusButton.Text = "+";
            this.participant1OddsPlusButton.UseVisualStyleBackColor = true;
            this.participant1OddsPlusButton.Click += new System.EventHandler(this.participant1OddsPlusButton_Click);
            // 
            // selectTeamComboBox
            // 
            this.selectTeamComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectTeamComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectTeamComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamComboBox.FormattingEnabled = true;
            this.selectTeamComboBox.Items.AddRange(new object[] {
            "Unibet"});
            this.selectTeamComboBox.Location = new System.Drawing.Point(159, 217);
            this.selectTeamComboBox.Name = "selectTeamComboBox";
            this.selectTeamComboBox.Size = new System.Drawing.Size(121, 26);
            this.selectTeamComboBox.TabIndex = 20;
            this.selectTeamComboBox.TabStop = false;
            this.selectTeamComboBox.SelectedIndexChanged += new System.EventHandler(this.selectTeamComboBox_SelectedIndexChanged);
            // 
            // percentageSymbolLabel2
            // 
            this.percentageSymbolLabel2.AutoSize = true;
            this.percentageSymbolLabel2.Font = new System.Drawing.Font("Arial", 12F);
            this.percentageSymbolLabel2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.percentageSymbolLabel2.Location = new System.Drawing.Point(236, 95);
            this.percentageSymbolLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.percentageSymbolLabel2.Name = "percentageSymbolLabel2";
            this.percentageSymbolLabel2.Size = new System.Drawing.Size(22, 18);
            this.percentageSymbolLabel2.TabIndex = 23;
            this.percentageSymbolLabel2.Text = "%";
            // 
            // selectThemeLabel
            // 
            this.selectThemeLabel.AutoSize = true;
            this.selectThemeLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.selectThemeLabel.Location = new System.Drawing.Point(94, 221);
            this.selectThemeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectThemeLabel.Name = "selectThemeLabel";
            this.selectThemeLabel.Size = new System.Drawing.Size(60, 18);
            this.selectThemeLabel.TabIndex = 21;
            this.selectThemeLabel.Text = "Theme:";
            // 
            // percentageSymbolLabel1
            // 
            this.percentageSymbolLabel1.AutoSize = true;
            this.percentageSymbolLabel1.Font = new System.Drawing.Font("Arial", 12F);
            this.percentageSymbolLabel1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.percentageSymbolLabel1.Location = new System.Drawing.Point(112, 94);
            this.percentageSymbolLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.percentageSymbolLabel1.Name = "percentageSymbolLabel1";
            this.percentageSymbolLabel1.Size = new System.Drawing.Size(22, 18);
            this.percentageSymbolLabel1.TabIndex = 22;
            this.percentageSymbolLabel1.Text = "%";
            // 
            // screenshotAreaPanel
            // 
            this.screenshotAreaPanel.Controls.Add(this.panel2);
            this.screenshotAreaPanel.Controls.Add(this.panel6);
            this.screenshotAreaPanel.Controls.Add(this.panel7);
            this.screenshotAreaPanel.Location = new System.Drawing.Point(3, 3);
            this.screenshotAreaPanel.Name = "screenshotAreaPanel";
            this.screenshotAreaPanel.Size = new System.Drawing.Size(635, 150);
            this.screenshotAreaPanel.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.oddsLeftParticipantPictureBox);
            this.panel2.Controls.Add(this.oddsRightParticipantPictureBox);
            this.panel2.Controls.Add(this.unibetRightOddsPanel);
            this.panel2.Controls.Add(this.unibetLeftOddsPanel);
            this.panel2.Controls.Add(this.lowerTeamNameDisplayBox);
            this.panel2.Controls.Add(this.upperTeamNameDisplayBox);
            this.panel2.Location = new System.Drawing.Point(96, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 59);
            this.panel2.TabIndex = 9;
            // 
            // oddsLeftParticipantPictureBox
            // 
            this.oddsLeftParticipantPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oddsLeftParticipantPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("oddsLeftParticipantPictureBox.Image")));
            this.oddsLeftParticipantPictureBox.Location = new System.Drawing.Point(17, 9);
            this.oddsLeftParticipantPictureBox.Name = "oddsLeftParticipantPictureBox";
            this.oddsLeftParticipantPictureBox.Size = new System.Drawing.Size(20, 18);
            this.oddsLeftParticipantPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.oddsLeftParticipantPictureBox.TabIndex = 24;
            this.oddsLeftParticipantPictureBox.TabStop = false;
            this.oddsLeftParticipantPictureBox.Click += new System.EventHandler(this.oddsLeftParticipantPictureBox_Click);
            // 
            // oddsRightParticipantPictureBox
            // 
            this.oddsRightParticipantPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oddsRightParticipantPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("oddsRightParticipantPictureBox.Image")));
            this.oddsRightParticipantPictureBox.Location = new System.Drawing.Point(17, 30);
            this.oddsRightParticipantPictureBox.Name = "oddsRightParticipantPictureBox";
            this.oddsRightParticipantPictureBox.Size = new System.Drawing.Size(20, 18);
            this.oddsRightParticipantPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.oddsRightParticipantPictureBox.TabIndex = 23;
            this.oddsRightParticipantPictureBox.TabStop = false;
            this.oddsRightParticipantPictureBox.Click += new System.EventHandler(this.oddsRightParticipantPictureBox_Click);
            // 
            // unibetRightOddsPanel
            // 
            this.unibetRightOddsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(123)))), ((int)(((byte)(69)))));
            this.unibetRightOddsPanel.Controls.Add(this.rightOddsLabel);
            this.unibetRightOddsPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unibetRightOddsPanel.Location = new System.Drawing.Point(428, 13);
            this.unibetRightOddsPanel.Name = "unibetRightOddsPanel";
            this.unibetRightOddsPanel.Size = new System.Drawing.Size(61, 33);
            this.unibetRightOddsPanel.TabIndex = 10;
            this.unibetRightOddsPanel.MouseEnter += new System.EventHandler(this.unibetRightOddsPanel_MouseEnter);
            this.unibetRightOddsPanel.MouseLeave += new System.EventHandler(this.unibetRightOddsPanel_MouseLeave);
            // 
            // rightOddsLabel
            // 
            this.rightOddsLabel.AutoSize = true;
            this.rightOddsLabel.BackColor = System.Drawing.Color.Transparent;
            this.rightOddsLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightOddsLabel.ForeColor = System.Drawing.Color.White;
            this.rightOddsLabel.Location = new System.Drawing.Point(11, 7);
            this.rightOddsLabel.Name = "rightOddsLabel";
            this.rightOddsLabel.Size = new System.Drawing.Size(40, 19);
            this.rightOddsLabel.TabIndex = 4;
            this.rightOddsLabel.Text = "1.87";
            this.rightOddsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rightOddsLabel.MouseEnter += new System.EventHandler(this.rightOddsLabel_MouseEnter);
            this.rightOddsLabel.MouseLeave += new System.EventHandler(this.rightOddsLabel_MouseLeave);
            // 
            // unibetLeftOddsPanel
            // 
            this.unibetLeftOddsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(123)))), ((int)(((byte)(69)))));
            this.unibetLeftOddsPanel.Controls.Add(this.leftOddsLabel);
            this.unibetLeftOddsPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unibetLeftOddsPanel.Location = new System.Drawing.Point(361, 13);
            this.unibetLeftOddsPanel.Name = "unibetLeftOddsPanel";
            this.unibetLeftOddsPanel.Size = new System.Drawing.Size(61, 33);
            this.unibetLeftOddsPanel.TabIndex = 9;
            this.unibetLeftOddsPanel.MouseEnter += new System.EventHandler(this.unibetLeftOddsPanel_MouseEnter);
            this.unibetLeftOddsPanel.MouseLeave += new System.EventHandler(this.unibetLeftOddsPanel_MouseLeave);
            // 
            // leftOddsLabel
            // 
            this.leftOddsLabel.AutoSize = true;
            this.leftOddsLabel.BackColor = System.Drawing.Color.Transparent;
            this.leftOddsLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftOddsLabel.ForeColor = System.Drawing.Color.White;
            this.leftOddsLabel.Location = new System.Drawing.Point(11, 7);
            this.leftOddsLabel.Name = "leftOddsLabel";
            this.leftOddsLabel.Size = new System.Drawing.Size(40, 19);
            this.leftOddsLabel.TabIndex = 3;
            this.leftOddsLabel.Text = "1.87";
            this.leftOddsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.leftOddsLabel.MouseEnter += new System.EventHandler(this.leftOddsLabel_MouseEnter);
            this.leftOddsLabel.MouseLeave += new System.EventHandler(this.leftOddsLabel_MouseLeave);
            // 
            // lowerTeamNameDisplayBox
            // 
            this.lowerTeamNameDisplayBox.BackColor = System.Drawing.Color.White;
            this.lowerTeamNameDisplayBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lowerTeamNameDisplayBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lowerTeamNameDisplayBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowerTeamNameDisplayBox.ForeColor = System.Drawing.Color.Black;
            this.lowerTeamNameDisplayBox.Location = new System.Drawing.Point(42, 30);
            this.lowerTeamNameDisplayBox.MaxLength = 26;
            this.lowerTeamNameDisplayBox.Multiline = true;
            this.lowerTeamNameDisplayBox.Name = "lowerTeamNameDisplayBox";
            this.lowerTeamNameDisplayBox.Size = new System.Drawing.Size(209, 20);
            this.lowerTeamNameDisplayBox.TabIndex = 8;
            this.lowerTeamNameDisplayBox.TabStop = false;
            this.lowerTeamNameDisplayBox.Text = "NiP Gaming";
            // 
            // upperTeamNameDisplayBox
            // 
            this.upperTeamNameDisplayBox.BackColor = System.Drawing.Color.White;
            this.upperTeamNameDisplayBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.upperTeamNameDisplayBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.upperTeamNameDisplayBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upperTeamNameDisplayBox.ForeColor = System.Drawing.Color.Black;
            this.upperTeamNameDisplayBox.Location = new System.Drawing.Point(42, 9);
            this.upperTeamNameDisplayBox.MaxLength = 26;
            this.upperTeamNameDisplayBox.Multiline = true;
            this.upperTeamNameDisplayBox.Name = "upperTeamNameDisplayBox";
            this.upperTeamNameDisplayBox.Size = new System.Drawing.Size(209, 20);
            this.upperTeamNameDisplayBox.TabIndex = 7;
            this.upperTeamNameDisplayBox.TabStop = false;
            this.upperTeamNameDisplayBox.Text = "ENCE";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.matchTimeTextBox);
            this.panel6.Location = new System.Drawing.Point(34, 59);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(61, 59);
            this.panel6.TabIndex = 28;
            // 
            // matchTimeTextBox
            // 
            this.matchTimeTextBox.BackColor = System.Drawing.Color.White;
            this.matchTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matchTimeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.matchTimeTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchTimeTextBox.ForeColor = System.Drawing.Color.Black;
            this.matchTimeTextBox.Location = new System.Drawing.Point(3, 22);
            this.matchTimeTextBox.MaxLength = 26;
            this.matchTimeTextBox.Name = "matchTimeTextBox";
            this.matchTimeTextBox.Size = new System.Drawing.Size(55, 15);
            this.matchTimeTextBox.TabIndex = 29;
            this.matchTimeTextBox.TabStop = false;
            this.matchTimeTextBox.Text = "20:00";
            this.matchTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.panel7.Controls.Add(this.matchDateTextBox);
            this.panel7.Location = new System.Drawing.Point(34, 30);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(563, 89);
            this.panel7.TabIndex = 29;
            // 
            // matchDateTextBox
            // 
            this.matchDateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.matchDateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matchDateTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchDateTextBox.Location = new System.Drawing.Point(13, 8);
            this.matchDateTextBox.Name = "matchDateTextBox";
            this.matchDateTextBox.Size = new System.Drawing.Size(538, 15);
            this.matchDateTextBox.TabIndex = 30;
            this.matchDateTextBox.TabStop = false;
            this.matchDateTextBox.Text = "Today";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 491);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Odds Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.screenshotAreaPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oddsLeftParticipantPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oddsRightParticipantPictureBox)).EndInit();
            this.unibetRightOddsPanel.ResumeLayout(false);
            this.unibetRightOddsPanel.PerformLayout();
            this.unibetLeftOddsPanel.ResumeLayout(false);
            this.unibetLeftOddsPanel.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox leftPerCentBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox rightPerCentBox;
        private System.Windows.Forms.Button proceedButton;
        private System.Windows.Forms.Label leftOddsLabel;
        private System.Windows.Forms.ComboBox breakpointBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox upperTeamNameDisplayBox;
        private System.Windows.Forms.TextBox lowerTeamNameDisplayBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label startingOddsLabel;
        private System.Windows.Forms.ComboBox selectTeamComboBox;
        private System.Windows.Forms.Label selectThemeLabel;
        private System.Windows.Forms.Panel unibetLeftOddsPanel;
        private System.Windows.Forms.Label rightOddsLabel;
        private System.Windows.Forms.Panel unibetRightOddsPanel;
        private System.Windows.Forms.PictureBox oddsRightParticipantPictureBox;
        private System.Windows.Forms.PictureBox oddsLeftParticipantPictureBox;
        private System.Windows.Forms.Label percentageSymbolLabel2;
        private System.Windows.Forms.Label percentageSymbolLabel1;
        private System.Windows.Forms.Button participant1OddsMinusButton;
        private System.Windows.Forms.Button participant1OddsPlusButton;
        private System.Windows.Forms.Button participant2OddsMinusButton;
        private System.Windows.Forms.Button participant2OddsPlusButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox matchTimeTextBox;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox matchDateTextBox;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Panel screenshotAreaPanel;
        private System.Windows.Forms.CheckBox showSettingsCheckBox;
    }
}

