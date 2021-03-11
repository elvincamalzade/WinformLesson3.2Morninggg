using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformLesson3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<object> students = new List<object>
            {
                new Student
                {
                    Name="Akif"
                },
                new Student
                {
                    Name="Tural"
                },
                new Student
                {
                    Name="Leyla"
                },
            };

            comboBox1.DataSource = students;
           ////// comboBox1.Enabled = true;
            comboBox1.DisplayMember = "Name";
            comboBox1.SelectedValueChanged += ComboBox1_SelectedValueChanged;


            checkedListBox1.Items.Add("Write Code");
            checkedListBox1.Items.Add("Do Exam Tasks");
            checkedListBox1.Items.Add("Play Tennis");
            
            

        }
        private void ComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            label1.Text = (comboBox1.SelectedItem as Student)?.Name;
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.CheckedItems)
            {
                label1.Text += $"\n{item}";
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
