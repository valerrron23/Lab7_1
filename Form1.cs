using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab7_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            file1.Filter = "(*.jpg)|*.jpg";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            // создаем переменную fname строкового типa
            string fname;
            // открываем Проводник
            file1.ShowDialog();
            // используем переменную для хранения имени выбранного файла
            fname = file1.FileName;
            // загружаем файл в элемент PictureBox
            pct.Image = Image.FromFile(fname);
            textBox1.Text = System.IO.Path.GetFileNameWithoutExtension($"{fname}");
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            string fname_safe;
            fname_safe = file1.SafeFileName;
            save1.FileName = fname_safe;
            save1.ShowDialog();
            pct.Image.Save(save1.FileName);
        }
    }
}
