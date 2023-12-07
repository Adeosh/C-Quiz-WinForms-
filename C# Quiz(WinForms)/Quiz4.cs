using System;
using System.Drawing;
using System.Windows.Forms;

namespace C__Quiz_WinForms_
{
    public partial class Quiz4 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percenage;
        int totalQuestion;

        public Quiz4()
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

        private void Quiz4_FormClosed(object sender, FormClosedEventArgs e)
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
        private void Quiz4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Quiz4_MouseDown(object sender, MouseEventArgs e)
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
                    lblQuestion.Text = "Какое из этих предложений будет выполнено, даже если не будет найдено исключений?";

                    btnAnswer1.Text = "finally";
                    btnAnswer2.Text = "throw";
                    btnAnswer3.Text = "catch";
                    btnAnswer4.Text = "throws";

                    correctAnswer = 1;

                    break;
                case 2:
                    lblQuestion.Text = "Как создать экземпляр класса в C#?";

                    btnAnswer1.Text = "MyClass obj = new MyClass();";
                    btnAnswer2.Text = "MyClass obj = MyClass();";
                    btnAnswer3.Text = "MyClass obj;";
                    btnAnswer4.Text = "obj = new MyClass();";

                    correctAnswer = 1;

                    break;
                case 3:
                    lblQuestion.Text = "Что такое абстрактный класс?";

                    btnAnswer1.Text = "Класс, который может содержать неполностью определенные методы и свойства";
                    btnAnswer2.Text = "Класс, который может содержать только статические методы и свойства";
                    btnAnswer3.Text = "Класс, который может быть только наследником других классов";
                    btnAnswer4.Text = "Класс, который не может иметь экземпляров";

                    correctAnswer = 1;

                    break;
                case 4:
                    lblQuestion.Text = "Выберите инструкции, которые указывают на различия между многозадачностью на основе потоков и многозадачностью на основе процессов";

                    btnAnswer1.Text = "Многозадачность на основе потоков связана с одновременным выполнением частей одной и той же программы";
                    btnAnswer2.Text = "Многозадачность на основе процессов обеспечивает одновременное выполнение программ";
                    btnAnswer3.Text = "Все вышеперечисленное";
                    btnAnswer4.Text = "Ничего из вышеперечисленного";

                    correctAnswer = 3;

                    break;
                case 5:
                    lblQuestion.Text = "При вызове метода какого типа новый созданный поток не начнет выполняться?";

                    btnAnswer1.Text = "New()";
                    btnAnswer2.Text = "Begin()";
                    btnAnswer3.Text = "Start()";
                    btnAnswer4.Text = "Ничего из вышеперечисленного";

                    correctAnswer = 3;

                    break;
                case 6:
                    lblQuestion.Text = "Правильный способ определения значения 6.28 в переменной a, значение которой не может быть изменено?";

                    btnAnswer1.Text = "const float pi = 6.28F";
                    btnAnswer2.Text = "#define a 6.28F";
                    btnAnswer3.Text = "pi = 6.28F";
                    btnAnswer4.Text = "Ничего из вышеперечисленного";

                    correctAnswer = 1;

                    break;
                case 7:
                    lblQuestion.Text = "Каков размер типа данных Char?";

                    btnAnswer1.Text = "20 bit";
                    btnAnswer2.Text = "8 bit";
                    btnAnswer3.Text = "16 bit";
                    btnAnswer4.Text = "12 bit";

                    correctAnswer = 3;

                    break;
                case 8:
                    lblQuestion.Text = "Выберите два типа потоков, упомянутых в концепции многопоточности";

                    btnAnswer1.Text = "background";
                    btnAnswer2.Text = "foreground";
                    btnAnswer3.Text = "Все вышеперечисленное";
                    btnAnswer4.Text = "Ничего из вышеперечисленного";

                    correctAnswer = 3;

                    break;
                case 9:
                    lblQuestion.Text = "За одним блоком попыток должен следовать какой из этих?";

                    btnAnswer1.Text = "catch";
                    btnAnswer2.Text = "finally";
                    btnAnswer3.Text = "Все вышеперечисленное";
                    btnAnswer4.Text = "Ничего из вышеперечисленного";

                    correctAnswer = 3;

                    break;
                case 10:
                    lblQuestion.Text = "Какие из приведенных потоковых методов предоставляют доступ к консоли вывода по умолчанию в C#.NET ?";

                    btnAnswer1.Text = "Console.Error";
                    btnAnswer2.Text = "Console.In";
                    btnAnswer3.Text = "Console.Out";
                    btnAnswer4.Text = "Все вышеперечисленное";

                    correctAnswer = 3;

                    break;
                case 11:
                    lblQuestion.Text = "Выберите удобное объявление и инициализацию числа с плавающей запятой";

                    btnAnswer1.Text = "float somevariable = (Decimal)12.502D";
                    btnAnswer2.Text = "float somevariable = 12.502D";
                    btnAnswer3.Text = "float somevariable = (Double) 12.502D";
                    btnAnswer4.Text = "float somevariable = (float) 12.502D";

                    correctAnswer = 4;

                    break;
                case 12:
                    lblQuestion.Text = "Какой из этих методов класса Thread используется для приостановки потока на определенный период времени?";

                    btnAnswer1.Text = "stop()";
                    btnAnswer2.Text = "suspend()";
                    btnAnswer3.Text = "terminate()";
                    btnAnswer4.Text = "sleep()";

                    correctAnswer = 4;

                    break;
                case 13:
                    lblQuestion.Text = "Какое ключевое слово используется для использования функций синхронизации, определенных классом Monitor ?";

                    btnAnswer1.Text = "locked";
                    btnAnswer2.Text = "Monitor";
                    btnAnswer3.Text = "synchronized";
                    btnAnswer4.Text = "lock";

                    correctAnswer = 4;

                    break;
                case 14:
                    lblQuestion.Text = "Какой из перечисленных ниже параметров не может быть целевым для пользовательского атрибута?";

                    btnAnswer1.Text = "Namespace";
                    btnAnswer2.Text = "Interface";
                    btnAnswer3.Text = "Event";
                    btnAnswer4.Text = "Enum";

                    correctAnswer = 1;

                    break;
                case 15:
                    lblQuestion.Text = "Выберите правильный вариант среди следующих индексаторов, который корректно позволяет индексировать так же, как массив?";

                    btnAnswer1.Text = "interface";
                    btnAnswer2.Text = "class";
                    btnAnswer3.Text = "Все вышеперечисленное";
                    btnAnswer4.Text = "Ничего из вышеперечисленного";

                    correctAnswer = 3;

                    break;
                case 16:
                    lblQuestion.Text = "Какое из этих утверждений неверно?";

                    btnAnswer1.Text = "Два потока в C# могут иметь одинаковый приоритет";
                    btnAnswer2.Text = "Поток может существовать только в двух состояниях: запущенном и заблокированном";
                    btnAnswer3.Text = "Все вышеперечисленное";
                    btnAnswer4.Text = "Ничего из вышеперечисленного";

                    correctAnswer = 2;

                    break;
                case 17:
                    lblQuestion.Text = "Какой метод вызывается, когда выполнение потока временно заблокировано?";

                    btnAnswer1.Text = "Wait()";
                    btnAnswer2.Text = "Pulse()";
                    btnAnswer3.Text = "PulseAll()";
                    btnAnswer4.Text = "Ничего из вышеперечисленного";

                    correctAnswer = 1;

                    break;
                case 18:
                    lblQuestion.Text = "Что такое семафор?";

                    btnAnswer1.Text = "Используйте счетчик для контроля доступа к общему ресурсу";
                    btnAnswer2.Text = "Предоставьте нескольким потокам доступ к общему ресурсу одновременно";
                    btnAnswer3.Text = "Полезно при синхронизации коллекции ресурсов";
                    btnAnswer4.Text = "Все вышеперечисленное";

                    correctAnswer = 4;

                    break;
                case 19:
                    lblQuestion.Text = "Что такое мьютекс?";

                    btnAnswer1.Text = "Помогает в совместном использовании ресурса, который может использоваться одним потоком только по одному разу за раз";
                    btnAnswer2.Text = "Взаимоисключающий объект синхронизации";
                    btnAnswer3.Text = "Все вышеперечисленное";
                    btnAnswer4.Text = "Ничего из вышеперечисленного";

                    correctAnswer = 3;

                    break;
                case 20:
                    lblQuestion.Text = "Что такое синхронизация по отношению к потоку?";

                    btnAnswer1.Text = "Это метод, который позволяет многим потокам получать доступ к любой информации, которая требуется";
                    btnAnswer2.Text = "Это процесс обработки ситуаций, когда двум или более потокам требуется доступ к общему ресурсу";
                    btnAnswer3.Text = "Это процесс, с помощью которого многие потоки могут одновременно получать доступ к одному и тому же общему ресурсу";
                    btnAnswer4.Text = "Это процесс, с помощью которого метод может получать доступ ко многим различным потокам одновременно";

                    correctAnswer = 2;

                    break;
            }
            #endregion
        }
    }
}
