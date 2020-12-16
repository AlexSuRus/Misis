using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaruselLato
{
    public partial class Form3 : Form
    {
        
        public int value;
        public int Score1 = 0;
        public int Score2 = 0;

        public int tScore1 = 0;
        public int tScore2 = 0;
        public int P1id = 0;
        public int P2id = 0;

        public int P1idEnd = 0;
        public int P2idEnd = 0;

        public Form3()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            MessageBox.Show("Игра «Карусель-лото», За угадывание комбинации a) или б) игрок получает 1 очко; в) – 2 очка; г) – 3 очка; д) – 5 очков; е) – 11 очков; ж) – 17 очков; з) – 35 очков. Наберите 50 очков и победите соперника!");
            MessageBox.Show("Выберете промежуток чисел в данных ячейках. Если вы хотите выбрать одно число впишите его в обе ячейки.");
            MaximizeBox = false;
            ControlBox = false;
            int value = rnd.Next(0, 36);
            ScoreLabel.Text = ("Предыдущее число : " + value);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            value = rnd.Next(0, 36);

            Tick();
            //   P1i = Convert.ToInt16(textBox1.Text);
            //       P2i = Convert.ToInt16(textBox2.Text);
            //  P1idEnd = Convert.ToInt16(textBox3.Text);
            //       P2idEnd = Convert.ToInt16(textBox4.Text);

        }

        public void Tick()
        {
            if (Score1 >= 50)
            {
                MessageBox.Show("Победил игрок номер 1!");
                Application.Exit();
            }
            if (Score1 >= 50)
            {
                MessageBox.Show("Победил игрок номер 2!");
                Application.Exit();
            }
        }

        public void Update()
        {

            Tick();
            if ((IsP1Ready == true)&&(IsP2Ready == true))
            {
                IsP1Ready = false;
                IsP2Ready = false;
                unblock();
                Score1 += tScore1;
                Score2 += tScore2;
                tScore1 = 0;
                tScore2 = 0;
                label2.Text = Convert.ToString(Score1);
                label3.Text = Convert.ToString(Score2);
                int tvalue = value;
                ScoreLabel.Text = ("Предыдущее число: " + Convert.ToString(tvalue));
                value = rnd.Next(0, 36);
            }
        }

        Random rnd = new Random();
        
        bool IsP1Ready = false;
        bool IsP2Ready = false;
        

        private void Backb_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        public void blockP1()
        {
            CNOTC1.Enabled = false;
            b1.Enabled = false;
            c1.Enabled = false;
            g1.Enabled = false;
            d1.Enabled = false;
            e1.Enabled = false;
            j1.Enabled = false;
            textBox1.Enabled = false;
            textBox3.Enabled = false;
            C1CCET.Enabled = false;
            textbox1b.Enabled = false;    
        }
        public void blockP2()
        {
            CNOTC2.Enabled = false;
            b2.Enabled = false;
            c2.Enabled = false;
            g2.Enabled = false;
            d2.Enabled = false;
            e2.Enabled = false;
            j2.Enabled = false;
            textBox2.Enabled = false;
            textBox4.Enabled = false;
            C1CCET2.Enabled = false;
            button2.Enabled = false;
        }
        public void unblock()
        {
            CNOTC1.Enabled = true;
            b1.Enabled = true;
            c1.Enabled = true;
            g1.Enabled = true;
            d1.Enabled = true;
            e1.Enabled = true;
            j1.Enabled = true;
            textBox1.Enabled = true;
            CNOTC2.Enabled = true;
            b2.Enabled = true;
            c2.Enabled = true;
            g2.Enabled = true;
            d2.Enabled = true;
            e2.Enabled = true;
            j2.Enabled = true;
            textBox2.Enabled = true;
            C1CCET.Enabled = true;
            C1CCET2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textbox1b.Enabled = true;
            button2.Enabled = true;
        }

        private void CNOTC1_Click(object sender, EventArgs e)
        {
            if (IsP1Ready == false)
            {
                IsP1Ready = true;
            }
            blockP1();
            if(value%2 !=0)
            tScore1++;
            Update();
            

        }
        private void C1CCET_Click(object sender, EventArgs e)
        {
            if (IsP1Ready == false)
            {
                IsP1Ready = true;
            }
            blockP1();
            if (value % 2 == 0)
                tScore1++;
            Update();
        }
        private void b1_Click(object sender, EventArgs e)
        {
            P1id = Convert.ToInt16(textBox1.Text);
            P1idEnd = Convert.ToInt16(textBox3.Text);
            if (IsP1Ready == false)
            {
                IsP1Ready = true;
            }
            int t = 0;

            for (int i = P1id; i < 36; i += 18)
            {
                if ((P1id == i) && (P1idEnd == i + 17))
                {
                    t++;
                }
            }
            if (t == 0)
            {
                MessageBox.Show("Выбран неправильный диапозон, проверьте пожалуйста числа и выбор кнопки");
            }

            if (t != 0)
            {
                blockP1();
                if ((P1id <= value) && (value <= P1idEnd))
                {

                    tScore1++;
                }
                Update();
            }
            

        }

        private void c1_Click(object sender, EventArgs e)
        {
            P1id = Convert.ToInt16(textBox1.Text);
            P1idEnd = Convert.ToInt16(textBox3.Text);
            if (IsP1Ready == false)
            {
                IsP1Ready = true;
            }
            int t = 0;

            for (int i = P1id; i < 36; i += 12)
            {
                if ((P1id == i) && (P1idEnd == i + 11))
                {
                    t++;
                }
            }
            if (t == 0)
            {
                MessageBox.Show("Выбран неправильный диапозон, проверьте пожалуйста числа и выбор кнопки");
            }

            if (t != 0)
            {
                blockP1();
                if ((P1id <= value) && (value <= P1idEnd))
                {

                    tScore1+=2;
                }
                Update();
            }

        }

        private void g1_Click(object sender, EventArgs e)
        {
            P1id = Convert.ToInt16(textBox1.Text);
            P1idEnd = Convert.ToInt16(textBox3.Text);
            if (IsP1Ready == false)
            {
                IsP1Ready = true;
            }
            int t = 0;

            for (int i = P1id; i < 36; i += 9)
            {
                if ((P1id == i) && (P1idEnd == i + 8))
                {
                    t++;
                }
            }
            if (t == 0)
            {
                MessageBox.Show("Выбран неправильный диапозон, проверьте пожалуйста числа и выбор кнопки");
            }

            if (t != 0)
            {
                blockP1();
                if ((P1id <= value) && (value <= P1idEnd))
                {

                    tScore1 += 3;
                }
                Update();
            }



        }

        private void d1_Click(object sender, EventArgs e)
        {
            P1id = Convert.ToInt16(textBox1.Text);
            P1idEnd = Convert.ToInt16(textBox3.Text);
            if (IsP1Ready == false)
            {
                IsP1Ready = true;
            }
            int t = 0;

            for (int i = P1id; i < 36; i += 6)
            {
                if ((P1id == i) && (P1idEnd == i + 5))
                {
                    t++;
                }
            }
            if (t == 0)
            {
                MessageBox.Show("Выбран неправильный диапозон, проверьте пожалуйста числа и выбор кнопки");
            }

            if (t != 0)
            {
                blockP1();
                if ((P1id <= value) && (value <= P1idEnd))
                {

                    tScore1 += 5;
                }
                Update();
            }


        }

        private void e1_Click(object sender, EventArgs e)
        {
            P1id = Convert.ToInt16(textBox1.Text);
            P1idEnd = Convert.ToInt16(textBox3.Text);
            if (IsP1Ready == false)
            {
                IsP1Ready = true;
            }
            int t = 0;

            for (int i = P1id; i < 36; i += 3)
            {
                if ((P1id == i) && (P1idEnd == i + 2))
                {
                    t++;
                }
            }
            if (t == 0)
            {
                MessageBox.Show("Выбран неправильный диапозон, проверьте пожалуйста числа и выбор кнопки");
            }

            if (t != 0)
            {
                blockP1();
                if ((P1id <= value) && (value <= P1idEnd))
                {

                    tScore1 += 11;
                }
                Update();
            }



        }

        private void j1_Click(object sender, EventArgs e)
        {
            P1id = Convert.ToInt16(textBox1.Text);
            P1idEnd = Convert.ToInt16(textBox3.Text);
            if (IsP1Ready == false)
            {
                IsP1Ready = true;
            }
            int t = 0;

            for (int i = P1id; i < 36; i += 2)
            {
                if ((P1id == i) && (P1idEnd == i + 1))
                {
                    t++;
                }
            }
            if (t == 0)
            {
                MessageBox.Show("Выбран неправильный диапозон, проверьте пожалуйста числа и выбор кнопки");
            }

            if (t != 0)
            {
                blockP1();
                if ((P1id <= value) && (value <= P1idEnd))
                {

                    tScore1 += 17;
                }
                Update();
            }
        }

        private void CNOTC2_Click(object sender, EventArgs e)
        {
            if (IsP2Ready == false)
            {
                IsP2Ready = true;
            }
            blockP2();
            if (value % 2 != 0)
                tScore2++;
            Update();

        }

        private void C1CCET2_Click(object sender, EventArgs e)
        {
            if (IsP2Ready == false)
            {
                IsP2Ready = true;
            }
            blockP2();
            if (value % 2 == 0)
                tScore2++;
            Update();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            P2id = Convert.ToInt16(textBox2.Text);
            P2idEnd = Convert.ToInt16(textBox4.Text);
            if (IsP2Ready == false)
            {
                IsP2Ready = true;
            }
            int t = 0;

            for (int i = P2id; i < 36; i += 18)
            {
                if ((P2id == i) && (P2idEnd == i + 17))
                {
                    t++;
                }
            }
            if (t == 0)
            {
                MessageBox.Show("Выбран неправильный диапозон, проверьте пожалуйста числа и выбор кнопки");
            }

            if (t != 0)
            {
                blockP2();
                if ((P2id <= value) && (value <= P2idEnd))
                {

                    tScore2++;
                }
                Update();
            }

        }

        private void c2_Click(object sender, EventArgs e)
        {
            P2id = Convert.ToInt16(textBox2.Text);
            P2idEnd = Convert.ToInt16(textBox4.Text);
            if (IsP2Ready == false)
            {
                IsP2Ready = true;
            }
            int t = 0;

            for (int i = P2id; i < 36; i += 12)
            {
                if ((P2id == i) && (P2idEnd == i + 11))
                {
                    t++;
                }
            }
            if (t == 0)
            {
                MessageBox.Show("Выбран неправильный диапозон, проверьте пожалуйста числа и выбор кнопки");
            }

            if (t != 0)
            {
                blockP2();
                if ((P2id <= value) && (value <= P2idEnd))
                {

                    tScore2 += 2;
                }
                Update();
            }
        }

        private void g2_Click(object sender, EventArgs e)
        {
            P2id = Convert.ToInt16(textBox2.Text);
            P2idEnd = Convert.ToInt16(textBox4.Text);
            if (IsP2Ready == false)
            {
                IsP2Ready = true;
            }
            int t = 0;

            for (int i = P2id; i < 36; i += 9)
            {
                if ((P2id == i) && (P2idEnd == i + 8))
                {
                    t++;
                }
            }
            if (t == 0)
            {
                MessageBox.Show("Выбран неправильный диапозон, проверьте пожалуйста числа и выбор кнопки");
            }

            if (t != 0)
            {
                blockP2();
                if ((P2id <= value) && (value <= P2idEnd))
                {

                    tScore2 += 3;
                }
                Update();
            }


        }

        private void d2_Click(object sender, EventArgs e)
        {
            P2id = Convert.ToInt16(textBox2.Text);
            P2idEnd = Convert.ToInt16(textBox4.Text);
            if (IsP2Ready == false)
            {
                IsP2Ready = true;
            }
            int t = 0;

            for (int i = P2id; i < 36; i += 6)
            {
                if ((P2id == i) && (P2idEnd == i + 5))
                {
                    t++;
                }
            }
            if (t == 0)
            {
                MessageBox.Show("Выбран неправильный диапозон, проверьте пожалуйста числа и выбор кнопки");
            }

            if (t != 0)
            {
                blockP2();
                if ((P2id <= value) && (value <= P2idEnd))
                {

                    tScore2 += 5;
                }
                Update();
            }


        }

        private void e2_Click(object sender, EventArgs e)
        {
            P2id = Convert.ToInt16(textBox2.Text);
            P2idEnd = Convert.ToInt16(textBox4.Text);
            if (IsP2Ready == false)
            {
                IsP2Ready = true;
            }
            int t = 0;

            for (int i = P2id; i < 36; i += 3)
            {
                if ((P2id == i) && (P2idEnd == i + 2))
                {
                    t++;
                }
            }
            if (t == 0)
            {
                MessageBox.Show("Выбран неправильный диапозон, проверьте пожалуйста числа и выбор кнопки");
            }

            if (t != 0)
            {
                blockP2();
                if ((P2id <= value) && (value <= P2idEnd))
                {

                    tScore2 += 11;
                }
                Update();
            }
        }

        private void j2_Click(object sender, EventArgs e)
        {
            P2id = Convert.ToInt16(textBox2.Text);
            P2idEnd = Convert.ToInt16(textBox4.Text);
            if (IsP2Ready == false)
            {
                IsP2Ready = true;
            }
            int t = 0;

            for (int i = P2id; i < 36; i += 2)
            {
                if ((P2id == i) && (P2idEnd == i + 1))
                {
                    t++;
                }
            }
            if (t == 0)
            {
                MessageBox.Show("Выбран неправильный диапозон, проверьте пожалуйста числа и выбор кнопки");
            }

            if (t != 0)
            {
                blockP2();
                if ((P2id <= value) && (value <= P2idEnd))
                {

                    tScore2 += 17;
                }
                Update();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игра «Карусель-лото», За угадывание комбинации a) или б) игрок получает 1 очко; в) – 2 очка; г) – 3 очка; д) – 5 очков; е) – 11 очков; ж) – 17 очков; з) – 35 очков. Наберите 50 очков и победите соперника!");
            MessageBox.Show("Выберете промежуток чисел в данных ячейках. Если вы хотите выбрать одно число впишите его в обе ячейки.");
        }

        private void textbox1b_Click_1(object sender, EventArgs e)
        {
            P1id = Convert.ToInt16(textBox1.Text);
            P1idEnd = Convert.ToInt16(textBox3.Text);
            if (IsP1Ready == false)
            {
                IsP1Ready = true;
            }
            int t = 0;
            if (P1id == P1idEnd)
            {
                blockP1();
            }
            else
            {
                MessageBox.Show("Выбран неправильный диапозон, проверьте пожалуйста числа и выбор кнопки");
            }

            if (P1id == value)
            {
                tScore1 += 35;
            }
            Update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            P2id = Convert.ToInt16(textBox2.Text);
            P2idEnd = Convert.ToInt16(textBox4.Text);
            if (IsP2Ready == false)
            {
                IsP2Ready = true;
            }
            int t = 0;
            if (P2id == P2idEnd)
            {
                blockP2();
            }
            else
            {
                MessageBox.Show("Выбран неправильный диапозон, проверьте пожалуйста числа и выбор кнопки");
            }

            if (P2id == value)
            {
                tScore2 += 35;
            }
            Update();
        }
    }
}
