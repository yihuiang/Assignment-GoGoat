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

namespace Manager_asm.ChefPagess
{
    public partial class Page_Ingredients_Chef : UserControl
    {
        public Page_Ingredients_Chef()
        {
            InitializeComponent();
        }

        private void Page_Ingredients_Chef_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnbevnadd_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = txtname.Text; 
            string category = cmbbxcategory.SelectedItem.ToString();
            string unit = cmbbxunit.SelectedItem.ToString();

            ChefClass chef = new ChefClass();
            chef.AddIngredient(name, category, unit);

            MessageBox.Show("Ingredient added successfully!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtbxsearch.Clear();
        }

        private void txtbxsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbltitleadd_Click(object sender, EventArgs e)
        {

        }
    }
}
