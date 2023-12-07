using System;
using System.Drawing;
using System.Windows.Forms;

namespace C__Quiz_WinForms_
{
    public partial class Quiz2 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percenage;
        int totalQuestion;

        public Quiz2()
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

        private void Quiz2_FormClosed(object sender, FormClosedEventArgs e)
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
        private void Quiz2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Quiz2_MouseDown(object sender, MouseEventArgs e)
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
                    lblQuestion.Text = "Процесс определения метода в подклассе, имеющего то же имя и сигнатуру типа, что и метод в его суперклассе, известен как";

                    btnAnswer1.Text = "Скрытие метода";
                    btnAnswer2.Text = "Перегрузка метода";
                    btnAnswer3.Text = "Переопределение метода";
                    btnAnswer4.Text = "Ничего из вышеперечисленного";

                    correctAnswer = 3;

                    break;
                case 2:
                    lblQuestion.Text = "Какие из приведенных модификаторов можно использовать для предотвращения переопределения метода?";

                    btnAnswer1.Text = "sealed";
                    btnAnswer2.Text = "final";
                    btnAnswer3.Text = "constant";
                    btnAnswer4.Text = "static";

                    correctAnswer = 1;

                    break;
                case 3:
                    lblQuestion.Text = "Выберите правильное утверждение из следующего";

                    btnAnswer1.Text = "Мы можем переопределять как виртуальные, так и невиртуальные методы";
                    btnAnswer2.Text = "Статические методы могут быть виртуальным методом";
                    btnAnswer3.Text = "Абстрактные методы могут быть виртуальным методом";
                    btnAnswer4.Text = "При переопределении метода имена и сигнатуры типов переопределяемого метода должны совпадать с виртуальным методом, который переопределяется";

                    correctAnswer = 4;

                    break;
                case 4:
                    lblQuestion.Text = "Что из следующего можно использовать для объявления класса как виртуального?";

                    btnAnswer1.Text = "Мероприятия";
                    btnAnswer2.Text = "Методы";
                    btnAnswer3.Text = "Свойства";
                    btnAnswer4.Text = "Все вышеперечисленное";

                    correctAnswer = 4;

                    break;
                case 5:
                    lblQuestion.Text = "Модификатор, используемый для скрытия методов базового класса, является";

                    btnAnswer1.Text = "Sealed";
                    btnAnswer2.Text = "Override";
                    btnAnswer3.Text = "New";
                    btnAnswer4.Text = "Virtual";

                    correctAnswer = 3;

                    break;
                case 6:
                    lblQuestion.Text = "Выберите правильное утверждение об интерфейсе в C#.NET";

                    btnAnswer1.Text = "К явно реализованному элементу можно получить доступ из экземпляра интерфейса";
                    btnAnswer2.Text = "Интерфейсы автоматически объявляются общедоступными";
                    btnAnswer3.Text = "Все вышеперечисленное";
                    btnAnswer4.Text = "Ничего из вышеперечисленного";

                    correctAnswer = 3;

                    break;
                case 7:
                    lblQuestion.Text = "Выберите правильное утверждение среди следующих";

                    btnAnswer1.Text = "Индексатор является формой свойства и работает так же, как свойство";
                    btnAnswer2.Text = "Индексаторы - это индикаторы местоположения";
                    btnAnswer3.Text = "Индексаторы используются для доступа к объектам класса";
                    btnAnswer4.Text = "Все вышеперечисленное";

                    correctAnswer = 4;

                    break;
                case 8:
                    lblQuestion.Text = "Выберите ключевое слово, которое объявляет индексатор?";

                    btnAnswer1.Text = "this";
                    btnAnswer2.Text = "super";
                    btnAnswer3.Text = "extract";
                    btnAnswer4.Text = "base";

                    correctAnswer = 1;

                    break;
                case 9:
                    lblQuestion.Text = "Выберите оператор / operators, которые используются для доступа к оператору [] в индексаторах?";

                    btnAnswer1.Text = "set";
                    btnAnswer2.Text = "get";
                    btnAnswer3.Text = "Все вышеперечисленное";
                    btnAnswer4.Text = "Ничего из вышеперечисленного";

                    correctAnswer = 3;

                    break;
                case 10:
                    lblQuestion.Text = "Выберите правильное утверждение среди следующих";

                    btnAnswer1.Text = "Объявление индексатором локальной переменной с тем же именем, что и параметры индексатора, является ошибкой";
                    btnAnswer2.Text = "Свойство может быть статическим элементом, тогда как индексатор всегда является элементом экземпляра";
                    btnAnswer3.Text = "Средство доступа get к свойству соответствует методу без параметров, тогда как средство доступа get к индексатору соответствует методу с теми же списками формальных параметров, что и у индексатора";
                    btnAnswer4.Text = "Все вышеперечисленное";

                    correctAnswer = 4;

                    break;
                case 11:
                    lblQuestion.Text = "Каковы из перечисленных ниже преимущества использования индексаторов?";

                    btnAnswer1.Text = "Индексаторы также удобны, поскольку они также могут использовать различные типы индексаторов, таких как int, string и т. Д";
                    btnAnswer2.Text = "Для использования коллекции элементов в больших масштабах мы используем индексаторы, поскольку они используют объекты класса, которые представляют коллекцию в виде массива";
                    btnAnswer3.Text = "Все вышеперечисленное";
                    btnAnswer4.Text = "Ничего из вышеперечисленного";

                    correctAnswer = 3;

                    break;
                case 12:
                    lblQuestion.Text = "Выберите правильное утверждение о свойствах, используемых в C#.NET";

                    btnAnswer1.Text = "Свойства могут использоваться для хранения и извлечения значений в данные-члены класса и из них";
                    btnAnswer2.Text = "Свойства подобны реальным методам, которые работают как элементы данных";
                    btnAnswer3.Text = "Все вышеперечисленное";
                    btnAnswer4.Text = "Ничего из вышеперечисленного";

                    correctAnswer = 3;

                    break;
                case 13:
                    lblQuestion.Text = "Какие из следующих классов поддерживают стандартный протокол HTTP?";

                    btnAnswer1.Text = "HttpWebRequest";
                    btnAnswer2.Text = "HttpWebResponse";
                    btnAnswer3.Text = "Все вышеперечисленное";
                    btnAnswer4.Text = "Ничего из вышеперечисленного";

                    correctAnswer = 4;

                    break;
                case 14:
                    lblQuestion.Text = "Где могут быть объявлены свойства?";

                    btnAnswer1.Text = "Interface";
                    btnAnswer2.Text = "Class";
                    btnAnswer3.Text = "Struct";
                    btnAnswer4.Text = "All of the above";

                    correctAnswer = 4;

                    break;
                case 15:
                    lblQuestion.Text = "Выберите модификаторы, которые можно использовать со свойствами?";

                    btnAnswer1.Text = "Public";
                    btnAnswer2.Text = "Private";
                    btnAnswer3.Text = "Protected";
                    btnAnswer4.Text = "All of the above";

                    correctAnswer = 4;

                    break;
                case 16:
                    lblQuestion.Text = "Выберите правильные утверждения о свойствах только для записи в C#.NET";

                    btnAnswer1.Text = "Полезно для использования в классах, которые хранят конфиденциальную информацию, такую как пароль пользователя";
                    btnAnswer2.Text = "Свойства, которые могут быть установлены только";
                    btnAnswer3.Text = "Однажды установленные свойства и, следовательно, значения не могут быть прочитаны обратно в природе";
                    btnAnswer4.Text = "Все вышеперечисленное";

                    correctAnswer = 4;

                    break;
                case 17:
                    lblQuestion.Text = "Что из перечисленного не является исключением?";

                    btnAnswer1.Text = "Неправильное арифметическое выражение";
                    btnAnswer2.Text = "Переполнение стека";
                    btnAnswer3.Text = "Арифметическое переполнение или недостаточный поток";
                    btnAnswer4.Text = "Ничего из вышеперечисленного";

                    correctAnswer = 1;

                    break;
                case 18:
                    lblQuestion.Text = "Какой из следующих НЕ рассматривается как класс исключений .NET?";

                    btnAnswer1.Text = "StackUnderflow Exception";
                    btnAnswer2.Text = "File Found Exception";
                    btnAnswer3.Text = "Все вышеперечисленное";
                    btnAnswer4.Text = "Ничего из вышеперечисленного";

                    correctAnswer = 3;

                    break;
                case 19:
                    lblQuestion.Text = "Какой из перечисленных ниже объектно-ориентированный способ обработки ошибок во время выполнения?";

                    btnAnswer1.Text = "Exceptions";
                    btnAnswer2.Text = "OnError";
                    btnAnswer3.Text = "HERRESULT";
                    btnAnswer4.Text = "Error codes";

                    correctAnswer = 1;

                    break;
                case 20:
                    lblQuestion.Text = "Выберите правильное утверждение об исключении";

                    btnAnswer1.Text = "Это происходит во время выполнения";
                    btnAnswer2.Text = "Это происходит во время загрузки программы";
                    btnAnswer3.Text = "Это происходит во время своевременной компиляции";
                    btnAnswer4.Text = "Все вышеперечисленное";

                    correctAnswer = 1;

                    break;
            }
            #endregion
        }
    }
}
