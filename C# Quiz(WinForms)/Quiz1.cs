using System;
using System.Drawing;
using System.Windows.Forms;

namespace C__Quiz_WinForms_
{
    public partial class Quiz1 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percenage;
        int totalQuestion;

        public Quiz1()
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

        private void Quiz1_FormClosed(object sender, FormClosedEventArgs e)
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
        private void Quiz1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Quiz1_MouseDown(object sender, MouseEventArgs e)
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
                    lblQuestion.Text = "Какой из следующих операторов возвращает тип классов в C#?";

                    btnAnswer1.Text = "*";
                    btnAnswer2.Text = "$";
                    btnAnswer3.Text = "typeof";
                    btnAnswer4.Text = "sizeof";

                    correctAnswer = 3;

                    break;
                case 2:
                    lblQuestion.Text = "Что из нижеперечисленного не может иметь модификатор virtual";

                    btnAnswer1.Text = "Свойства";
                    btnAnswer2.Text = "Поля";
                    btnAnswer3.Text = "Индескаторы";
                    btnAnswer4.Text = "Методы";

                    correctAnswer = 2;

                    break;
                case 3:
                    lblQuestion.Text = "Когда используют ключевое слово value?";

                    btnAnswer1.Text = "Для получения ссылки на значение, которое присваивается свйосвту.";
                    btnAnswer2.Text = "Для передачи значений в базовый конструктор.";
                    btnAnswer3.Text = "Для получения ссылки на текущий экземпляр класса.";
                    btnAnswer4.Text = "Для обобщения входных параметров методов";

                    correctAnswer = 1;

                    break;
                case 4:
                    lblQuestion.Text = "Объявлен кортеж: var tuple = (5, 10).Как обратиться к значению 5?";

                    btnAnswer1.Text = "tuple[0]";
                    btnAnswer2.Text = "tuple.first";
                    btnAnswer3.Text = "tuple.5";
                    btnAnswer4.Text = "tuple.Item1";

                    correctAnswer = 4;

                    break;
                case 5:
                    lblQuestion.Text = "Существует ли возможность отказатсья от реализации абстрактного класса в классе наследнике?";

                    btnAnswer1.Text = "Да, достаточно не реализововывать ненужные методы и свйоства.";
                    btnAnswer2.Text = "Да, если пометить класс-наследник как абстрактный.";
                    btnAnswer3.Text = "Да если пометить класс-наследник атрибутом.";
                    btnAnswer4.Text = "Нет, невозможно отказаться от реализации абстрактного класса.";

                    correctAnswer = 2;

                    break;
                case 6:
                    lblQuestion.Text = "Какая функция корректно сравнивает две подстроки?";

                    btnAnswer1.Text = "String.Check('hi', 'hello');";
                    btnAnswer2.Text = "String.Compare('hi', 'hello');";
                    btnAnswer3.Text = "String.Match('hi', 'hello');";
                    btnAnswer4.Text = "String.Equal('hi', 'hello');";

                    correctAnswer = 2;

                    break;
                case 7:
                    lblQuestion.Text = "Что делает try-catch?";

                    btnAnswer1.Text = "Работает с файлами";
                    btnAnswer2.Text = "Работает с базой данных";
                    btnAnswer3.Text = "Работает с классами";
                    btnAnswer4.Text = "Работает с исключениями";

                    correctAnswer = 4;

                    break;
                case 8:
                    lblQuestion.Text = "Какие типы переменных существуют?";

                    btnAnswer1.Text = "int, char, bool, float, double";
                    btnAnswer2.Text = "int, char, bool, float, double, uint, short";
                    btnAnswer3.Text = "Ни один из них";
                    btnAnswer4.Text = "Все перечисленные";

                    correctAnswer = 4;

                    break;
                case 9:
                    lblQuestion.Text = "Где правильно создана переменная?";

                    btnAnswer1.Text = "x = 0;";
                    btnAnswer2.Text = "int num = '1';";
                    btnAnswer3.Text = "float big_num = 23.2234;";
                    btnAnswer4.Text = "char symbol = 'A';";

                    correctAnswer = 4;

                    break;
                case 10:
                    lblQuestion.Text = "Какие циклы существуют в языке C#?";

                    btnAnswer1.Text = "for, while, do while, foreach";
                    btnAnswer2.Text = "for, while";
                    btnAnswer3.Text = "for, while, do while";
                    btnAnswer4.Text = "for, while, foreach";

                    correctAnswer = 1;

                    break;
                case 11:
                    lblQuestion.Text = "Что такое перегрузка методов?";

                    btnAnswer1.Text = "Передача слишком больших данных в функцию";
                    btnAnswer2.Text = "Передача слишком большого файла через return";
                    btnAnswer3.Text = "Использование одного имени для разных методов";
                    btnAnswer4.Text = "Такого меода не существует";

                    correctAnswer = 3;

                    break;
                case 12:
                    lblQuestion.Text = "При каком условии результат будет равен значению true?" +
                        "int a = 1, b = 5; bool some = false;";

                    btnAnswer1.Text = "(some && a != 2) || b > 5";
                    btnAnswer2.Text = "(b <= 5 || a == 3) && some";
                    btnAnswer3.Text = "(b != 5 || a == 3) || (!some && a > 1)";
                    btnAnswer4.Text = "(b > 5 && a <= 3) || (!some || a < 1)";

                    correctAnswer = 4;

                    break;
                case 13:
                    lblQuestion.Text = "В чем отличие между break и continue?";

                    btnAnswer1.Text = "Нет отличий";
                    btnAnswer2.Text = "continue работает только в циклах, break дополнительно в методах";
                    btnAnswer3.Text = "break используется в switch case, а continue в циклах";
                    btnAnswer4.Text = "continue пропускает итерацию, break выходит из цикла";

                    correctAnswer = 4;

                    break;
                case 14:
                    lblQuestion.Text = "Где правильно создан массив?";

                    btnAnswer1.Text = "int arr[] = {2, 5};";
                    btnAnswer2.Text = "int arr = [2, 5];";
                    btnAnswer3.Text = "int[] arr = new Array [2, 5];";
                    btnAnswer4.Text = "int[] arr = new int [2] {2, 5};";

                    correctAnswer = 4;

                    break;
                case 15:
                    lblQuestion.Text = "В чём разница между типами int и System.Int32?";

                    btnAnswer1.Text = "Разница в размере типа";
                    btnAnswer2.Text = "Разница в использовании на уровне CIL";
                    btnAnswer3.Text = "Разница в месте хранения";
                    btnAnswer4.Text = "Разница отсутсвует";

                    correctAnswer = 4;

                    break;
                case 16:
                    lblQuestion.Text = "Многомерный массив в C# это?";

                    btnAnswer1.Text = "В C# нет многомерных массивов";
                    btnAnswer2.Text = "int[][]";
                    btnAnswer3.Text = "int[]";
                    btnAnswer4.Text = "int[,]";

                    correctAnswer = 4;

                    break;
                case 17:
                    lblQuestion.Text = "Где хранятся экземпляры типов значений?";

                    btnAnswer1.Text = "Хранятся на диске";
                    btnAnswer2.Text = "Хранятся в управляемой куче";
                    btnAnswer3.Text = "Могут храниться в управляемой куче и на стеке";
                    btnAnswer4.Text = "Хранятся на стеке";

                    correctAnswer = 3;

                    break;
                case 18:
                    lblQuestion.Text = "Какой способ выброса исключения является корректным?";

                    btnAnswer1.Text = "throw new Exception()";
                    btnAnswer2.Text = "throw Exception()";
                    btnAnswer3.Text = "call Exception()";
                    btnAnswer4.Text = "new Exception()";

                    correctAnswer = 1;

                    break;
                case 19:
                    lblQuestion.Text = "Что выведет строка Console.WriteLine($\"{0.12345f:F3}\")?";

                    btnAnswer1.Text = "Выведет 0.12345";
                    btnAnswer2.Text = "Выведет 0.12345 на новой строке";
                    btnAnswer3.Text = "Выведет 0.123";
                    btnAnswer4.Text = "Выведет 0.123 на новой строке";

                    correctAnswer = 3;

                    break;
                case 20:
                    lblQuestion.Text = "Boxing – это процесс преобразования типа значения в тип объекта, а unboxing – извлечение типа значения из объекта.";

                    btnAnswer1.Text = "Да";
                    btnAnswer2.Text = "Нет";
                    btnAnswer3.Text = "Не полностью верно";
                    btnAnswer4.Text = "Таких понятий не существует";

                    correctAnswer = 1;

                    break;
            }
        }
    }
}
