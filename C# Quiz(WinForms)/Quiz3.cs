using System;
using System.Drawing;
using System.Windows.Forms;

namespace C__Quiz_WinForms_
{
    public partial class Quiz3 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percenage;
        int totalQuestion;

        public Quiz3()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestion = 20;
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

        private void Quiz3_FormClosed(object sender, FormClosedEventArgs e)
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
        private void Quiz3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Quiz3_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
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

        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    lblQuestion.Text = "Какое из этих ключевых слов не является частью обработки исключений?";

                    btnAnswer1.Text = "catch";
                    btnAnswer2.Text = "thrown";
                    btnAnswer3.Text = "finally";
                    btnAnswer4.Text = "try";

                    correctAnswer = 2;

                    break;
                case 2:
                    lblQuestion.Text = "Что такое многопоточное программирование?";

                    btnAnswer1.Text = "Это процесс, в котором один процесс может получить доступ к информации из многих источников";
                    btnAnswer2.Text = "Это процесс, в котором множество разных процессов могут получить доступ к одной и той же информации";
                    btnAnswer3.Text = "Это процесс, в котором одновременно выполняются два разных процесса";
                    btnAnswer4.Text = "Это процесс, в котором две или более части одного и того же процесса выполняются одновременно";

                    correctAnswer = 4;

                    break;
                case 3:
                    lblQuestion.Text = "Какое из этих ключевых слов используется для ручного создания исключения?";

                    btnAnswer1.Text = "catch";
                    btnAnswer2.Text = "throw";
                    btnAnswer3.Text = "finally";
                    btnAnswer4.Text = "try";

                    correctAnswer = 2;

                    break;
                case 4:
                    lblQuestion.Text = "Какое из следующих неверных утверждений о пространстве имен, используемых в C#.NET ?";

                    btnAnswer1.Text = "Все элементы пространства имен должны принадлежать одному файлу";
                    btnAnswer2.Text = "Классы должны принадлежать пространству имен, тогда как структуры не должны";
                    btnAnswer3.Text = "Все вышеперечисленное";
                    btnAnswer4.Text = "Ничего из вышеперечисленного";

                    correctAnswer = 3;

                    break;
                case 5:
                    lblQuestion.Text = "Если во время выполнения не генерируется исключение, то кто его поймает?";

                    btnAnswer1.Text = "Компилятор";
                    btnAnswer2.Text = "Загрузчик";
                    btnAnswer3.Text = "Операционная система";
                    btnAnswer4.Text = "CLR";

                    correctAnswer = 4;

                    break;
                case 6:
                    lblQuestion.Text = "Выберите правильное утверждение о свойствах, описывающих индексаторы";

                    btnAnswer1.Text = "Индексаторы могут быть перегружены";
                    btnAnswer2.Text = "Нет необходимости использовать имя свойства при использовании индексированного свойства";
                    btnAnswer3.Text = "Свойство индексатора должно принимать хотя бы один аргумент";
                    btnAnswer4.Text = "Все вышеперечисленное";

                    correctAnswer = 4;

                    break;
                case 7:
                    lblQuestion.Text = "Выберите правильное утверждение о свойствах чтения и записи в C#.NET";

                    btnAnswer1.Text = "Свойство, доступное только для чтения, будет иметь только средство доступа get";
                    btnAnswer2.Text = "Свойство может быть доступно только для чтения или только для записи";
                    btnAnswer3.Text = "Все вышеперечисленное";
                    btnAnswer4.Text = "Ничего из вышеперечисленного";

                    correctAnswer = 3;

                    break;
                case 8:
                    lblQuestion.Text = "Какой из следующих способов не позволяет в дальнейшем проверять атрибут, который был однажды применен?";

                    btnAnswer1.Text = "CLR";
                    btnAnswer2.Text = "Языковые компиляторы";
                    btnAnswer3.Text = "ASP.NET Runtime";
                    btnAnswer4.Text = "Компоновщик";

                    correctAnswer = 4;

                    break;
                case 9:
                    lblQuestion.Text = "Правильным методом передачи параметра атрибуту является";

                    btnAnswer1.Text = "По положению";
                    btnAnswer2.Text = "По имени";
                    btnAnswer3.Text = "Все вышеперечисленное";
                    btnAnswer4.Text = "Ничего из вышеперечисленного";

                    correctAnswer = 3;

                    break;
                case 10:
                    lblQuestion.Text = "Атрибуты могут быть применены к";

                    btnAnswer1.Text = "Сборка";
                    btnAnswer2.Text = "Метод";
                    btnAnswer3.Text = "Класс";
                    btnAnswer4.Text = "Все вышеперечисленное";

                    correctAnswer = 4;

                    break;
                case 11:
                    lblQuestion.Text = "Какой из классов обеспечивает операции чтения из консоли и записи в C#.NET ?";

                    btnAnswer1.Text = "System.ReadLine";
                    btnAnswer2.Text = "System.Array";
                    btnAnswer3.Text = "System.Output";
                    btnAnswer4.Text = "System.Console";

                    correctAnswer = 4;

                    break;
                case 12:
                    lblQuestion.Text = "Какой из следующих методов копирует ссылку на ячейку памяти аргумента в формальный параметр?";

                    btnAnswer1.Text = "Output parameters";
                    btnAnswer2.Text = "Value parameters";
                    btnAnswer3.Text = "Reference parameters";
                    btnAnswer4.Text = "Ничего из вышеперечисленного";

                    correctAnswer = 3;

                    break;
                case 13:
                    lblQuestion.Text = "Что из следующего используется для определения члена класса извне?";

                    btnAnswer1.Text = "#";
                    btnAnswer2.Text = ":";
                    btnAnswer3.Text = "::";
                    btnAnswer4.Text = "Ничего из вышеперечисленного";

                    correctAnswer = 3;

                    break;
                case 14:
                    lblQuestion.Text = "Что чаще всего задается с помощью объявления класса?";

                    btnAnswer1.Text = "Область применения";
                    btnAnswer2.Text = "Тип и область применения";
                    btnAnswer3.Text = "Тип";
                    btnAnswer4.Text = "Ничего из вышеперечисленного";

                    correctAnswer = 2;

                    break;
                case 15:
                    lblQuestion.Text = "Какое из следующих утверждений об объектах в C # является правильным?";

                    btnAnswer1.Text = "У объектов есть методы и события, которые позволяют им выполнять действия";
                    btnAnswer2.Text = "Все объекты, созданные из класса, будут занимать равное количество байт в памяти";
                    btnAnswer3.Text = "Все, что вы используете в C #, является объектом, включая Windows Forms и элементы управления";
                    btnAnswer4.Text = "Все вышеперечисленное";

                    correctAnswer = 4;

                    break;
                case 16:
                    lblQuestion.Text = "Сколько байт хранится в long?";

                    btnAnswer1.Text = "8";
                    btnAnswer2.Text = "4";
                    btnAnswer3.Text = "1";
                    btnAnswer4.Text = "2";

                    correctAnswer = 1;

                    break;
                case 17:
                    lblQuestion.Text = "Выберите имя .NET class, из которого получен тип данных UInt?";

                    btnAnswer1.Text = "System.UInt16";
                    btnAnswer2.Text = "System.UInt64";
                    btnAnswer3.Text = "System.Int16";
                    btnAnswer4.Text = "System.UInt32";

                    correctAnswer = 4;

                    break;
                case 18:
                    lblQuestion.Text = "Правильное объявление значений переменных a и b?";

                    btnAnswer1.Text = "int a = b = 42;";
                    btnAnswer2.Text = "int a = 32, b = 40.6;";
                    btnAnswer3.Text = "int a = 42; b = 40;";
                    btnAnswer4.Text = "int a = 32; int b = 40;";

                    correctAnswer = 4;

                    break;
                case 19:
                    lblQuestion.Text = "Кокой правильный способ присвоения значений переменной c, когда int a = 12, float b = 3.5, int c;";

                    btnAnswer1.Text = "c = int(a + b);";
                    btnAnswer2.Text = "c = a + b;";
                    btnAnswer3.Text = "c = a + int(float(b));";
                    btnAnswer4.Text = "c = a + convert.ToInt32(b);";

                    correctAnswer = 4;

                    break;
                case 20:
                    lblQuestion.Text = "Какой из этих методов возвращает наибольшее целое число, меньшее или равное переменной X ?";

                    btnAnswer1.Text = "double Min(double X)";
                    btnAnswer2.Text = "double Max(double X)";
                    btnAnswer3.Text = "double Floor(double X)";
                    btnAnswer4.Text = "double Ciel(double X)";

                    correctAnswer = 3;

                    break;
            }
        }
    }
}
