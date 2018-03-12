using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Web_Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        string GrayedText = "Enter a URL here";
        private void textBox1_Enter(object sender, System.EventArgs e)
        {
            GrayedText = textBox1.Text; // Stores old text value if you want
            textBox1.Text = ""; // Clears the text field
            textBox1.ReadOnly = false; // Makes the field editable
        }

        private void textBox1_Leave(object sender, System.EventArgs e)
        {
            textBox1.ReadOnly = true; // Returns to being grayed out
            textBox1.Text = GrayedText; // Returns old text if you want
        }
        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by ya boi stop_sign");
        }
        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button1_Click(null, null);
            }
        }
    }
}
