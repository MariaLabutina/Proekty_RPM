using System;
using System.Text;
using System.Windows.Forms;

namespace Redactor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            openFileDialog1.FileName = @"data\Text2.txt";
                openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";

        }

        private void открытьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName == String.Empty) return;
            // Чтение текстового файла
            try
            {
                var Читатель = new System.IO.StreamReader(
                openFileDialog1.FileName, Encoding.GetEncoding(1251));
                textBox1.Text = Читатель.ReadToEnd();
                Читатель.Close();
            }
            catch (System.IO.FileNotFoundException Ситуация)
            {
                MessageBox.Show(Ситуация.Message + "\nНет такого файла",
                         "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception Ситуация)
            { // отчет о других ошибках
                MessageBox.Show(Ситуация.Message,
                     "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = openFileDialog1.FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var Писатель = new System.IO.StreamWriter(
                    saveFileDialog1.FileName, false,
                                        System.Text.Encoding.GetEncoding(1251));
                    Писатель.Write(textBox1.Text);
                    Писатель.Close();
                }
                catch (Exception Ситуация)
                { // отчет о других ошибках
                    MessageBox.Show(Ситуация.Message,
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


