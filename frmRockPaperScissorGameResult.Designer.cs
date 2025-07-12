namespace Tic_Tac_Toc
{
    partial class frmRockPaperScissorGameResult
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
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFinalWinner = new System.Windows.Forms.Label();
            this.lblDrawTimes = new System.Windows.Forms.Label();
            this.lblComputerWonTimes = new System.Windows.Forms.Label();
            this.lblPlayer1WonTimes = new System.Windows.Forms.Label();
            this.lblNumberOfRounds = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(240, 573);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(187, 57);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rock-Paper-Sicssor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Game Result";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblFinalWinner);
            this.panel1.Controls.Add(this.lblDrawTimes);
            this.panel1.Controls.Add(this.lblComputerWonTimes);
            this.panel1.Controls.Add(this.lblPlayer1WonTimes);
            this.panel1.Controls.Add(this.lblNumberOfRounds);
            this.panel1.Location = new System.Drawing.Point(124, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 285);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Final Winner                :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Draw Times                  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Computer Won Times:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "Player Won Times      : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 31);
            this.label7.TabIndex = 5;
            this.label7.Text = "Game Rounds              :";
            // 
            // lblFinalWinner
            // 
            this.lblFinalWinner.AutoSize = true;
            this.lblFinalWinner.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalWinner.Location = new System.Drawing.Point(311, 240);
            this.lblFinalWinner.Name = "lblFinalWinner";
            this.lblFinalWinner.Size = new System.Drawing.Size(79, 31);
            this.lblFinalWinner.TabIndex = 4;
            this.lblFinalWinner.Text = "label5";
            // 
            // lblDrawTimes
            // 
            this.lblDrawTimes.AutoSize = true;
            this.lblDrawTimes.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrawTimes.Location = new System.Drawing.Point(311, 185);
            this.lblDrawTimes.Name = "lblDrawTimes";
            this.lblDrawTimes.Size = new System.Drawing.Size(79, 31);
            this.lblDrawTimes.TabIndex = 3;
            this.lblDrawTimes.Text = "label5";
            // 
            // lblComputerWonTimes
            // 
            this.lblComputerWonTimes.AutoSize = true;
            this.lblComputerWonTimes.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerWonTimes.Location = new System.Drawing.Point(311, 129);
            this.lblComputerWonTimes.Name = "lblComputerWonTimes";
            this.lblComputerWonTimes.Size = new System.Drawing.Size(79, 31);
            this.lblComputerWonTimes.TabIndex = 2;
            this.lblComputerWonTimes.Text = "label5";
            // 
            // lblPlayer1WonTimes
            // 
            this.lblPlayer1WonTimes.AutoSize = true;
            this.lblPlayer1WonTimes.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1WonTimes.Location = new System.Drawing.Point(311, 77);
            this.lblPlayer1WonTimes.Name = "lblPlayer1WonTimes";
            this.lblPlayer1WonTimes.Size = new System.Drawing.Size(79, 31);
            this.lblPlayer1WonTimes.TabIndex = 1;
            this.lblPlayer1WonTimes.Text = "label4";
            // 
            // lblNumberOfRounds
            // 
            this.lblNumberOfRounds.AutoSize = true;
            this.lblNumberOfRounds.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRounds.Location = new System.Drawing.Point(311, 22);
            this.lblNumberOfRounds.Name = "lblNumberOfRounds";
            this.lblNumberOfRounds.Size = new System.Drawing.Size(79, 31);
            this.lblNumberOfRounds.TabIndex = 0;
            this.lblNumberOfRounds.Text = "label3";
            // 
            // frmRockPaperScissorGameResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(708, 711);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Name = "frmRockPaperScissorGameResult";
            this.Text = "frmRockPaperScissorGameResult";
            this.Load += new System.EventHandler(this.frmRockPaperScissorGameResult_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFinalWinner;
        private System.Windows.Forms.Label lblDrawTimes;
        private System.Windows.Forms.Label lblComputerWonTimes;
        private System.Windows.Forms.Label lblPlayer1WonTimes;
        private System.Windows.Forms.Label lblNumberOfRounds;
    }
}