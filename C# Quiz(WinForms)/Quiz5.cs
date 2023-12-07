using System;
using System.Drawing;
using System.Windows.Forms;

namespace C__Quiz_WinForms_
{
    public partial class Quiz5 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percenage;
        int totalQuestion;

        public Quiz5()
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

        private void Quiz5_FormClosed(object sender, FormClosedEventArgs e)
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
        private void Quiz5_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Quiz5_MouseDown(object sender, MouseEventArgs e)
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

        #region Вопросы
        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    lblQuestion.Text = "Что из следующего верно в отношении структур C # по сравнению с классами C # ?";

                    btnAnswer1.Text = "Структуры не поддерживают наследование.";
                    btnAnswer2.Text = "Структуры не могут иметь конструктор по умолчанию.";
                    btnAnswer3.Text = "Классы - это ссылочные типы, а структуры - это типы значений.";
                    btnAnswer4.Text = "Все вышеперечисленное";

                    correctAnswer = 4;

                    break;
                case 2:
                    lblQuestion.Text = "Что такое итератор?";

                    btnAnswer1.Text = "accessor";
                    btnAnswer2.Text = "method";
                    btnAnswer3.Text = "operator";
                    btnAnswer4.Text = "Все вышеперечисленное";

                    correctAnswer = 4;

                    break;
                case 3:
                    lblQuestion.Text = "Выберите тип существующих методов многозадачности";

                    btnAnswer1.Text = "Основанный на потоках";
                    btnAnswer2.Text = "Основанный на процессе";
                    btnAnswer3.Text = "Все вышеперечисленное";
                    btnAnswer4.Text = "Ничего из вышеперечисленного";

                    correctAnswer = 3;

                    break;
                case 4:
                    lblQuestion.Text = "Допустимый размер типа данных с плавающей точкой равен";

                    btnAnswer1.Text = "4 Bytes";
                    btnAnswer2.Text = "10 Bytes";
                    btnAnswer3.Text = "8 Bytes";
                    btnAnswer4.Text = "6 Bytes";

                    correctAnswer = 1;

                    break;
                case 5:
                    lblQuestion.Text = "Какое из этих исключений возникнет, если мы попытаемся получить доступ к индексу массива, превышающему его длину?";

                    btnAnswer1.Text = "ArrayException";
                    btnAnswer2.Text = "ArrayArguementException";
                    btnAnswer3.Text = "ArithmeticException";
                    btnAnswer4.Text = "IndexOutOfRangeException";

                    correctAnswer = 4;

                    break;
                case 6:
                    lblQuestion.Text = "Выберите правильное утверждение о многозадачности на основе процессов";

                    btnAnswer1.Text = "Программа, которая действует как небольшая единица кода, которая может быть отправлена планировщиком";
                    btnAnswer2.Text = "Функция, которая позволяет нашему компьютеру запускать две или более программ одновременно";
                    btnAnswer3.Text = "Все вышеперечисленное";
                    btnAnswer4.Text = "Ничего из вышеперечисленного";

                    correctAnswer = 3;

                    break;
                case 7:
                    lblQuestion.Text = "Выберите инструкции, которые указывают на различия между многозадачностью на основе потоков и многозадачностью на основе процессов";

                    btnAnswer1.Text = "Многозадачность на основе потоков связана с одновременным выполнением частей одной и той же программы";
                    btnAnswer2.Text = "Многозадачность на основе процессов обеспечивает одновременное выполнение программ";
                    btnAnswer3.Text = "Все вышеперечисленное";
                    btnAnswer4.Text = "Ничего из вышеперечисленного";

                    correctAnswer = 3;

                    break;
                case 8:
                    lblQuestion.Text = "Какой из следующих способов преобразует тип в указанный тип в C#?";

                    btnAnswer1.Text = "ToType";
                    btnAnswer2.Text = "ToSbyte";
                    btnAnswer3.Text = "ToSingle";
                    btnAnswer4.Text = "ToString";

                    correctAnswer = 1;

                    break;
                case 9:
                    lblQuestion.Text = "В чем польза try & catch?";

                    btnAnswer1.Text = "Он предотвращает автоматическое завершение работы программы в случаях возникновения исключения";
                    btnAnswer2.Text = "Он используется для ручной обработки исключения";
                    btnAnswer3.Text = "Это помогает исправить ошибки";
                    btnAnswer4.Text = "Все вышеперечисленное";

                    correctAnswer = 4;

                    break;
                case 10:
                    lblQuestion.Text = "Что представляет собой C#?";

                    btnAnswer1.Text = "Структурный язык программирования";
                    btnAnswer2.Text = "Объектно-ориентированный язык программирования";
                    btnAnswer3.Text = "Функциональный язык программирования";
                    btnAnswer4.Text = "Логический язык программирования";

                    correctAnswer = 2;

                    break;
                case 11:
                    lblQuestion.Text = "Boxing – это процесс преобразования типа значения в тип объекта, а unboxing – извлечение типа значения из объекта.";

                    btnAnswer1.Text = "Да";
                    btnAnswer2.Text = "Нет";
                    btnAnswer3.Text = "Не полностью верно";
                    btnAnswer4.Text = "Таких понятий не существует";

                    correctAnswer = 1;

                    break;
                case 12:
                    lblQuestion.Text = "Какое из следующих утверждений является правильным относительно проверки атрибута в C#.NET ?";

                    btnAnswer1.Text = "Атрибут может быть проверен во время выполнения";
                    btnAnswer2.Text = "Атрибут может быть проверен во время разработки";
                    btnAnswer3.Text = "Атрибут может быть проверен во время ссылки";
                    btnAnswer4.Text = "Ничего из вышеперечисленного";

                    correctAnswer = 3;

                    break;
                case 13:
                    lblQuestion.Text = "Какое утверждение верно?";

                    btnAnswer1.Text = "Структура является размерным типом, а класс – ссылочный.";
                    btnAnswer2.Text = "В структуре нельзя определять конструктор.";
                    btnAnswer3.Text = "От структуры так же, как и от класса, можно наследоваться.";
                    btnAnswer4.Text = "Никакое";

                    correctAnswer = 1;

                    break;
                case 14:
                    lblQuestion.Text = "Сколько родительских классов может иметь производный класс?";

                    btnAnswer1.Text = "Не больше трех";
                    btnAnswer2.Text = "Не больше двух";
                    btnAnswer3.Text = "Один";
                    btnAnswer4.Text = "Неограниченное число";

                    correctAnswer = 3;

                    break;
                case 15:
                    lblQuestion.Text = "Какие из модификаторов не может иметь абстрактный класс?";

                    btnAnswer1.Text = "static, internal.";
                    btnAnswer2.Text = "sealed, static.";
                    btnAnswer3.Text = "sealed, internal.";
                    btnAnswer4.Text = "Любые из перечисленных могут";

                    correctAnswer = 2;

                    break;
                case 16:
                    lblQuestion.Text = "Какой из приведенных потоковых методов обеспечивает доступ к консоли ввода в C#.NET ?";

                    btnAnswer1.Text = "Console.In";
                    btnAnswer2.Text = "Console.Out";
                    btnAnswer3.Text = "Console.Error";
                    btnAnswer4.Text = "Все вышеперечисленное";

                    correctAnswer = 1;

                    break;
                case 17:
                    lblQuestion.Text = "Какая конструкция используется для выполнения повторяющихся действий?";

                    btnAnswer1.Text = "if";
                    btnAnswer2.Text = "switch";
                    btnAnswer3.Text = "for";
                    btnAnswer4.Text = "try";

                    correctAnswer = 3;

                    break;
                case 18:
                    lblQuestion.Text = "Атрибуты [Serializable()] проверяются на";

                    btnAnswer1.Text = "время выполнения";
                    btnAnswer2.Text = "время компиляции";
                    btnAnswer3.Text = "время разработки";
                    btnAnswer4.Text = "Ничего из вышеперечисленного\r\n";

                    correctAnswer = 1;

                    break;
                case 19:
                    lblQuestion.Text = "Как объявить массив целых чисел в C#?";

                    btnAnswer1.Text = "int[] array;";
                    btnAnswer2.Text = "array<int>;";
                    btnAnswer3.Text = "int array[];";
                    btnAnswer4.Text = "Array<int> array;";

                    correctAnswer = 1;

                    break;
                case 20:
                    lblQuestion.Text = "Что такое инкапсуляция?";

                    btnAnswer1.Text = "Процесс наследования свойств и методов от одного класса к другому";
                    btnAnswer2.Text = "Способность скрывать детали реализации и предоставлять только необходимый интерфейс";
                    btnAnswer3.Text = "Способность  объектов принимать различные формы";
                    btnAnswer4.Text = "Процесс создания нового объекта";

                    correctAnswer = 2;

                    break;
            }
            #endregion
        }
    }
}
