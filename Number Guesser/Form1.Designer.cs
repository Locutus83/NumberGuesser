namespace Number_Guesser
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
            this.lblLimit = new System.Windows.Forms.Label();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.btnHigher = new System.Windows.Forms.Button();
            this.btnLower = new System.Windows.Forms.Button();
            this.btnGotIt = new System.Windows.Forms.Button();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblGuess = new System.Windows.Forms.Label();
            this.lblGuessCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.Location = new System.Drawing.Point(30, 50);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(64, 13);
            this.lblLimit.TabIndex = 0;
            this.lblLimit.Text = "Enter a limit:";
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(129, 47);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(100, 20);
            this.txtLimit.TabIndex = 1;
            this.txtLimit.Text = "10";
            // 
            // btnHigher
            // 
            this.btnHigher.Enabled = false;
            this.btnHigher.Location = new System.Drawing.Point(46, 159);
            this.btnHigher.Name = "btnHigher";
            this.btnHigher.Size = new System.Drawing.Size(75, 23);
            this.btnHigher.TabIndex = 2;
            this.btnHigher.Text = "Higher";
            this.btnHigher.UseVisualStyleBackColor = true;
            this.btnHigher.Click += new System.EventHandler(this.btnLower_Click);
            // 
            // btnLower
            // 
            this.btnLower.Enabled = false;
            this.btnLower.Location = new System.Drawing.Point(167, 159);
            this.btnLower.Name = "btnLower";
            this.btnLower.Size = new System.Drawing.Size(75, 23);
            this.btnLower.TabIndex = 3;
            this.btnLower.Text = "Lower";
            this.btnLower.UseVisualStyleBackColor = true;
            this.btnLower.Click += new System.EventHandler(this.btnLower_Click);
            // 
            // btnGotIt
            // 
            this.btnGotIt.Enabled = false;
            this.btnGotIt.Location = new System.Drawing.Point(105, 198);
            this.btnGotIt.Name = "btnGotIt";
            this.btnGotIt.Size = new System.Drawing.Size(75, 23);
            this.btnGotIt.TabIndex = 4;
            this.btnGotIt.Text = "Got It!!!";
            this.btnGotIt.UseVisualStyleBackColor = true;
            this.btnGotIt.Click += new System.EventHandler(this.btnGotIt_Click);
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(105, 73);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 23);
            this.btnGuess.TabIndex = 5;
            this.btnGuess.Text = "Guess!";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblGuess
            // 
            this.lblGuess.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuess.Location = new System.Drawing.Point(12, 99);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(260, 57);
            this.lblGuess.TabIndex = 6;
            this.lblGuess.Text = "label1";
            this.lblGuess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGuessCount
            // 
            this.lblGuessCount.Location = new System.Drawing.Point(172, 9);
            this.lblGuessCount.Name = "lblGuessCount";
            this.lblGuessCount.Size = new System.Drawing.Size(100, 23);
            this.lblGuessCount.TabIndex = 7;
            this.lblGuessCount.Text = "Guess Count:";
            this.lblGuessCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGuess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblGuessCount);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.btnGotIt);
            this.Controls.Add(this.btnLower);
            this.Controls.Add(this.btnHigher);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.lblLimit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.Button btnHigher;
        private System.Windows.Forms.Button btnLower;
        private System.Windows.Forms.Button btnGotIt;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.Label lblGuessCount;
    }
}

