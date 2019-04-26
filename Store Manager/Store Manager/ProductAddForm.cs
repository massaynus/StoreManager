using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Manager
{
    public partial class ProductAddForm : System.Windows.Forms.Form
    {
        public ProductAddForm()
        {
            InitializeComponent();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter1.Insert(N.Text, Cat.Text, double.Parse(Price.Text), int.Parse(Quan.Text), Desc.Text);
            this.productsDataSet1.AcceptChanges();

            MessageBox.Show("Ajouté avec succées!", "Congratulastions", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}