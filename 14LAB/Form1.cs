using System.Drawing;
using ClassLibrary15;

namespace _14LAB
{
    public partial class Form1 : Form
    {
        static int n = 10;
        int i, j, nMax;
        int[] a = new int[n];
        int[] h = new int[n];
        double[] b = new double[n];
        double max;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Введите длину основания", "ai: ", "1"));
                listBox1.Items.Add(Convert.ToString(i + 1) + ") " + Convert.ToString(a[i]));

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            for (i = 0; i < n; i++)
            {
                h[i] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Введите длину высоты", "hi: ", "1"));
                listBox2.Items.Add(Convert.ToString(i + 1) + ") " + Convert.ToString(h[i]));

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            for (i = 0; i < n; i++)
            {
                b[i] = ClassLibrary15.Class1.area(a[i], h[i]);
                listBox3.Items.Add(Convert.ToString(i + 1) + ") " + Convert.ToString(b[i]));
            }

            max = b[0];
            for (i = 0; i < n; i++)
            {
                if (b[i] > max)
                {
                    max = b[i];
                    nMax = i;
                }
            }
            MessageBox.Show(
                "Треугольник №" + Convert.ToString(nMax + 1) + " имеет наибольшую площадь (его площадь: " + Convert.ToString(max) + ")",
                "Результат",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
        }
       /* static double area(int a, int h)
        {
            return (0.5*a*h);
        }
       */
    }
}