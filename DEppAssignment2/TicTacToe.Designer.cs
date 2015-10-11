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
            this.lblX = new System.Windows.Forms.Label();
            this.lblO = new System.Windows.Forms.Label();
            this.lblXScore = new System.Windows.Forms.Label();
            this.lblOScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFillRandom
            // 
            this.btnFillRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFillRandom.Location = new System.Drawing.Point(43, 578);
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
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblX.Location = new System.Drawing.Point(858, 43);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(47, 46);
            this.lblX.TabIndex = 4;
            this.lblX.Text = "X";
            // 
            // lblO
            // 
            this.lblO.AutoSize = true;
            this.lblO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblO.Location = new System.Drawing.Point(1058, 43);
            this.lblO.Name = "lblO";
            this.lblO.Size = new System.Drawing.Size(51, 46);
            this.lblO.TabIndex = 5;
            this.lblO.Text = "O";
            // 
            // lblXScore
            // 
            this.lblXScore.AutoSize = true;
            this.lblXScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblXScore.Location = new System.Drawing.Point(862, 109);
            this.lblXScore.Name = "lblXScore";
            this.lblXScore.Size = new System.Drawing.Size(42, 46);
            this.lblXScore.TabIndex = 6;
            this.lblXScore.Text = "0";
            // 
            // lblOScore
            // 
            this.lblOScore.AutoSize = true;
            this.lblOScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblOScore.Location = new System.Drawing.Point(1060, 109);
            this.lblOScore.Name = "lblOScore";
            this.lblOScore.Size = new System.Drawing.Size(42, 46);
            this.lblOScore.TabIndex = 7;
            this.lblOScore.Text = "0";
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1667, 1032);
            this.Controls.Add(this.lblOScore);
            this.Controls.Add(this.lblXScore);
            this.Controls.Add(this.lblO);
            this.Controls.Add(this.lblX);
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
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblO;
        private System.Windows.Forms.Label lblXScore;
        private System.Windows.Forms.Label lblOScore;




    }
}

