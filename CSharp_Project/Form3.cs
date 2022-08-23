using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cal_result_Click(object sender, EventArgs e)
        {
            string record = dateTimePicker1.Value.ToString();
            string[] records = record.Split(' ');

            DataManager.selectQuery_mtotal(records[0]);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DataManager.totalCals;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string record = dateTimePicker1.Value.ToString();
            string[] records = record.Split(' ');
            string[] records2 = records[0].Split('-');
            DataManager.selectQuery_mtotal2((records2[0].Split('0'))[1],records2[1]);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DataManager.totalCals;
        }
    }
}
