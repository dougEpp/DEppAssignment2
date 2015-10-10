namespace DEppAssignment2
{
    partial class TicTacToe
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
            this.btnFillRandom = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblCurrentPlayer = new System.Windows.Forms.Label();
            this.lblXOrO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFillRandom
            // 
            this.btnFillRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFillRandom.Location = new System.Drawing.Point(864, 81);
            this.btnFillRandom.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnFillRandom.Name = "btnFillRandom";
            this.btnFillRandom.Size = new System.Drawing.Size(245, 69);
            this.btnFillRandom.TabIndex = 0;
            this.btnFillRandom.Text = "Computer";
            this.btnFillRandom.UseVisualStyleBackColor = true;
            this.btnFillRandom.Click += new System.EventHandler(this.btnFillRandom_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReset.Location = new System.Drawing.Point(864, 234);
            this.btnReset.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(245, 69);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblCurrentPlayer
            // 
            this.lblCurrentPlayer.AutoSize = true;
            this.lblCurrentPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCurrentPlayer.Location = new System.Drawing.Point(858, 367);
            this.lblCurrentPlayer.Name = "lblCurrentPlayer";
            this.lblCurrentPlayer.Size = new System.Drawing.Size(276, 46);
            this.lblCurrentPlayer.TabIndex = 2;
            this.lblCurrentPlayer.Text = "Current Player";
            // 
            // lblXOrO
            // 
            this.lblXOrO.AutoSize = true;
            this.lblXOrO.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblXOrO.Location = new System.Drawing.Point(950, 446);
            this.lblXOrO.Name = "lblXOrO";
            this.lblXOrO.Size = new System.Drawing.Size(63, 63);
            this.lblXOrO.TabIndex = 3;
            this.lblXOrO.Text = "X";
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1667, 1032);
            this.Controls.Add(this.lblXOrO);
            this.Controls.Add(this.lblCurrentPlayer);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnFillRandom);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "TicTacToe";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFillRandom;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblCurrentPlayer;
        private System.Windows.Forms.Label lblXOrO;




    }
}

