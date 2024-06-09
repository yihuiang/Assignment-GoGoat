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
        ChefClass chef = new ChefClass();

        public Page_Ingredients_Chef()
        {
            InitializeComponent();
            LoadIngredients();
        }

        private void Page_Ingredients_Chef_Load(object sender, EventArgs e)
        {
            LoadIngredients();
        }

        private void LoadIngredients()
        {
            DataTable dt = chef.GetIngredients();
            datagridviewIng.DataSource = dt;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string category = cmbbxcategory.SelectedItem.ToString();
            string unit = cmbbxunit.SelectedItem.ToString();

            chef.AddIngredient(name, category, unit);

            MessageBox.Show("Ingredient added successfully!");
            LoadIngredients(); // Refresh the DataGridView
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtbxsearch.Clear();
        }

        private void txtbxsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            if (datagridviewIng.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in datagridviewIng.SelectedRows)
                {
                    int ingredientsID = Convert.ToInt32(row.Cells["IngredientsID"].Value);
                    chef.DeleteIngredient(ingredientsID);
                }
                MessageBox.Show("Selected ingredient(s) deleted successfully!");
                LoadIngredients(); // Refresh the DataGridView
            }
            else
            {
                MessageBox.Show("Please select an ingredient to delete.");
            }
        }
    }
}


