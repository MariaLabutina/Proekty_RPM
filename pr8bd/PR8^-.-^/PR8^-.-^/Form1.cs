using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PR8__.__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;


        private void Form1_Load(object sender, EventArgs e)
        {
            GetStudent();
        }

        void GetStudent()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=D:\\207 Лабутина Гаврилов Блинков\\pr8bd\\dbSchool.accdb");
            da = new OleDbDataAdapter("SELECT *FROM Student", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Student");
            dataGridView_Base.DataSource = ds.Tables["Student"];
            con.Close();
        }


        private void button_Insert_Click(object sender, EventArgs e)
        {
                string query = "Insert into Student (FirstName,LastName) values (@fName,@lName)";
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@fName", textBoxFName.Text);
                cmd.Parameters.AddWithValue("@lName", textBoxLName.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                GetStudent();
        }
        private void btnDelete_Click(object sender, EventArgs e)//DELETE BUTTON
        {
            string query = "Delete From Student Where Id=@id";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@id", dataGridView_Base.CurrentRow.Cells[0].Value);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetStudent();
        }

        private void dataGridView_Base_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridView_Base.CurrentRow.Cells[0].Value.ToString();
            textBoxFName.Text = dataGridView_Base.CurrentRow.Cells[1].Value.ToString();
            textBoxLName.Text = dataGridView_Base.CurrentRow.Cells[2].Value.ToString();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            string query = "Update Student Set FirstName=@fName,LastName=@lName Where Id=@id";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@ad", textBoxFName.Text);
            cmd.Parameters.AddWithValue("@soyad", textBoxLName.Text);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBoxID.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetStudent();
        }
    }
}
