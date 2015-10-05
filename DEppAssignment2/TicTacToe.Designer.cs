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
            this.btn0_0 = new System.Windows.Forms.Button();
            this.btn1_0 = new System.Windows.Forms.Button();
            this.btn2_0 = new System.Windows.Forms.Button();
            this.btn2_1 = new System.Windows.Forms.Button();
            this.btn1_1 = new System.Windows.Forms.Button();
            this.btn0_1 = new System.Windows.Forms.Button();
            this.btn2_2 = new System.Windows.Forms.Button();
            this.btn1_2 = new System.Windows.Forms.Button();
            this.btn0_2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn0_0
            // 
            this.btn0_0.Location = new System.Drawing.Point(43, 24);
            this.btn0_0.Name = "btn0_0";
            this.btn0_0.Size = new System.Drawing.Size(116, 116);
            this.btn0_0.TabIndex = 0;
            this.btn0_0.UseVisualStyleBackColor = true;
            this.btn0_0.Click += new System.EventHandler(this.changeValue);
            // 
            // btn1_0
            // 
            this.btn1_0.Location = new System.Drawing.Point(43, 146);
            this.btn1_0.Name = "btn1_0";
            this.btn1_0.Size = new System.Drawing.Size(116, 116);
            this.btn1_0.TabIndex = 1;
            this.btn1_0.UseVisualStyleBackColor = true;
            this.btn1_0.Click += new System.EventHandler(this.changeValue);
            // 
            // btn2_0
            // 
            this.btn2_0.Location = new System.Drawing.Point(43, 268);
            this.btn2_0.Name = "btn2_0";
            this.btn2_0.Size = new System.Drawing.Size(116, 116);
            this.btn2_0.TabIndex = 2;
            this.btn2_0.UseVisualStyleBackColor = true;
            this.btn2_0.Click += new System.EventHandler(this.changeValue);
            // 
            // btn2_1
            // 
            this.btn2_1.Location = new System.Drawing.Point(165, 268);
            this.btn2_1.Name = "btn2_1";
            this.btn2_1.Size = new System.Drawing.Size(116, 116);
            this.btn2_1.TabIndex = 5;
            this.btn2_1.UseVisualStyleBackColor = true;
            this.btn2_1.Click += new System.EventHandler(this.changeValue);
            // 
            // btn1_1
            // 
            this.btn1_1.Location = new System.Drawing.Point(165, 146);
            this.btn1_1.Name = "btn1_1";
            this.btn1_1.Size = new System.Drawing.Size(116, 116);
            this.btn1_1.TabIndex = 4;
            this.btn1_1.UseVisualStyleBackColor = true;
            this.btn1_1.Click += new System.EventHandler(this.changeValue);
            // 
            // btn0_1
            // 
            this.btn0_1.Location = new System.Drawing.Point(165, 24);
            this.btn0_1.Name = "btn0_1";
            this.btn0_1.Size = new System.Drawing.Size(116, 116);
            this.btn0_1.TabIndex = 3;
            this.btn0_1.UseVisualStyleBackColor = true;
            this.btn0_1.Click += new System.EventHandler(this.changeValue);
            // 
            // btn2_2
            // 
            this.btn2_2.Location = new System.Drawing.Point(287, 268);
            this.btn2_2.Name = "btn2_2";
            this.btn2_2.Size = new System.Drawing.Size(116, 116);
            this.btn2_2.TabIndex = 8;
            this.btn2_2.UseVisualStyleBackColor = true;
            this.btn2_2.Click += new System.EventHandler(this.changeValue);
            // 
            // btn1_2
            // 
            this.btn1_2.Location = new System.Drawing.Point(287, 146);
            this.btn1_2.Name = "btn1_2";
            this.btn1_2.Size = new System.Drawing.Size(116, 116);
            this.btn1_2.TabIndex = 7;
            this.btn1_2.UseVisualStyleBackColor = true;
            this.btn1_2.Click += new System.EventHandler(this.changeValue);
            // 
            // btn0_2
            // 
            this.btn0_2.Location = new System.Drawing.Point(287, 24);
            this.btn0_2.Name = "btn0_2";
            this.btn0_2.Size = new System.Drawing.Size(116, 116);
            this.btn0_2.TabIndex = 6;
            this.btn0_2.UseVisualStyleBackColor = true;
            this.btn0_2.Click += new System.EventHandler(this.changeValue);
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 575);
            this.Controls.Add(this.btn2_2);
            this.Controls.Add(this.btn1_2);
            this.Controls.Add(this.btn0_2);
            this.Controls.Add(this.btn2_1);
            this.Controls.Add(this.btn1_1);
            this.Controls.Add(this.btn0_1);
            this.Controls.Add(this.btn2_0);
            this.Controls.Add(this.btn1_0);
            this.Controls.Add(this.btn0_0);
            this.Name = "TicTacToe";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn0_0;
        private System.Windows.Forms.Button btn1_0;
        private System.Windows.Forms.Button btn2_0;
        private System.Windows.Forms.Button btn2_1;
        private System.Windows.Forms.Button btn1_1;
        private System.Windows.Forms.Button btn0_1;
        private System.Windows.Forms.Button btn2_2;
        private System.Windows.Forms.Button btn1_2;
        private System.Windows.Forms.Button btn0_2;
    }
}

