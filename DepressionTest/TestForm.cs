using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace DepressionTest
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        // Таблица ответов интерпретации
        double[,] tableOfAnswers = new double[20, 6]
        {
            //0-тревожность 1- Депрессия
            { 1, -1.58, -1.45, -0.41, 0.7, 1.46 },
            { 0, -1.33, -0.44, 1.18, 1.31, 0.87 },
            { 1, -1.51, -1.53, -0.34, 0.58, 1.4 },
            { 0, -1.08, -1.3, -0.6, 0.37, 1.44 },
            { 1, -1.45, -1.26, -1, 0, 0.83 },
            { 1, -1.38, -1.62, -0.22, 0.32, 0.75 },
            { 1, -1.3, -1.5, -0.15, 0.8, 1.22 },
            { 0, -1.6, -1.34, -0.4, 0.6, 0.88 },
            { 0, -1.11, 0, 0.54, 1.22, 0.47 },
            { 0, -0.9, -1.32, -0.41, 0.41, 1.2 },
            { 0, -1.19, -0.2, 1, 1.04, 0.4 },
            { 1, -1.34, -1.34, -0.5, 0.3, 0.72 },
            { 0, -0.78, -1.48, -1.38, 0.11, 0.48 },
            { 0, -1.26, -0.93, -0.4, 0.34, 1.24 },
            { 1, -1.2, -1.23, -0.36, 0.56, 0.2 },
            { 1, -1.08, -1.08, -1.18, 0, 0.46 },
            { 0, -1.23, -0.74, 0, 0.37, 0.63 },
            { 1, -1.2, -1.26, -0.37, 0.21, 0.42 },
            { 0, -0.92, -0.36, 0.28, 0.56, 0.1 },
            { 1, -1.08, 0.54, -0.1, 0.25, 0.32 }
        };

        //Список вопросов
        private string[] questions = new string[20]
        {
            "1. Замечаете ли Вы, что стали более медлительны и вялы, что нет прежней энергичности? ",
            "2. Вам трудно бывает заснуть, если Вас что-нибудь тревожит? ",
            "3. Чувствуете ли Вы себя подавленным и угнетенным? ",
            "4. Бывает ли у Вас ощущение какого-либо беспокойства (как будто что-то должно случиться), хотя особых причин нет?",
            "5. Замечаете ли Вы, что сейчас испытываете меньшую потребность в дружбе и ласке, чем раньше?",
            "6. Приходит ли Вам мысль, что в Вашей жизни мало радости и счастья?",
            "7. Замечаете ли Вы, что стали каким-то безразличным, нет прежних интересов и увлечений?",
            "8. У Вас бывают периоды такого беспокойства, что Вы даже не можете усидеть на месте? ",
            "9. Ожидание Вас тревожит и нервирует? ",
            "10. У Вас бывают кошмарные сновидения? ",
            "11. Вы испытываете тревогу и беспокойство за кого-нибудь или за что-нибудь?",
            "12. Бывает ли у Вас чувство, что к Вам относятся безразлично, никто не стремится Вас понять и посочувствовать Вам, и Вы ощущаете себя одиноким (одинокой)?",
            "13. Вы обращали внимание на то, что руки или ноги часто находятся у Вас в беспокойном движении?",
            "14. Чувствуете ли Вы у себя нетерпеливость, непоседливость или суетливость? ",
            "15. Вам часто хочется побыть одному? ",
            "16. Вы замечаете, что Ваши близкие относятся к Вам равнодушно или даже неприязненно? ",
            "17. Вы чувствуете себя скованно и неуверенно в обществе? ",
            "18. Приходят ли Вам мысли, что Ваши подруги (друзья) или близкие более счастливы, чем Вы?",
            "19. Прежде, чем принять решение, Вы долго колеблетесь? ",
            "20. У Вас возникает чувство, что во многих неприятностях виноваты Вы сами? "
        };

        

        // Переменные для движения окна
        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPoint;

        //Переменная Вопроса
        int numberOfQuestion = 0;

        //Массив интерпетирумых результатов
        private double[] depressionResult = new double[10];
        private double[] anexityResult = new double[10];

        //Переменные для таблицы резульатов
        private int anexityNum;
        private int depressionNum;

        //Переменная изменяемого ответа
        private double changebleInterpretationAnswer;

        private void ResetButton()
        {
            guna2Button2.Checked = false;
            guna2Button3.Checked = false;
            guna2Button4.Checked = false;
            guna2Button5.Checked = false;
            guna2Button6.Checked = false;
            iconButton1.Enabled = false;
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }


        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            if (numberOfQuestion > 0)
            {
                if (tableOfAnswers[numberOfQuestion - 1, 0] == 0)
                {
                    anexityNum--;
                }

                else
                {
                    depressionNum--;
                }

                numberOfQuestion--;
                LabelQuestion.Text = questions[numberOfQuestion];
            }
            else
            {
            }
        }

        private void iconButton1_Click_2(object sender, EventArgs e)
        {
            if (numberOfQuestion < questions.Length - 1)
            {
                if (tableOfAnswers[numberOfQuestion, 0] == 1)
                {
                    depressionResult[depressionNum] = changebleInterpretationAnswer;
                    
                    depressionNum++;
                }

                else
                {
                    anexityResult[anexityNum] = changebleInterpretationAnswer;
                    
                    anexityNum++;
                }


                numberOfQuestion++;
                ResetButton();
                LabelQuestion.Text = questions[numberOfQuestion];
            }
            else
            {
                depressionResult[depressionNum] = changebleInterpretationAnswer;
               
                Results.DepressionResult = SumArray(depressionResult);
                Results.AnexityResult = SumArray(anexityResult);
                ResultForm resultForm = new ResultForm();
                Hide();
                resultForm.Show();
            }
        }


        private double ResultIntepretation(int buttonNum)
        {
            if (tableOfAnswers[numberOfQuestion, 0] == 0)
            {
                return tableOfAnswers[numberOfQuestion, buttonNum];
            }
            else
            {
                return tableOfAnswers[numberOfQuestion, buttonNum];
            }
        }

        private void guna2Button2_CheckedChanged(object sender, EventArgs e)
        {
            changebleInterpretationAnswer = ResultIntepretation(1);
            iconButton1.Enabled = true;
        }

        private void guna2Button3_CheckedChanged(object sender, EventArgs e)
        {
            changebleInterpretationAnswer = ResultIntepretation(2);
            iconButton1.Enabled = true;
        }

        private void guna2Button4_CheckedChanged(object sender, EventArgs e)
        {
            changebleInterpretationAnswer = ResultIntepretation(3);
            iconButton1.Enabled = true;
        }

        private void guna2Button5_CheckedChanged(object sender, EventArgs e)
        {
            changebleInterpretationAnswer = ResultIntepretation(4);
            iconButton1.Enabled = true;
        }

        private void guna2Button6_CheckedChanged(object sender, EventArgs e)
        {
            changebleInterpretationAnswer = ResultIntepretation(5);
            iconButton1.Enabled = true;
        }

        private double SumArray(double[] array)
        {
            double sum = 0;
            foreach (double value in array)
            {
                sum += value;
            }

            return sum;
        }
    }
}