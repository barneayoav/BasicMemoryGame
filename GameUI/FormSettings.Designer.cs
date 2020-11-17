namespace GameUI
{
    public partial class FormSettings
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
            this.labelFirstPlayer = new System.Windows.Forms.Label();
            this.labelSecondPlayer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFirstPlayer = new System.Windows.Forms.TextBox();
            this.textBoxSecondPlayer = new System.Windows.Forms.TextBox();
            this.buttonAgainstFriend = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonBoardSize = new System.Windows.Forms.Button();
            this.buttonComputerDifficulty = new System.Windows.Forms.Button();
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFirstPlayer
            // 
            this.labelFirstPlayer.AutoSize = true;
            this.labelFirstPlayer.Location = new System.Drawing.Point(24, 40);
            this.labelFirstPlayer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelFirstPlayer.Name = "labelFirstPlayer";
            this.labelFirstPlayer.Size = new System.Drawing.Size(189, 25);
            this.labelFirstPlayer.TabIndex = 0;
            this.labelFirstPlayer.Text = "First Player Name:";
            // 
            // labelSecondPlayer
            // 
            this.labelSecondPlayer.AutoSize = true;
            this.labelSecondPlayer.Location = new System.Drawing.Point(24, 108);
            this.labelSecondPlayer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSecondPlayer.Name = "labelSecondPlayer";
            this.labelSecondPlayer.Size = new System.Drawing.Size(220, 25);
            this.labelSecondPlayer.TabIndex = 1;
            this.labelSecondPlayer.Text = "Second Player Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 327);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Board Size:";
            // 
            // textBoxFirstPlayer
            // 
            this.textBoxFirstPlayer.Location = new System.Drawing.Point(256, 40);
            this.textBoxFirstPlayer.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxFirstPlayer.Name = "textBoxFirstPlayer";
            this.textBoxFirstPlayer.Size = new System.Drawing.Size(236, 31);
            this.textBoxFirstPlayer.TabIndex = 3;
            // 
            // textBoxSecondPlayer
            // 
            this.textBoxSecondPlayer.BackColor = System.Drawing.Color.LightGray;
            this.textBoxSecondPlayer.Enabled = false;
            this.textBoxSecondPlayer.Location = new System.Drawing.Point(256, 102);
            this.textBoxSecondPlayer.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxSecondPlayer.Name = "textBoxSecondPlayer";
            this.textBoxSecondPlayer.Size = new System.Drawing.Size(236, 31);
            this.textBoxSecondPlayer.TabIndex = 4;
            this.textBoxSecondPlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonAgainstFriend
            // 
            this.buttonAgainstFriend.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAgainstFriend.Location = new System.Drawing.Point(532, 92);
            this.buttonAgainstFriend.Margin = new System.Windows.Forms.Padding(6);
            this.buttonAgainstFriend.Name = "buttonAgainstFriend";
            this.buttonAgainstFriend.Size = new System.Drawing.Size(223, 56);
            this.buttonAgainstFriend.TabIndex = 5;
            this.buttonAgainstFriend.Text = "Against a Friend";
            this.buttonAgainstFriend.UseVisualStyleBackColor = true;
            this.buttonAgainstFriend.Click += new System.EventHandler(this.buttonAgainstPlayer_Click_1);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonStart.Location = new System.Drawing.Point(532, 183);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(6);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(223, 197);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Start!";
            this.buttonStart.UseVisualStyleBackColor = false;
            // 
            // buttonBoardSize
            // 
            this.buttonBoardSize.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonBoardSize.Location = new System.Drawing.Point(256, 298);
            this.buttonBoardSize.Margin = new System.Windows.Forms.Padding(6);
            this.buttonBoardSize.Name = "buttonBoardSize";
            this.buttonBoardSize.Size = new System.Drawing.Size(236, 82);
            this.buttonBoardSize.TabIndex = 7;
            this.buttonBoardSize.Text = "4 x 4";
            this.buttonBoardSize.UseVisualStyleBackColor = false;
            this.buttonBoardSize.Click += new System.EventHandler(this.buttonBoardSize_Click);
            // 
            // buttonComputerDifficulty
            // 
            this.buttonComputerDifficulty.BackColor = System.Drawing.Color.Gold;
            this.buttonComputerDifficulty.Location = new System.Drawing.Point(256, 183);
            this.buttonComputerDifficulty.Margin = new System.Windows.Forms.Padding(6);
            this.buttonComputerDifficulty.Name = "buttonComputerDifficulty";
            this.buttonComputerDifficulty.Size = new System.Drawing.Size(236, 77);
            this.buttonComputerDifficulty.TabIndex = 8;
            this.buttonComputerDifficulty.Text = "Easy";
            this.buttonComputerDifficulty.UseVisualStyleBackColor = false;
            this.buttonComputerDifficulty.Click += new System.EventHandler(this.buttonComputerDifficulty_Click);
            // 
            // labelDifficulty
            // 
            this.labelDifficulty.AutoSize = true;
            this.labelDifficulty.Location = new System.Drawing.Point(24, 209);
            this.labelDifficulty.Name = "labelDifficulty";
            this.labelDifficulty.Size = new System.Drawing.Size(100, 25);
            this.labelDifficulty.TabIndex = 9;
            this.labelDifficulty.Text = "Difficulty:";
            // 
            // FormSettings
            // 
            this.AcceptButton = this.buttonStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 413);
            this.Controls.Add(this.labelDifficulty);
            this.Controls.Add(this.buttonComputerDifficulty);
            this.Controls.Add(this.buttonBoardSize);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonAgainstFriend);
            this.Controls.Add(this.textBoxSecondPlayer);
            this.Controls.Add(this.textBoxFirstPlayer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelSecondPlayer);
            this.Controls.Add(this.labelFirstPlayer);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Game - Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstPlayer;
        private System.Windows.Forms.Label labelSecondPlayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFirstPlayer;
        private System.Windows.Forms.TextBox textBoxSecondPlayer;
        private System.Windows.Forms.Button buttonAgainstFriend;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonBoardSize;
        private System.Windows.Forms.Button buttonComputerDifficulty;
        private System.Windows.Forms.Label labelDifficulty;
    }
}