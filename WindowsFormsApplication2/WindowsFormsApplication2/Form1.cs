using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sakilaDataSet.datchik1". При необходимости она может быть перемещена или удалена.
           this.datchik1TableAdapter.Fill(this.sakilaDataSet.datchik1);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.datchik1TableAdapter.Update(this.sakilaDataSet.datchik1);
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            this.datchik1TableAdapter.Fill(this.sakilaDataSet.datchik1);
            /*
            this.chart1.Series[0].Points.AddXY(10, 10);
            this.chart1.Series[0].Points.AddXY(10, 10);
            this.chart1.Series[0].Points.AddXY(5, 10);
            */
            this.chart1.Series[0].Points.AddXY(5, 4);
            this.chart1.Series[0].Points.AddXY(0, 10);
            this.chart1.Series[0].Points.AddXY(10, 10);
            this.chart1.Series[0].Points.AddXY(0, 10);
     





        }
    }
}
