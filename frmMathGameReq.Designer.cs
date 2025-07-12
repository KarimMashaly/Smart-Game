namespace Tic_Tac_Toc
{
    partial class frmMathGameReq
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
            this.label1 = new System.Windows.Forms.Label();
            this.NUDNumberOfQuestions = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbQuestionsLevel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbOperationType = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.NUDNumberOfQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Math Game";
            // 
            // NUDNumberOfQuestions
            // 
            this.NUDNumberOfQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDNumberOfQuestions.Location = new System.Drawing.Point(575, 229);
            this.NUDNumberOfQuestions.Name = "NUDNumberOfQuestions";
            this.NUDNumberOfQuestions.Size = new System.Drawing.Size(97, 30);
            this.NUDNumberOfQuestions.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(498, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "How many questions do you wnat to answer?\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Choose Questions level:";
            // 
            // cbQuestionsLevel
            // 
            this.cbQuestionsLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuestionsLevel.FormattingEnabled = true;
            this.cbQuestionsLevel.Items.AddRange(new object[] {
            "Easy",
            "Med",
            "Hard",
            "Mix"});
            this.cbQuestionsLevel.Location = new System.Drawing.Point(315, 306);
            this.cbQuestionsLevel.Name = "cbQuestionsLevel";
            this.cbQuestionsLevel.Size = new System.Drawing.Size(119, 26);
            this.cbQuestionsLevel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Choose Operation Type:";
            // 
            // cbOperationType
            // 
            this.cbOperationType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOperationType.FormattingEnabled = true;
            this.cbOperationType.Items.AddRange(new object[] {
            "Addition",
            "Subtraction",
            "Multiplication",
            "Division",
            "Mix"});
            this.cbOperationType.Location = new System.Drawing.Point(315, 367);
            this.cbOperationType.Name = "cbOperationType";
            this.cbOperationType.Size = new System.Drawing.Size(119, 26);
            this.cbOperationType.TabIndex = 6;
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(395, 503);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(205, 72);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Do you want timer? ";
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbYes.Location = new System.Drawing.Point(282, 425);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(58, 29);
            this.rbYes.TabIndex = 9;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Checked = true;
            this.rbNo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNo.Location = new System.Drawing.Point(395, 425);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(57, 29);
            this.rbNo.TabIndex = 10;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // frmMathGameReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1023, 704);
            this.Controls.Add(this.rbNo);
            this.Controls.Add(this.rbYes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cbOperationType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbQuestionsLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NUDNumberOfQuestions);
            this.Controls.Add(this.label1);
            this.Name = "frmMathGameReq";
            this.Text = "frmMathGameReq";
            this.Load += new System.EventHandler(this.frmMathGameReq_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDNumberOfQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUDNumberOfQuestions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbQuestionsLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbOperationType;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.RadioButton rbNo;
    }
}