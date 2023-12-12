using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MelehovAG.Sprint6.Task3.V1.Lib;

namespace Tyuiu.MelehovAG.Sprint6.Task3.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonHelp_SDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ПКТБ-23-1 Мелехов Алексей Григорьевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_SDA_Click(object sender, EventArgs e)
        {
            try
            {

                string strLine;

                int[,] valueArray;
                valueArray = new int[4, 4];
                int[,] array = { { 25, 20, 28, 2, 6 },
                             { 19, 9,  18, -7, 24},
                             { 21, 16, 5, -7, -8},
                             { 30, -13, 1, -15, 2 },
                             { 31, 9, -3, -9, -18 } };
                valueArray = ds.Calculate(array);

                for (int i = 0; i < 5; i++)
                {
                    this.dataGridViewFunction_SDA.Rows.Add(Convert.ToString(valueArray[i, 0]), Convert.ToString(valueArray[i, 1]), Convert.ToString(valueArray[i, 2]), Convert.ToString(valueArray[i, 3]), Convert.ToString(valueArray[i, 4]));
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
