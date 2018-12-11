using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTU_RGR
{
    public partial class Form1 : Form
    {
        private XTuple[] _values = null;
        private double step = 0.0, from = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            try
            {
                var divCount = int.Parse(divCountTextBox.Text);
                var to = double.Parse(toTextBox.Text);

                from = double.Parse(fromTextBox.Text);
                step = (to - from) / divCount;

                _values = RungeCutt.MainFunc(new XTuple(0, 0, 0, 0), from, to, divCount);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showX1Button_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();

            if (_values == null)
            {
                return;
            }

            for (int i = 0; i < _values.Length; i++)
            {
                chart1.Series[0].Points.AddXY(from + i * step, _values[i].x1);
            }
        }

        private void showX2Button_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();

            if (_values == null)
            {
                return;
            }

            for (int i = 0; i < _values.Length; i++)
            {
                chart1.Series[0].Points.AddXY(from + i * step, _values[i].x2);
            }
        }

        private void showX3Button_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();

            if (_values == null)
            {
                return;
            }

            for (int i = 0; i < _values.Length; i++)
            {
                chart1.Series[0].Points.AddXY(from + i * step, _values[i].x3);
            }
        }

        private void showX_CBButton_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();

            if (_values == null)
            {
                return;
            }

            for (int i = 0; i < _values.Length; i++)
            {
                chart1.Series[0].Points.AddXY(from + i * step, _values[i].x_cb);
            }
        }
    }
}
