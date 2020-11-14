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
            this.SuspendLayout();
            // 
            // labelFirstPlayer
            // 
            this.labelFirstPlayer.AutoSize = true;
            this.labelFirstPlayer.Location = new System.Drawing.Point(12, 21);
            this.labelFirstPlayer.Name = "labelFirstPlayer";
            this.labelFirstPlayer.Size = new System.Drawing.Size(92, 13);
            this.labelFirstPlayer.TabIndex = 0;
            this.labelFirstPlayer.Text = "First Player Name:";
            // 
            // labelSecondPlayer
            // 
            this.labelSecondPlayer.AutoSize = true;
            this.labelSecondPlayer.Location = new System.Drawing.Point(12, 56);
            this.labelSecondPlayer.Name = "labelSecondPlayer";
            this.labelSecondPlayer.Size = new System.Drawing.Size(110, 13);
            this.labelSecondPlayer.TabIndex = 1;
            this.labelSecondPlayer.Text = "Second Player Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Board Size:";
            // 
            // textBoxFirstPlayer
            // 
            this.textBoxFirstPlayer.Location = new System.Drawing.Point(128, 18);
            this.textBoxFirstPlayer.Name = "textBoxFirstPlayer";
            this.textBoxFirstPlayer.Size = new System.Drawing.Size(120, 20);
            this.textBoxFirstPlayer.TabIndex = 3;
            // 
            // textBoxSecondPlayer
            // 
            this.textBoxSecondPlayer.BackColor = System.Drawing.Color.LightGray;
            this.textBoxSecondPlayer.Enabled = false;
            this.textBoxSecondPlayer.Location = new System.Drawing.Point(128, 53);
            this.textBoxSecondPlayer.Name = "textBoxSecondPlayer";
            this.textBoxSecondPlayer.Size = new System.Drawing.Size(120, 20);
            this.textBoxSecondPlayer.TabIndex = 4;
            // 
            // buttonAgainstFriend
            // 
            this.buttonAgainstFriend.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAgainstFriend.Location = new System.Drawing.Point(254, 53);
            this.buttonAgainstFriend.Name = "buttonAgainstFriend";
            this.buttonAgainstFriend.Size = new System.Drawing.Size(107, 20);
            this.buttonAgainstFriend.TabIndex = 5;
            this.buttonAgainstFriend.Text = "Against a Friend";
            this.buttonAgainstFriend.UseVisualStyleBackColor = true;
            this.buttonAgainstFriend.Click += new System.EventHandler(this.buttonAgainstPlayer_Click_1);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonStart.Location = new System.Drawing.Point(277, 149);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(84, 34);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Start!";
            this.buttonStart.UseVisualStyleBackColor = false;
            // 
            // buttonBoardSize
            // 
            this.buttonBoardSize.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonBoardSize.Location = new System.Drawing.Point(15, 120);
            this.buttonBoardSize.Name = "buttonBoardSize";
            this.buttonBoardSize.Size = new System.Drawing.Size(110, 63);
            this.buttonBoardSize.TabIndex = 7;
            this.buttonBoardSize.Text = "4 x 4";
            this.buttonBoardSize.UseVisualStyleBackColor = false;
            this.buttonBoardSize.Click += new System.EventHandler(this.buttonBoardSize_Click);
            // 
            // FormSettings
            // 
            this.AcceptButton = this.buttonStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 198);
            this.Controls.Add(this.buttonBoardSize);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonAgainstFriend);
            this.Controls.Add(this.textBoxSecondPlayer);
            this.Controls.Add(this.textBoxFirstPlayer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelSecondPlayer);
            this.Controls.Add(this.labelFirstPlayer);
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
    }
}