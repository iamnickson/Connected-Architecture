using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DbConnection
{
    public partial class Form1 : Form
    {
        MySqlConnection mycon;
        public Form1()
        {
            InitializeComponent();
            mycon = new MySqlConnection("data source=localhost; database=employee; user id=root; password=");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                mycon.Open();
                MessageBox.Show("Connected Successfully");
                mycon.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
