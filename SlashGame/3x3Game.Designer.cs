namespace SlashGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            titleLabel = new Label();
            gamePanel = new Panel();
            b1Button = new Button();
            c1Button = new Button();
            c2Button = new Button();
            c3Button = new Button();
            b3Button = new Button();
            b2Button = new Button();
            a3Button = new Button();
            a2Button = new Button();
            a1Button = new Button();
            slashGroupBox = new GroupBox();
            a3SlashLabel = new Label();
            c2SlashLabel = new Label();
            b3SlashLabel = new Label();
            c3SlashLabel = new Label();
            b2SlashLabel = new Label();
            c1SlashLabel = new Label();
            b1SlashLabel = new Label();
            a2SlashLabel = new Label();
            a1SlashLabel = new Label();
            startButton = new Button();
            exitButton = new Button();
            instructionsLabel = new Label();
            scoreLabel = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            timeProgressBar = new ProgressBar();
            gamePanel.SuspendLayout();
            slashGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(72, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(155, 29);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Slash Dodger";
            // 
            // gamePanel
            // 
            gamePanel.BorderStyle = BorderStyle.FixedSingle;
            gamePanel.Controls.Add(b1Button);
            gamePanel.Controls.Add(c1Button);
            gamePanel.Controls.Add(c2Button);
            gamePanel.Controls.Add(c3Button);
            gamePanel.Controls.Add(b3Button);
            gamePanel.Controls.Add(b2Button);
            gamePanel.Controls.Add(a3Button);
            gamePanel.Controls.Add(a2Button);
            gamePanel.Controls.Add(a1Button);
            gamePanel.Location = new Point(12, 189);
            gamePanel.Name = "gamePanel";
            gamePanel.Size = new Size(270, 270);
            gamePanel.TabIndex = 1;
            // 
            // b1Button
            // 
            b1Button.BackColor = Color.White;
            b1Button.Enabled = false;
            b1Button.Location = new Point(3, 93);
            b1Button.Name = "b1Button";
            b1Button.Size = new Size(84, 84);
            b1Button.TabIndex = 3;
            b1Button.TabStop = false;
            b1Button.UseVisualStyleBackColor = false;
            b1Button.Click += b1Button_Click;
            // 
            // c1Button
            // 
            c1Button.BackColor = Color.White;
            c1Button.Enabled = false;
            c1Button.Location = new Point(3, 183);
            c1Button.Name = "c1Button";
            c1Button.Size = new Size(84, 84);
            c1Button.TabIndex = 6;
            c1Button.TabStop = false;
            c1Button.UseVisualStyleBackColor = false;
            c1Button.Click += c1Button_Click;
            // 
            // c2Button
            // 
            c2Button.BackColor = Color.White;
            c2Button.Enabled = false;
            c2Button.Location = new Point(93, 183);
            c2Button.Name = "c2Button";
            c2Button.Size = new Size(84, 84);
            c2Button.TabIndex = 7;
            c2Button.TabStop = false;
            c2Button.UseVisualStyleBackColor = false;
            c2Button.Click += c2Button_Click;
            // 
            // c3Button
            // 
            c3Button.BackColor = Color.White;
            c3Button.Enabled = false;
            c3Button.Location = new Point(183, 183);
            c3Button.Name = "c3Button";
            c3Button.Size = new Size(84, 84);
            c3Button.TabIndex = 8;
            c3Button.TabStop = false;
            c3Button.UseVisualStyleBackColor = false;
            c3Button.Click += c3Button_Click;
            // 
            // b3Button
            // 
            b3Button.BackColor = Color.White;
            b3Button.Enabled = false;
            b3Button.Location = new Point(183, 93);
            b3Button.Name = "b3Button";
            b3Button.Size = new Size(84, 84);
            b3Button.TabIndex = 5;
            b3Button.TabStop = false;
            b3Button.UseVisualStyleBackColor = false;
            b3Button.Click += b3Button_Click;
            // 
            // b2Button
            // 
            b2Button.BackColor = Color.White;
            b2Button.Enabled = false;
            b2Button.Location = new Point(93, 93);
            b2Button.Name = "b2Button";
            b2Button.Size = new Size(84, 84);
            b2Button.TabIndex = 4;
            b2Button.TabStop = false;
            b2Button.UseVisualStyleBackColor = false;
            b2Button.Click += b2Button_Click;
            // 
            // a3Button
            // 
            a3Button.BackColor = Color.White;
            a3Button.Enabled = false;
            a3Button.Location = new Point(183, 3);
            a3Button.Name = "a3Button";
            a3Button.Size = new Size(84, 84);
            a3Button.TabIndex = 2;
            a3Button.TabStop = false;
            a3Button.UseVisualStyleBackColor = false;
            a3Button.Click += a3Button_Click;
            // 
            // a2Button
            // 
            a2Button.BackColor = Color.White;
            a2Button.Enabled = false;
            a2Button.Location = new Point(93, 3);
            a2Button.Name = "a2Button";
            a2Button.Size = new Size(84, 84);
            a2Button.TabIndex = 1;
            a2Button.TabStop = false;
            a2Button.UseVisualStyleBackColor = false;
            a2Button.Click += a2Button_Click;
            // 
            // a1Button
            // 
            a1Button.BackColor = Color.White;
            a1Button.Enabled = false;
            a1Button.Location = new Point(3, 3);
            a1Button.Name = "a1Button";
            a1Button.Size = new Size(84, 84);
            a1Button.TabIndex = 0;
            a1Button.TabStop = false;
            a1Button.UseVisualStyleBackColor = false;
            a1Button.Click += a1Button_Click;
            // 
            // slashGroupBox
            // 
            slashGroupBox.Controls.Add(a3SlashLabel);
            slashGroupBox.Controls.Add(c2SlashLabel);
            slashGroupBox.Controls.Add(b3SlashLabel);
            slashGroupBox.Controls.Add(c3SlashLabel);
            slashGroupBox.Controls.Add(b2SlashLabel);
            slashGroupBox.Controls.Add(c1SlashLabel);
            slashGroupBox.Controls.Add(b1SlashLabel);
            slashGroupBox.Controls.Add(a2SlashLabel);
            slashGroupBox.Controls.Add(a1SlashLabel);
            slashGroupBox.Location = new Point(140, 41);
            slashGroupBox.Name = "slashGroupBox";
            slashGroupBox.Size = new Size(140, 140);
            slashGroupBox.TabIndex = 2;
            slashGroupBox.TabStop = false;
            slashGroupBox.Text = "I'm Slashing Here...";
            // 
            // a3SlashLabel
            // 
            a3SlashLabel.BackColor = Color.White;
            a3SlashLabel.BorderStyle = BorderStyle.FixedSingle;
            a3SlashLabel.Location = new Point(94, 19);
            a3SlashLabel.Name = "a3SlashLabel";
            a3SlashLabel.Size = new Size(35, 35);
            a3SlashLabel.TabIndex = 12;
            // 
            // c2SlashLabel
            // 
            c2SlashLabel.BackColor = Color.White;
            c2SlashLabel.BorderStyle = BorderStyle.FixedSingle;
            c2SlashLabel.Location = new Point(53, 97);
            c2SlashLabel.Name = "c2SlashLabel";
            c2SlashLabel.Size = new Size(35, 35);
            c2SlashLabel.TabIndex = 11;
            // 
            // b3SlashLabel
            // 
            b3SlashLabel.BackColor = Color.White;
            b3SlashLabel.BorderStyle = BorderStyle.FixedSingle;
            b3SlashLabel.Location = new Point(94, 58);
            b3SlashLabel.Name = "b3SlashLabel";
            b3SlashLabel.Size = new Size(35, 35);
            b3SlashLabel.TabIndex = 10;
            // 
            // c3SlashLabel
            // 
            c3SlashLabel.BackColor = Color.White;
            c3SlashLabel.BorderStyle = BorderStyle.FixedSingle;
            c3SlashLabel.Location = new Point(94, 97);
            c3SlashLabel.Name = "c3SlashLabel";
            c3SlashLabel.Size = new Size(35, 35);
            c3SlashLabel.TabIndex = 9;
            // 
            // b2SlashLabel
            // 
            b2SlashLabel.BackColor = Color.White;
            b2SlashLabel.BorderStyle = BorderStyle.FixedSingle;
            b2SlashLabel.Location = new Point(53, 58);
            b2SlashLabel.Name = "b2SlashLabel";
            b2SlashLabel.Size = new Size(35, 35);
            b2SlashLabel.TabIndex = 6;
            // 
            // c1SlashLabel
            // 
            c1SlashLabel.BackColor = Color.White;
            c1SlashLabel.BorderStyle = BorderStyle.FixedSingle;
            c1SlashLabel.Location = new Point(12, 97);
            c1SlashLabel.Name = "c1SlashLabel";
            c1SlashLabel.Size = new Size(35, 35);
            c1SlashLabel.TabIndex = 5;
            // 
            // b1SlashLabel
            // 
            b1SlashLabel.BackColor = Color.White;
            b1SlashLabel.BorderStyle = BorderStyle.FixedSingle;
            b1SlashLabel.Location = new Point(12, 58);
            b1SlashLabel.Name = "b1SlashLabel";
            b1SlashLabel.Size = new Size(35, 35);
            b1SlashLabel.TabIndex = 4;
            // 
            // a2SlashLabel
            // 
            a2SlashLabel.BackColor = Color.White;
            a2SlashLabel.BorderStyle = BorderStyle.FixedSingle;
            a2SlashLabel.Location = new Point(53, 19);
            a2SlashLabel.Name = "a2SlashLabel";
            a2SlashLabel.Size = new Size(35, 35);
            a2SlashLabel.TabIndex = 3;
            // 
            // a1SlashLabel
            // 
            a1SlashLabel.BackColor = Color.White;
            a1SlashLabel.BorderStyle = BorderStyle.FixedSingle;
            a1SlashLabel.Location = new Point(12, 19);
            a1SlashLabel.Name = "a1SlashLabel";
            a1SlashLabel.Size = new Size(35, 35);
            a1SlashLabel.TabIndex = 0;
            // 
            // startButton
            // 
            startButton.Location = new Point(40, 534);
            startButton.Name = "startButton";
            startButton.Size = new Size(100, 39);
            startButton.TabIndex = 3;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(161, 534);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(100, 39);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // instructionsLabel
            // 
            instructionsLabel.Location = new Point(16, 41);
            instructionsLabel.Name = "instructionsLabel";
            instructionsLabel.Size = new Size(118, 132);
            instructionsLabel.TabIndex = 5;
            instructionsLabel.Text = "Just don't click on squares that are black in the image on the right. And don't run out of time or I slash you. Simple as that.";
            instructionsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            scoreLabel.Location = new Point(100, 468);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(96, 15);
            scoreLabel.TabIndex = 6;
            scoreLabel.Text = "Your score: ####";
            // 
            // gameTimer
            // 
            gameTimer.Interval = 10;
            // 
            // timeProgressBar
            // 
            timeProgressBar.ForeColor = Color.ForestGreen;
            timeProgressBar.Location = new Point(17, 490);
            timeProgressBar.Name = "timeProgressBar";
            timeProgressBar.Size = new Size(264, 38);
            timeProgressBar.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(299, 587);
            Controls.Add(timeProgressBar);
            Controls.Add(scoreLabel);
            Controls.Add(instructionsLabel);
            Controls.Add(exitButton);
            Controls.Add(startButton);
            Controls.Add(slashGroupBox);
            Controls.Add(gamePanel);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Slash Dodger";
            Load += Form1_Load;
            gamePanel.ResumeLayout(false);
            slashGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Panel gamePanel;
        private Button a1Button;
        private Button a3Button;
        private Button a2Button;
        private Button b1Button;
        private Button c1Button;
        private Button c2Button;
        private Button c3Button;
        private Button b3Button;
        private Button b2Button;
        private GroupBox slashGroupBox;
        private Label a1SlashLabel;
        private Label a3SlashLabel;
        private Label c2SlashLabel;
        private Label b3SlashLabel;
        private Label c3SlashLabel;
        private Label b2SlashLabel;
        private Label c1SlashLabel;
        private Label b1SlashLabel;
        private Label a2SlashLabel;
        private Button startButton;
        private Button exitButton;
        private Label instructionsLabel;
        private Label scoreLabel;
        private System.Windows.Forms.Timer gameTimer;
        private ProgressBar timeProgressBar;
    }
}