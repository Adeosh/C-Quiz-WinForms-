namespace C__Quiz_WinForms_
{
    partial class Quiz5
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
            this.lblNumOfTest = new System.Windows.Forms.Label();
            this.lblMinimized = new System.Windows.Forms.Label();
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnAnswer3 = new System.Windows.Forms.Button();
            this.btnAnswer4 = new System.Windows.Forms.Button();
            this.btnAnswer2 = new System.Windows.Forms.Button();
            this.btnAnswer1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumOfTest
            // 
            this.lblNumOfTest.AutoSize = true;
            this.lblNumOfTest.BackColor = System.Drawing.Color.Transparent;
            this.lblNumOfTest.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumOfTest.ForeColor = System.Drawing.Color.Azure;
            this.lblNumOfTest.Location = new System.Drawing.Point(12, 9);
            this.lblNumOfTest.Name = "lblNumOfTest";
            this.lblNumOfTest.Size = new System.Drawing.Size(67, 24);
            this.lblNumOfTest.TabIndex = 45;
            this.lblNumOfTest.Text = "Тест 5";
            // 
            // lblMinimized
            // 
            this.lblMinimized.AutoSize = true;
            this.lblMinimized.BackColor = System.Drawing.Color.Transparent;
            this.lblMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimized.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMinimized.ForeColor = System.Drawing.Color.Azure;
            this.lblMinimized.Location = new System.Drawing.Point(925, -2);
            this.lblMinimized.Name = "lblMinimized";
            this.lblMinimized.Size = new System.Drawing.Size(29, 35);
            this.lblMinimized.TabIndex = 44;
            this.lblMinimized.Text = "_";
            this.lblMinimized.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMinimized.Click += new System.EventHandler(this.lblMinimized_Click);
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.AutoSize = true;
            this.lblMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMainMenu.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMainMenu.ForeColor = System.Drawing.Color.Azure;
            this.lblMainMenu.Location = new System.Drawing.Point(960, 2);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(28, 35);
            this.lblMainMenu.TabIndex = 43;
            this.lblMainMenu.Text = "«";
            this.lblMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMainMenu.Click += new System.EventHandler(this.lblMainMenu_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSize = true;
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeBtn.ForeColor = System.Drawing.Color.Azure;
            this.closeBtn.Location = new System.Drawing.Point(995, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(28, 35);
            this.closeBtn.TabIndex = 42;
            this.closeBtn.Text = "x";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuestion.ForeColor = System.Drawing.Color.Azure;
            this.lblQuestion.Location = new System.Drawing.Point(55, 45);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(900, 99);
            this.lblQuestion.TabIndex = 41;
            this.lblQuestion.Text = "Вопрос";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.BackColor = System.Drawing.Color.Azure;
            this.btnAnswer3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnswer3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnswer3.Location = new System.Drawing.Point(60, 390);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(360, 100);
            this.btnAnswer3.TabIndex = 4;
            this.btnAnswer3.Tag = "3";
            this.btnAnswer3.UseVisualStyleBackColor = false;
            this.btnAnswer3.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.BackColor = System.Drawing.Color.Azure;
            this.btnAnswer4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnswer4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnswer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnswer4.Location = new System.Drawing.Point(590, 390);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(360, 100);
            this.btnAnswer4.TabIndex = 5;
            this.btnAnswer4.Tag = "4";
            this.btnAnswer4.UseVisualStyleBackColor = false;
            this.btnAnswer4.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.BackColor = System.Drawing.Color.Azure;
            this.btnAnswer2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnswer2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnswer2.Location = new System.Drawing.Point(590, 260);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(360, 100);
            this.btnAnswer2.TabIndex = 3;
            this.btnAnswer2.Tag = "2";
            this.btnAnswer2.UseVisualStyleBackColor = false;
            this.btnAnswer2.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.BackColor = System.Drawing.Color.Azure;
            this.btnAnswer1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnswer1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnswer1.Location = new System.Drawing.Point(60, 260);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(360, 100);
            this.btnAnswer1.TabIndex = 2;
            this.btnAnswer1.Tag = "1";
            this.btnAnswer1.UseVisualStyleBackColor = false;
            this.btnAnswer1.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // Quiz5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::C__Quiz_WinForms_.Properties.Resources.Pic_4;
            this.ClientSize = new System.Drawing.Size(1024, 536);
            this.Controls.Add(this.lblNumOfTest);
            this.Controls.Add(this.lblMinimized);
            this.Controls.Add(this.lblMainMenu);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnAnswer3);
            this.Controls.Add(this.btnAnswer4);
            this.Controls.Add(this.btnAnswer2);
            this.Controls.Add(this.btnAnswer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Quiz5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Quiz5_FormClosed);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Quiz5_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Quiz5_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumOfTest;
        private System.Windows.Forms.Label lblMinimized;
        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnAnswer3;
        private System.Windows.Forms.Button btnAnswer4;
        private System.Windows.Forms.Button btnAnswer2;
        private System.Windows.Forms.Button btnAnswer1;
    }
}