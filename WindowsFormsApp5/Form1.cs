using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("name", typeof(string));
                dt.Columns.Add("age", typeof(int));
                dt.Rows.Add("yarin", 30);
                dt.Rows.Add("yoav", 50);
                dt.Rows.Add("md", 60);
                dt.Rows.Add("asdsad", 70);
                var a = dt.Rows.Count;// מספר השורות בטבלה                //
                //dt.Rows.RemoveAt(0);
                dt.Rows[0].SetField("name", "moshe");//עידכון
                dt.Rows[0].SetField("age", 90);//עידכון

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
    }
}
