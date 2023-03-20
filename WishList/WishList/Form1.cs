using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WishList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void wishlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = wishlist.SelectedItem.ToString();
            textBox1.Text = selected;
        }

        private void fillBtn_Click(object sender, EventArgs e)
        {
            wishlist.Items.Add("Good health");
            wishlist.Items.Add("Career growth");
            wishlist.Items.Add("Financial stability");
            wishlist.Items.Add("Strong relationships");
            wishlist.Items.Add("New experiences");
            wishlist.Items.Add("Inner peace");
            wishlist.Items.Add("Personal growth");
            wishlist.Items.Add("Positive impact");
            wishlist.Items.Add("Joy and happiness");
            wishlist.Items.Add("Gratitude");
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            wishlist.Sorted = true;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            wishlist.Items.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(wishlist.Items.Count);
        }

        private void countBtn_Click(object sender, EventArgs e)
        {
            int count = wishlist.Items.Count;
            textBox2.Text = count.ToString();
        }
    }
}
