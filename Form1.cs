using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMEN_MESHKOVA
{
    public partial class Form1 : Form
    {
        private ListRecipes recipes;
        public Form1()
        {
            InitializeComponent();
            recipes = new ListRecipes();
            recipes.Initialize();

            dataGridView1.DataSource = recipes.Recipes.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = recipes.Recipes.Where(u => u.Name.Contains(textBox1.Text)).ToList();
        }
    }
}
