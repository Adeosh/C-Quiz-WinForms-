using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace C__Quiz_WinForms_
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
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

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        Point lastPoint;
        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void btnQuiz1_Click(object sender, EventArgs e)
        {
            Quiz1 quiz1 = new Quiz1();
            quiz1.Show();
            this.Hide();
        }

        private void btnQuiz2_Click(object sender, EventArgs e)
        {
            Quiz2 quiz2 = new Quiz2();
            quiz2.Show();
            this.Hide();
        }

        private void btnQuiz3_Click(object sender, EventArgs e)
        {
            Quiz3 quiz3 = new Quiz3();
            quiz3.Show();
            this.Hide();
        }

        private void btnQuiz4_Click(object sender, EventArgs e)
        {
            Quiz4 quiz4 = new Quiz4();
            quiz4.Show();
            this.Hide();
        }

        private void btnQuiz5_Click(object sender, EventArgs e)
        {
            Quiz5 quiz5 = new Quiz5();
            quiz5.Show();
            this.Hide();
        }

        private void btnExtraQuiz_Click(object sender, EventArgs e)
        {
            ExtraQuiz extraQuiz = new ExtraQuiz();
            extraQuiz.Show();
            this.Hide();
        }
    }
}
