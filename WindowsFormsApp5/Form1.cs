using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dt.Columns.Add("name", typeof(string));
            dt.Columns.Add("age", typeof(int));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
           
                dt.Rows.Add("yarin", 30);
                dt.Rows.Add("yoav", 50);
                dt.Rows.Add("md", 60);
                dt.Rows.Add("asdsad", 70);
                dataGridView1.DataSource = dt;
               /* var a = dt.Rows.Count;// מספר השורות בטבלה      */          //
                //dt.Rows.RemoveAt(0);
                //dt.Rows[0].SetField("name", "moshe");//עידכון
                //dt.Rows[0].SetField("age", 90);//עידכון

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
          
            //label3.Text = "שלום" + txt1.Text + " " + txt2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        public void DeleteTable()
        {
            dt.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dt.Clear();
            //DeleteTable();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(txtAge.Text, out int num);
                dt.Rows.Add(txtName.Text,num);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                
            }
        }
    }
}
