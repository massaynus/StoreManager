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
    public partial class VendorAddForm : Form
    {
        public VendorAddForm()
        {
            InitializeComponent();
        }

        private void VendorAddForm_Load(object sender, EventArgs e)
        {
            this.vendeurTableAdapter.Fill(this.productsDataSet1.Vendeur);

        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            this.vendeurTableAdapter.Insert(N.Text, P.Text, CIN.Text, Tele.Text, Adrs.Text);
            this.Close();
        }
    }
}
