using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bugs
{

    public partial class Form1 : Form
    {
        public class Player
        {
            public int Bal = 1000;
            public int b1, b2, b3, b4 = 0;              //ставки
            public double part;
        }
        Player p1 = new Player();
        Player p2 = new Player();
        Player p3 = new Player();
        public bool error;
        public bool blck = true;
        public int rndStep = 5;                         //ширина шага тараканов
        public int num = 1;
        public int summ = 0;
        public Random rnd = new Random();

        public void Stat()                              //обновление счета игроков
        {
            balance1.Text = p1.Bal.ToString();
            balance2.Text = p2.Bal.ToString();
            balance3.Text = p3.Bal.ToString();
        }

        public void Pay()                               //разделение и раздача выигрыша
        {
            int pp1, pp2, pp3, pp4;
            pp1 = (p1.b1 + p2.b1 + p3.b1);
            pp2 = (p1.b2 + p2.b2 + p3.b2);
            pp3 = (p1.b3 + p2.b3 + p3.b3);
            pp4 = (p1.b4 + p2.b4 + p3.b4);
            summ = pp1 + pp2 + pp3 + pp4;
            if (num == 1 && pp1 != 0)
            {
               p1.Bal += summ*p1.b1/pp1;
               p2.Bal += summ*p2.b1/pp1;
               p3.Bal += summ*p3.b1/pp1;
            }
            if (num == 2 && pp2 != 0)
            {
                p1.Bal += (summ*p1.b2 / pp2);
                p2.Bal += (summ*p2.b2 / pp2);
                p3.Bal += (summ*p3.b2 / pp2);
            }
            if (num == 3 && pp3 != 0)
            {
                p1.Bal += (summ*p1.b3 / pp3);
                p2.Bal += (summ*p2.b3 / pp3);
                p3.Bal += (summ*p3.b3 / pp3);
            }
            if (num == 4 && pp4 != 0)
            {
                p1.Bal += (summ*p1.b4 / pp4);
                p2.Bal += (summ*p2.b4 / pp4);
                p3.Bal += (summ*p3.b4 / pp4);
            }
        }

        public void preStart()                          //сброс значений перед запуском
        {
            summ = 0;
            p1.part = 0;
            p2.part = 0;
            p3.part = 0;
            Point pnt = new Point();
            pnt = pictureBox1.Location;
            pnt.X = 12;
            pictureBox1.Location = pnt;
            pnt = pictureBox2.Location;
            pnt.X = 12;
            pictureBox2.Location = pnt;
            pnt = pictureBox3.Location;
            pnt.X = 12;
            pictureBox3.Location = pnt;
            pnt = pictureBox4.Location;
            pnt.X = 12;
            pictureBox4.Location = pnt;

        }

        public int betIn()                              //принятие ставок
        {
            int errCount = 0;
                error = Int32.TryParse(textBox1.Text, out p1.b1);
                if (error == false && textBox1.Text != "") {MessageBox.Show("Неправильно указана ставка"); errCount++;} ;
                if (textBox1.Text == "") { p1.b1 = 0; };

                error = Int32.TryParse(textBox2.Text, out p2.b1);
                if (error == false && textBox2.Text != "") { MessageBox.Show("Неправильно указана ставка"); errCount++; };
                if (textBox2.Text == "") { p2.b2 = 0; };

                error = Int32.TryParse(textBox3.Text, out p3.b1);
                if (error == false && textBox3.Text != "") { MessageBox.Show("Неправильно указана ставка"); errCount++; };
                if (textBox3.Text == "") { p3.b1 = 0; };

                error = Int32.TryParse(textBox6.Text, out p1.b2);
                if (error == false && textBox6.Text != "") { MessageBox.Show("Неправильно указана ставка"); errCount++; };
                if (textBox6.Text == "") { p1.b2 = 0; };

                error = Int32.TryParse(textBox5.Text, out p2.b2);
                if (error == false && textBox5.Text != "") { MessageBox.Show("Неправильно указана ставка"); errCount++; };
                if (textBox5.Text == "") { p2.b2 = 0; };

                error = Int32.TryParse(textBox4.Text, out p3.b2);
                if (error == false && textBox4.Text != "") { MessageBox.Show("Неправильно указана ставка"); errCount++; };
                if (textBox4.Text == "") { p3.b2 = 0; };

                error = Int32.TryParse(textBox12.Text, out p1.b3);
                if (error == false && textBox12.Text != "") { MessageBox.Show("Неправильно указана ставка"); errCount++; };
                if (textBox12.Text == "") { p1.b3 = 0; };

                error = Int32.TryParse(textBox11.Text, out p2.b3);
                if (error == false && textBox11.Text != "") { MessageBox.Show("Неправильно указана ставка"); errCount++; };
                if (textBox11.Text == "") { p2.b3 = 0; };

                error = Int32.TryParse(textBox10.Text, out p3.b3);
                if (error == false && textBox10.Text != "") { MessageBox.Show("Неправильно указана ставка"); errCount++; };
                if (textBox10.Text == "") { p3.b3 = 0; };

                error = Int32.TryParse(textBox9.Text, out p1.b4);
                if (error == false && textBox9.Text != "") { MessageBox.Show("Неправильно указана ставка"); errCount++; };
                if (textBox9.Text == "") { p1.b4 = 0; };

                error = Int32.TryParse(textBox8.Text, out p2.b4);
                if (error == false && textBox8.Text != "") { MessageBox.Show("Неправильно указана ставка"); errCount++; };
                if (textBox8.Text == "") { p2.b4 = 0; };

                error = Int32.TryParse(textBox7.Text, out p3.b4);
                if (error == false && textBox7.Text != "") { MessageBox.Show("Неправильно указана ставка"); errCount++; };
                if (textBox7.Text == "") { p3.b4 = 0; };

                if (p1.Bal > (p1.b1 + p1.b2 + p1.b3 + p1.b4))
                {
                    p1.Bal -= (p1.b1 + p1.b2 + p1.b3 + p1.b4);
                }
                else { MessageBox.Show("У первого игрока недостаточно средств"); errCount++; };

                if (p2.Bal > (p2.b1 + p2.b2 + p2.b3 + p2.b4))
                {
                    p2.Bal -= (p2.b1 + p2.b2 + p2.b3 + p2.b4);
                }
                else { MessageBox.Show("У второго игрока недостаточно средств"); errCount++; };

                if (p3.Bal > (p3.b1 + p3.b2 + p3.b3 + p3.b4))
                {
                    p3.Bal -= (p3.b1 + p3.b2 + p3.b3 + p3.b4);
                }
                else { MessageBox.Show("У третьего игрока недостаточно средств"); errCount++; };

            return errCount;
        }
        public int Winner()                             //присвоение победы
        {
            timer1.Enabled = false;
            MessageBox.Show("Таракан номер "+num+" выиграл!");
            return 0;
        }
        public void Run(PictureBox pict)                //движение тараканов
        {
            Point pnt = new Point();
            pnt = pict.Location;
            pnt.X += rnd.Next(rndStep)+1;
            pict.Location = pnt;
        }
        public int compBugPos()                         //определение лидера
        {
            num = 1;
            int max=pictureBox1.Location.X;
            if (max < pictureBox2.Location.X)
            {
                max = pictureBox2.Location.X;
                num = 2;
            }
            if (max < pictureBox3.Location.X)
            {
                max = pictureBox3.Location.X;
                num = 3;
            }
            if (max < pictureBox4.Location.X)
            {
                max = pictureBox4.Location.X;
                num = 4;
            }
            return max;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (betIn() == 0)
            {
                button1.Enabled = false;
                blck = true;
                Stat();
                timer1.Enabled = true;
                preStart();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (compBugPos() < pictureBox5.Location.X - 10)
            {
                Run(pictureBox1);
                Run(pictureBox2);
                Run(pictureBox3);
                Run(pictureBox4);
            }
            else
            {
                
                Pay();
                Stat();
                Winner();
                button1.Enabled = true;
            };
        }
    }
}
