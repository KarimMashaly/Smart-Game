namespace Tic_Tac_Toc
{
    partial class frmMathGame
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblNumberOfQuestion = new System.Windows.Forms.Label();
            this.btnAnswer1 = new System.Windows.Forms.Button();
            this.btnAnswer2 = new System.Windows.Forms.Button();
            this.btnAnswer3 = new System.Windows.Forms.Button();
            this.btnAnswer4 = new System.Windows.Forms.Button();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.TImerLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Math Game";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(35, 189);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(79, 31);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "label2";
            // 
            // lblNumberOfQuestion
            // 
            this.lblNumberOfQuestion.AutoSize = true;
            this.lblNumberOfQuestion.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfQuestion.Location = new System.Drawing.Point(35, 132);
            this.lblNumberOfQuestion.Name = "lblNumberOfQuestion";
            this.lblNumberOfQuestion.Size = new System.Drawing.Size(79, 31);
            this.lblNumberOfQuestion.TabIndex = 2;
            this.lblNumberOfQuestion.Text = "label2";
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnswer1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer1.Location = new System.Drawing.Point(31, 336);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(118, 66);
            this.btnAnswer1.TabIndex = 3;
            this.btnAnswer1.Tag = "1";
            this.btnAnswer1.UseVisualStyleBackColor = true;
            this.btnAnswer1.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnswer2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer2.Location = new System.Drawing.Point(379, 336);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(118, 66);
            this.btnAnswer2.TabIndex = 4;
            this.btnAnswer2.Tag = "2";
            this.btnAnswer2.UseVisualStyleBackColor = true;
            this.btnAnswer2.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnswer3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer3.Location = new System.Drawing.Point(31, 430);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(118, 66);
            this.btnAnswer3.TabIndex = 5;
            this.btnAnswer3.Tag = "3";
            this.btnAnswer3.UseVisualStyleBackColor = true;
            this.btnAnswer3.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnswer4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer4.Location = new System.Drawing.Point(379, 430);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(118, 66);
            this.btnAnswer4.TabIndex = 6;
            this.btnAnswer4.Tag = "4";
            this.btnAnswer4.UseVisualStyleBackColor = true;
            this.btnAnswer4.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNextQuestion.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextQuestion.Location = new System.Drawing.Point(334, 610);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(200, 46);
            this.btnNextQuestion.TabIndex = 8;
            this.btnNextQuestion.Text = "Next >>";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(373, 152);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(76, 31);
            this.lblTimer.TabIndex = 9;
            this.lblTimer.Text = "label2";
            // 
            // TImerLabel
            // 
            this.TImerLabel.AutoSize = true;
            this.TImerLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TImerLabel.Location = new System.Drawing.Point(277, 152);
            this.TImerLabel.Name = "TImerLabel";
            this.TImerLabel.Size = new System.Drawing.Size(83, 31);
            this.TImerLabel.TabIndex = 10;
            this.TImerLabel.Text = "Timer:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMathGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(546, 684);
            this.Controls.Add(this.TImerLabel);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.btnAnswer4);
            this.Controls.Add(this.btnAnswer3);
            this.Controls.Add(this.btnAnswer2);
            this.Controls.Add(this.btnAnswer1);
            this.Controls.Add(this.lblNumberOfQuestion);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.label1);
            this.Name = "frmMathGame";
            this.Text = "frmMathGame";
            this.Load += new System.EventHandler(this.frmMathGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblNumberOfQuestion;
        private System.Windows.Forms.Button btnAnswer1;
        private System.Windows.Forms.Button btnAnswer2;
        private System.Windows.Forms.Button btnAnswer3;
        private System.Windows.Forms.Button btnAnswer4;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label TImerLabel;
        private System.Windows.Forms.Timer timer1;
    }
}