using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
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

      
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        Random rnd = new Random();
        int balance = 100;
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (balance<10)
            {
                MessageBox.Show("Необходимо пополнить баланс");
                return;
            }
            balance -= 10;

            label1.Text = rnd.Next(0, 10).ToString();
            label2.Text = rnd.Next(0, 10).ToString();
            label3.Text = rnd.Next(0, 10).ToString();
            int count = 0;
            if (label1.Text == "7") count++;
            if (label2.Text == "7") count++;
            if (label3.Text == "7") count++;
            if (count != 0) balance +=(int) Math.Pow(10, count);
            this.Text = " Баланс: " + balance.ToString();
        }
        private void btnAddMoney_Click(object sender, EventArgs e)
        {

        }

        private void btnAddMoney_Click_1(object sender, EventArgs e)
        {
            Form2 f = new Form2();

            if (f.ShowDialog()==DialogResult.OK)
            {
                int amount = int.Parse(f.txtAmount.Text);
                balance += amount;
            }
            f.Close();
        }
    }
}
