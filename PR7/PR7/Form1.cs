using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace PR7
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        private void s(object sender, EventArgs e)
        {

        }


        private void открытьCtrOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenDLG = new OpenFileDialog();
            if (OpenDLG.ShowDialog() == DialogResult.OK)
            {
                StreamReader Reader = new StreamReader(OpenDLG.FileName, Encoding.Default);
                richTextBox1.Text = Reader.ReadToEnd();
                Reader.Close();
            }
            OpenDLG.Dispose();
        }



        private void сохранитьCtrSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog SaveDLG = new OpenFileDialog();
            if (SaveDLG.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Writer = new StreamWriter(SaveDLG.FileName);

                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    Writer.WriteLine((string)listBox2.Items[i]);
                }
                Writer.Close();
            }
            SaveDLG.Dispose();
        }



        private void выходCtrXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            listBox1.BeginUpdate();
            string[] Strings = richTextBox1.Text.Split(new char[] { '\n', '\t', ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in Strings)
            {
                string Str = s.Trim();
                if (Str == String.Empty) continue;
                if (radioButton1.Checked) listBox1.Items.Add(Str);
                if (radioButton2.Checked)
                {
                    if (Regex.IsMatch(Str, @"\d")) listBox1.Items.Add(Str);
                }
                if (radioButton3.Checked)
                {
                    if (Regex.IsMatch(Str, @"\w+@\w+\.\w+")) listBox1.Items.Add(Str);
                }
            }
            listBox1.EndUpdate();
        }



        private void button14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void button13_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            richTextBox1.Clear();
            textBox1.Clear();
            radioButton1.Checked = true;
            checkBox1.Checked = true;
            checkBox2.Checked = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }



        private void button12_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();

            string Find = textBox1.Text;

            if (checkBox1.Checked)
            {
                foreach (string String in listBox1.Items)
                {
                    if (String.Contains(Find)) listBox3.Items.Add(String);
                }
            }

            if (checkBox2.Checked)
            {
                foreach (string String in listBox2.Items)
                {
                    if (String.Contains(Find)) listBox3.Items.Add(String);
                }
            }





        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 AddRec = new Form2();
            AddRec.Owner = this;
            AddRec.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
                DeleteSelectedStrings(listBox1);
            DeleteSelectedStrings(listBox2);

        }

        public void DeleteSelectedStrings(ListBox listBox)
        {
            for (int i = listBox.Items.Count - 1; i>=0; i-- )
            {
                if(listBox.GetSelected(i)) listBox.Items.RemoveAt(i);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.AddRange(listBox1.Items);
            listBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(listBox2.Items);
            listBox2.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.BeginUpdate();
            foreach(object Item in listBox1.SelectedItems)
            {
                listBox2.Items.Add(Item);
            }
            listBox2.EndUpdate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.BeginUpdate();
            foreach (object Item in listBox2.SelectedItems)
            {
                listBox1.Items.Add(Item);
            }
            listBox1.EndUpdate();
        }
        public void Puzur()
        {
                object temp;
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    for (int j = i + 1; j < listBox1.Items.Count; j++)
                    {
                        if (((string)(listBox1.Items[i])).Length > ((string)(listBox1.Items[j])).Length)
                        {
                            temp = listBox1.Items[i];
                            listBox1.Items[i] = listBox1.Items[j];
                            listBox1.Items[j] = temp;
                        }
                    }
                }
        }
        public void Puzur1()
        {
            object temp;
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                for (int j = i + 1; j < listBox2.Items.Count; j++)
                {
                    if (((string)(listBox2.Items[i])).Length > ((string)(listBox2.Items[j])).Length)
                    {
                        temp = listBox2.Items[i];
                        listBox2.Items[i] = listBox2.Items[j];
                        listBox2.Items[j] = temp;
                    }
                }
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            List<object> m = new List<object>();
            if (comboBox1.SelectedIndex ==0)
            { listBox1.Sorted = true; }
            else if(comboBox1.SelectedIndex == 1)
            {
                for(int i=0; i<listBox1.Items.Count;i++)
                {
                    m.Add(listBox1.Items[i]);
                }
                m.Reverse();
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox1.Items[i]= m[i]; 
                }
            }
            else if(comboBox1.SelectedIndex == 2)
            {
                Puzur();
            }
            else if(comboBox1.SelectedIndex == 3)
            {
                Puzur();
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    m.Add(listBox1.Items[i]);
                }
                m.Reverse();
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox1.Items[i] = m[i];
                }

            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            List<object> m = new List<object>();
            if (comboBox2.SelectedIndex == 0)
            { listBox2.Sorted = true; }
            else if (comboBox2.SelectedIndex == 1)
            {
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    m.Add(listBox2.Items[i]);
                }
                m.Reverse();
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    listBox2.Items[i] = m[i];
                }
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                Puzur1();
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                Puzur1();
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    m.Add(listBox2.Items[i]);
                }
                m.Reverse();
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    listBox2.Items[i] = m[i];
                }

            }
        }
    }
}
