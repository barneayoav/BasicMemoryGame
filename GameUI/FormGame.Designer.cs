using System.Drawing;

namespace GameUI
{
    public partial class FormGame
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
            this.MaximizeBox = false;
            this.labelCurrentPlayer = new System.Windows.Forms.Label();
            this.labelFirstPlayerScore = new System.Windows.Forms.Label();
            this.labelSecondPlayerScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCurrentPlayer
            // 
            this.labelCurrentPlayer.AutoSize = true;
            this.labelCurrentPlayer.Location = new System.Drawing.Point(38, 390);
            this.labelCurrentPlayer.Name = "labelCurrentPlayer";
            this.labelCurrentPlayer.Size = new System.Drawing.Size(79, 13);
            this.labelCurrentPlayer.Left = k_MarginBorders;
            this.labelCurrentPlayer.ForeColor = Color.Black;
            this.labelCurrentPlayer.BackColor = r_FirstPlayerColor;
            this.labelCurrentPlayer.Top = m_SlotButtons[0, m_SlotButtons.GetLength(1) - 1].Bottom + k_MarginBorders;
            this.labelFirstPlayerScore.TabIndex = 0;
            // 
            // labelFirstPlayerScore
            // 
            this.labelFirstPlayerScore.AutoSize = true;
            this.labelFirstPlayerScore.Location = new System.Drawing.Point(38, 412);
            this.labelFirstPlayerScore.Name = "labelFirstPlayerScore";
            this.labelFirstPlayerScore.Size = new System.Drawing.Size(35, 13);
            this.labelFirstPlayerScore.TabIndex = 1;
            this.labelFirstPlayerScore.ForeColor = Color.Black;
            this.labelFirstPlayerScore.BackColor = r_FirstPlayerColor;
            this.labelFirstPlayerScore.Left = k_MarginBorders;
            this.labelFirstPlayerScore.Top = this.labelCurrentPlayer.Bottom + k_MarginBorders;
            // 
            // labelSecondPlayerScore
            // 
            this.labelSecondPlayerScore.AutoSize = true;
            this.labelSecondPlayerScore.Location = new System.Drawing.Point(38, 433);
            this.labelSecondPlayerScore.Name = "labelSecondPlayerScore";
            this.labelSecondPlayerScore.Size = new System.Drawing.Size(35, 13);
            this.labelSecondPlayerScore.TabIndex = 2;
            this.labelSecondPlayerScore.ForeColor = Color.Black;
            this.labelSecondPlayerScore.BackColor = r_SecondPlayerColor;
            this.labelSecondPlayerScore.Left = k_MarginBorders;
            this.labelSecondPlayerScore.Top = this.labelFirstPlayerScore.Bottom + k_MarginBorders;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new Size(m_SlotButtons[m_SlotButtons.GetLength(0) - 1, m_SlotButtons.GetLength(1) - 1].Right + k_MarginBorders, this.labelSecondPlayerScore.Bottom + k_MarginBorders);
            this.Controls.Add(this.labelSecondPlayerScore);
            this.Controls.Add(this.labelFirstPlayerScore);
            this.Controls.Add(this.labelCurrentPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrentPlayer;
        private System.Windows.Forms.Label labelFirstPlayerScore;
        private System.Windows.Forms.Label labelSecondPlayerScore;
    }
}