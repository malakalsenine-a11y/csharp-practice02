using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentManagementSystem
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.LightSteelBlue;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TxtName_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.MediumSeaGreen;
            btnAdd.ForeColor = Color.White;

            btnDelete.BackColor = Color.IndianRed;
            btnDelete.ForeColor = Color.White;

            btnSearch.BackColor = Color.DodgerBlue;
            btnSearch.ForeColor = Color.White;

            btnShowAll.BackColor = Color.DarkSlateBlue;
            btnShowAll.ForeColor = Color.White;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            Student s = new Student()
            {
                Name = textName.Text,
                Age = int.Parse(txtAge.Text),
                Nationality = textNationality.Text,
                Gender = cmbGender.Text
            };

            students.Add(s);
            MessageBox.Show("Student Added!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var student = students.FirstOrDefault(s => s.Name == textName.Text);

            if (student != null)
            {
                students.Remove(student);
                MessageBox.Show("Student Deleted");
            }
            else
            {
                MessageBox.Show("Student not found");
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = students;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var result = students.Where(s => s.Name == textName.Text).ToList();

            if (result.Count > 0)
            {
                dataGridView1.DataSource = result;
            }
            else
            {
                MessageBox.Show("Student not found");
            }
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    }

