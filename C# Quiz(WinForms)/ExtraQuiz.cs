using System;
using System.Drawing;
using System.Windows.Forms;

namespace C__Quiz_WinForms_
{
    public partial class ExtraQuiz : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percenage;
        int totalQuestion;

        public ExtraQuiz()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestion = 10;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void ExtraQuiz_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMainMenu_Click(object sender, EventArgs e)
        {
            Main mainWnd = new Main();
            mainWnd.Show();
            this.Hide();
        }

        private void lblMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        Point lastPoint;
        private void ExtraQuiz_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void ExtraQuiz_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            if (e.Delta != 0)
            {
                if (e.Delta <= 0)
                {
                    if (pctBox.Width <= 900 && pctBox.Height <= 168)
                        return;
                }
                else
                {
                    if (pctBox.Width > 2560 && pctBox.Height > 1440)
                        return;
                }
                pctBox.Width += Convert.ToInt32(pctBox.Width * e.Delta / 1024);
                pctBox.Height += Convert.ToInt32(pctBox.Height * e.Delta / 1024);
            }
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }
            else
            {
                MessageBox.Show("Не верно" + Environment.NewLine + correctAnswer);
            }

            if (questionNumber == totalQuestion)
            {
                percenage = (int)Math.Round((double)(score * 100) / totalQuestion);

                MessageBox.Show(
                    "Векторина окончена" + Environment.NewLine +
                    "Ты ответил на " + score + " вопрос(ов) правильно" + Environment.NewLine +
                    "Общий процент правельных ответов " + percenage + "%" + Environment.NewLine +
                    "Нажми ОК чтобы начать сначала."
                );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);

                Main mainWnd = new Main();
                mainWnd.Show();
                this.Hide();
            }
            questionNumber++;
            askQuestion(questionNumber);
        }

        #region Вопросы
        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    pctBox.Image = Properties.Resources.Code_1;

                    btnAnswer1.Text = "0, 1, 2, 3, 4, 5, 6, 7, 8, 9";
                    btnAnswer2.Text = "10, 10, 10, 10, 10, 10, 10, 10, 10, 10";
                    btnAnswer3.Text = "Код сгенерирует исключение";
                    btnAnswer4.Text = "0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,";

                    correctAnswer = 2;

                    break;
                case 2:
                    pctBox.Image = Properties.Resources.Code_2;

                    btnAnswer1.Text = "4";
                    btnAnswer2.Text = "3";
                    btnAnswer3.Text = "1";
                    btnAnswer4.Text = "8";

                    correctAnswer = 1;

                    break;
                case 3:
                    pctBox.Image = Properties.Resources.Code_3;

                    btnAnswer1.Text = "Main Thread : 1 Started\r\n250 even numbers out of 500 total\r\nMain Thread : 1 Completed";
                    btnAnswer2.Text = "Main Thread : 1 Started\r\n100 even numbers out of 500 total\r\nMain Thread : 1 Completed";
                    btnAnswer3.Text = "Main Thread : 1 Started\r\n25 even numbers out of 500 total\r\nMain Thread : 4 Completed";
                    btnAnswer4.Text = "Main Thread : 1 Started\r\n250 even numbers out of 500 total\r\nMain Thread : 2 Completed";

                    correctAnswer = 1;

                    break;
                case 4:
                    pctBox.Image = Properties.Resources.Code_4;

                    btnAnswer1.Text = "Тип данных System.String, значение test\r\nТип данных System.Int64, значение 5\r\nТип данных System.Char, значение q\r\nТип данных System.Single, значение 5,89\r\nТип данных System.Boolean, значение True";
                    btnAnswer2.Text = "Тип данных System.String, значение test\r\nТип данных System.Int32, значение 5\r\nТип данных System.Var, значение q\r\nТип данных System.Double, значение 5,89\r\nТип данных System.Boolean, значение True";
                    btnAnswer3.Text = "Тип данных System.String, значение test\r\nТип данных System.Int32, значение 5\r\nТип данных System.Char, значение q\r\nТип данных System.Single, значение 5,89\r\nТип данных System.Boolean, значение True";
                    btnAnswer4.Text = "Ошибка компилятора";

                    correctAnswer = 3;

                    break;
                case 5:
                    pctBox.Image = Properties.Resources.Code_5;

                    btnAnswer1.Text = "9,17";
                    btnAnswer2.Text = "17,9";
                    btnAnswer3.Text = "8,9";
                    btnAnswer4.Text = "4,5";

                    correctAnswer = 1;

                    break;
                case 6:
                    pctBox.Image = Properties.Resources.Code_6;

                    btnAnswer1.Text = "The value-type value = 123\r\nThe object-type value = 123";
                    btnAnswer2.Text = "The value-type value = 456\r\nThe object-type value = 456";
                    btnAnswer3.Text = "The value-type value = 123\r\nThe object-type value = 456";
                    btnAnswer4.Text = "The value-type value = 456\r\nThe object-type value = 123";

                    correctAnswer = 4;

                    break;
                case 7:
                    pctBox.Image = Properties.Resources.Code_7;

                    btnAnswer1.Text = "null";
                    btnAnswer2.Text = "0";
                    btnAnswer3.Text = "2";
                    btnAnswer4.Text = "string";

                    correctAnswer = 3;

                    break;
                case 8:
                    pctBox.Image = Properties.Resources.Code_8;

                    btnAnswer1.Text = "210,12";
                    btnAnswer2.Text = "2000012";
                    btnAnswer3.Text = "21.12";
                    btnAnswer4.Text = "211.2";

                    correctAnswer = 1;

                    break;
                case 9:
                    pctBox.Image = Properties.Resources.Code_9;

                    btnAnswer1.Text = "5\r\n3\r\n2";
                    btnAnswer2.Text = "1\r\n2\r\n3";
                    btnAnswer3.Text = "3\r\n2\r\n1";
                    btnAnswer4.Text = "2\r\n3\r\n5";

                    correctAnswer = 1;

                    break;
                case 10:
                    pctBox.Image = Properties.Resources.Code_10;

                    btnAnswer1.Text = "Bye!\r\n100";
                    btnAnswer2.Text = "Execute the finally block...\r\n200";
                    btnAnswer3.Text = "Execute the finally block...\r\n100";
                    btnAnswer4.Text = "Bye!\r\n200";

                    correctAnswer = 3;

                    break;
            }
            #endregion
        }
    }
}
