using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        static int n = 3;
        int[,] arr = new int[n, n];
        private void button1_Click(object sender, EventArgs e)
        {
            //int[,] arr = { { 0, 9, 2},  { 9, 7, 6},  { 2, 6, 1}  }; // главная
            //int[,] arr = { { 5, 3, 1},  { 4, 2, 3},  { 3, 4, 5}  }; // побочная
            //int[,] arr = { { 0, 9, 2},  { 9, 7, 9},  { 2, 9, 0}  }; // главная и побочная
            label1.Text = null;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = rnd.Next(10);
                    label1.Text += String.Format($"{arr[i,j],-5}");
                }
                label1.Text += "\r\n";
            }
            bool gl = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i, j] != arr[j, i])
                        gl = false;
                }
            }
            bool pb = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i, j] != arr[n-1-j, n-1-i])
                        pb = false;
                }
            }
            if (gl || pb)
            {
                label2.Text = "Симметрична относительно:\r\n";
                if (gl && pb)
                    label2.Text += "главной и побочной";
                else if (gl)
                    label2.Text += "главной";
                else if (pb)
                    label2.Text += "побочной";
            }
            else
                label2.Text = "Не симметрична ";
        }
    }
}
