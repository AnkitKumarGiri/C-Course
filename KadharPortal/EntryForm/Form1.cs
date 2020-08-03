using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntryForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FatherName_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var newKadhar = new KadharLibrary.Kadhar();
            newKadhar.Name = txtName.Text;
            newKadhar.FatherName = txtFatherName.Text;
            newKadhar.Age = txtAge.Text;

            MessageBox.Show(newKadhar.ToString());

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
