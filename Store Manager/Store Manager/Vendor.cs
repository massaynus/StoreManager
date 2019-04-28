using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Manager
{
    public partial class Vendor : UserControl
    {
        public Vendor()
        {
            InitializeComponent();
        }

        private void Vendor_Load(object sender, EventArgs e)
        {
            try
            {
                vendeurTableAdapter1.Fill(productsDataSet1.Vendeur);
                VendorDataGrid.Refresh();
            }
            catch (Exception ex){ }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            VendorAddForm f = new VendorAddForm();
            f.ShowDialog();
            this.vendeurTableAdapter1.Fill(this.productsDataSet1.Vendeur);
            this.Refresh();
        }


        private void bunifuMetroTextbox1_Enter(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "";
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            string S = bunifuMetroTextbox1.Text + "%";

            if (bunifuMetroTextbox1.Text == "") { }
            else
                vendeurTableAdapter1.FillBySearch(productsDataSet1.Vendeur, S, S, S, S);
        }

        private void bunifuMetroTextbox1_Leave(object sender, EventArgs e)
        {
            vendeurTableAdapter1.Fill(productsDataSet1.Vendeur);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            vendeurTableAdapter1.Fill(productsDataSet1.Vendeur);
        }

        private void VendorDataGrid_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.vendeurTableAdapter1.Update(this.productsDataSet1.Vendeur);
            Statistics.Logger("Deleted vendor");
        }
        
        private void VendorDataGrid_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            vendeurTableAdapter1.Update(productsDataSet1.Vendeur);
            Statistics.Logger("Updated Vendor info");
        }
    }
}
