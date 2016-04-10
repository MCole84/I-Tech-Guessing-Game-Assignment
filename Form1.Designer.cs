namespace GuessingGame
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
            this.btnCheckGuess = new System.Windows.Forms.Button();
            this.txtUserGuess = new System.Windows.Forms.TextBox();
            this.lblBanner = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGuessResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheckGuess
            // 
            this.btnCheckGuess.Location = new System.Drawing.Point(84, 177);
            this.btnCheckGuess.Name = "btnCheckGuess";
            this.btnCheckGuess.Size = new System.Drawing.Size(100, 23);
            this.btnCheckGuess.TabIndex = 0;
            this.btnCheckGuess.Text = "Submit Guess";
            this.btnCheckGuess.UseVisualStyleBackColor = true;
            this.btnCheckGuess.Click += new System.EventHandler(this.btnCheckGuess_Click);
            // 
            // txtUserGuess
            // 
            this.txtUserGuess.Location = new System.Drawing.Point(84, 140);
            this.txtUserGuess.Name = "txtUserGuess";
            this.txtUserGuess.Size = new System.Drawing.Size(100, 20);
            this.txtUserGuess.TabIndex = 1;
            // 
            // lblBanner
            // 
            this.lblBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanner.Location = new System.Drawing.Point(12, 9);
            this.lblBanner.Name = "lblBanner";
            this.lblBanner.Size = new System.Drawing.Size(260, 25);
            this.lblBanner.TabIndex = 2;
            this.lblBanner.Text = "Welcome to the Number guess game";
            this.lblBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Try to guess the number between 1 and 100";
            // 
            // lblGuessResult
            // 
            this.lblGuessResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGuessResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessResult.Location = new System.Drawing.Point(37, 61);
            this.lblGuessResult.Name = "lblGuessResult";
            this.lblGuessResult.Size = new System.Drawing.Size(213, 37);
            this.lblGuessResult.TabIndex = 4;
            this.lblGuessResult.Text = "label2";
            this.lblGuessResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblGuessResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBanner);
            this.Controls.Add(this.txtUserGuess);
            this.Controls.Add(this.btnCheckGuess);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckGuess;
        private System.Windows.Forms.TextBox txtUserGuess;
        private System.Windows.Forms.Label lblBanner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGuessResult;
    }
}

