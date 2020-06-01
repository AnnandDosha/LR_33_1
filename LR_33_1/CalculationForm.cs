using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_33_1
{
    public partial class CalculationForm : Form
    {
        public CalculationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (number1TextBox.Text != "" && number2TextBox.Text != "")
            {
                if (plusRadioButton.Checked)
                {
                    double a = Convert.ToDouble(number1TextBox.Text);
                    double b = Convert.ToDouble(number2TextBox.Text);
                    conclusionLabel.Text = "Ответ: " + Convert.ToString(a + b);
                }
                if (minusRadioButton.Checked)
                {
                    double a = Convert.ToDouble(number1TextBox.Text);
                    double b = Convert.ToDouble(number2TextBox.Text);
                    conclusionLabel.Text = "Ответ: " + Convert.ToString(a - b);
                }
                if (mulRadioButton.Checked)
                {
                    double a = Convert.ToDouble(number1TextBox.Text);
                    double b = Convert.ToDouble(number2TextBox.Text);
                    conclusionLabel.Text = "Ответ: " + Convert.ToString(a * b);
                }
                if (divisionRadioButton.Checked)
                {
                    double a = Convert.ToDouble(number1TextBox.Text);
                    double b = Convert.ToDouble(number2TextBox.Text);
                    conclusionLabel.Text = "Ответ: " + Convert.ToString(a / b);
                }
            }
            else
            {
                conclusionLabel.Text = "Ошибка";
            }
        }
    }
}
