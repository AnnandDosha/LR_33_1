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
    public partial class Record : Form
    {
        public Record()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Вы не указали ваше имя", "Ошибка");
                return;
            }
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Вы не укзали свой пол", "Ошибка");
                return;
            }
            int checked2 = 0;

            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Ни один курс не выбран", "Ошибка");
                return;
            }
            string stroka = "";
            if (radioButton1.Checked)
            {
                stroka += "Уважаемый ";
            }
            else
            {
                stroka += "Уважаемая ";
            }
            stroka += textBox1.Text + ",\n ваша запись на следующие курсы сохранена:\n";

            for (int i = 0; i <= (checkedListBox1.Items.Count - 1); i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    stroka += "- " + checkedListBox1.Items[i].ToString() + ";\n";
                }
            }
            stroka += "О начале занятий вам будет сообщено по " + comboBox1.SelectedItem.ToString() + ".";
            MessageBox.Show(stroka);
        }

        private void Record_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "e-mail";
        }
    }
}
