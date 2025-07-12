namespace Tic_Tac_Toc
{
    partial class frmRockPaperScissorsGame
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
            this.btnScissor = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnRock = new System.Windows.Forms.Button();
            this.lblRound = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWinner = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblComputerChoice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblYourChoice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnScissor
            // 
            this.btnScissor.BackgroundImage = global::Tic_Tac_Toc.Properties.Resources.Scissor;
            this.btnScissor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScissor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnScissor.Location = new System.Drawing.Point(826, 121);
            this.btnScissor.Name = "btnScissor";
            this.btnScissor.Size = new System.Drawing.Size(212, 219);
            this.btnScissor.TabIndex = 2;
            this.btnScissor.Tag = "3";
            this.btnScissor.UseVisualStyleBackColor = true;
            this.btnScissor.Click += new System.EventHandler(this.btnScissor_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.BackgroundImage = global::Tic_Tac_Toc.Properties.Resources.Paper;
            this.btnPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaper.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPaper.Location = new System.Drawing.Point(494, 121);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(212, 219);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.Tag = "2";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnRock
            // 
            this.btnRock.BackgroundImage = global::Tic_Tac_Toc.Properties.Resources.fist;
            this.btnRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRock.Location = new System.Drawing.Point(140, 121);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(212, 219);
            this.btnRock.TabIndex = 0;
            this.btnRock.Tag = "1";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.Location = new System.Drawing.Point(539, 414);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(166, 50);
            this.lblRound.TabIndex = 3;
            this.lblRound.Text = "Round 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(554, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "Paper";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(887, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 38);
            this.label4.TabIndex = 6;
            this.label4.Text = "Scissor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(63, 514);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 227);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblWinner);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblComputerChoice);
            this.panel1.Controls.Add(this.lblTurn);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblYourChoice);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(439, 483);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 258);
            this.panel1.TabIndex = 8;
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.Location = new System.Drawing.Point(121, 189);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(26, 31);
            this.lblWinner.TabIndex = 5;
            this.lblWinner.Text = ";;";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 31);
            this.label9.TabIndex = 4;
            this.label9.Text = "Winner:";
            // 
            // lblComputerChoice
            // 
            this.lblComputerChoice.AutoSize = true;
            this.lblComputerChoice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerChoice.Location = new System.Drawing.Point(235, 140);
            this.lblComputerChoice.Name = "lblComputerChoice";
            this.lblComputerChoice.Size = new System.Drawing.Size(26, 31);
            this.lblComputerChoice.TabIndex = 3;
            this.lblComputerChoice.Text = ";;";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 31);
            this.label7.TabIndex = 2;
            this.label7.Text = "Computer Choice:";
            // 
            // lblYourChoice
            // 
            this.lblYourChoice.AutoSize = true;
            this.lblYourChoice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourChoice.Location = new System.Drawing.Point(167, 89);
            this.lblYourChoice.Name = "lblYourChoice";
            this.lblYourChoice.Size = new System.Drawing.Size(40, 31);
            this.lblYourChoice.TabIndex = 1;
            this.lblYourChoice.Text = "kk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Your Choice:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 31);
            this.label11.TabIndex = 6;
            this.label11.Text = "Turn:";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.Location = new System.Drawing.Point(103, 40);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(80, 31);
            this.lblTurn.TabIndex = 6;
            this.lblTurn.Text = "Player";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(954, 512);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(213, 227);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Your Choice";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(958, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "Computer Choice";
            // 
            // frmRockPaperScissorsGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1218, 753);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.btnScissor);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Name = "frmRockPaperScissorsGame";
            this.Text = "frmRockPaperScissorsGame";
            this.Load += new System.EventHandler(this.frmRockPaperScissorsGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissor;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblYourChoice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblComputerChoice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}