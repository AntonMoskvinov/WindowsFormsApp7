using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Lesson_Animation
{
    public partial class Form1 : Form
    {
        Graphics gr; //объявляем объект - графику, на которой будем рисовать
        Pen p; //объявляем объект - карандаш, которым будем рисовать контур
        SolidBrush fon; //объявляем объект - заливки, для заливки соответственно фона
        SolidBrush fig; //и внутренности рисуемой фигуры
        int rad; // переменная для хранения радиуса рисуемых кругов
        Random rand; // объект, для получения случайных чисел
        public Form1()
        {
            InitializeComponent();
        }
        //опишем функцию, которая будет рисовать круг по координатам его центра
        void DrawCircle(int x, int y)
        {
            int xc, yc;
            xc = x - rad;
            yc = y - rad;
            gr.FillEllipse(fig, xc, yc, rad, rad);
            gr.DrawEllipse(p, xc, yc, rad, rad);
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            gr = pictureBox1.CreateGraphics(); //инициализируем объект типа графики
                                               // привязав к PictureBox
            p = new Pen(Color.Lime); // задали цвет для карандаша
            fon = new SolidBrush(Color.Black); // и для заливки
            fig = new SolidBrush(Color.Red);
            rad = 60; //задали радиус для круга
            rand = new Random(); //инициализируем объект для рандомных чисел
            gr.FillRectangle(fon, 0, 0, pictureBox1.Width, pictureBox1.Height); 
            int x, y;
            for (int i = 0; i < 15; i++)
            {
                x = rand.Next(pictureBox1.Width);
                y = rand.Next(pictureBox1.Height);
                DrawCircle(x, y);
            }
            timer1.Enabled = true; ,
                                   
            
        }
       
       
    private void timer1_Tick(object sender, EventArgs e)
        {
            
            gr.FillRectangle(fon, 0, 0, pictureBox1.Width, pictureBox1.Height);
           
            int x, y;
            for (int i = 0; i < 15; i++)
            {
                x = rand.Next(pictureBox1.Width);
                y = rand.Next(pictureBox1.Height);
                DrawCircle(x, y);
            }
        }
    }
}