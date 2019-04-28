using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Manager
{
    public partial class Quart : UserControl
    {
        public void AddToQuart()
        {
            foreach (ListViewItem item in listProducts.SelectedItems)
            {
                ListViewItem lvItem = item.Clone() as ListViewItem;
                listQuart.Items.Add(lvItem);
                Statistics.OnBuy(lvItem.Text);
            }
            label1.Text = Statistics.PriceSum.ToString() + "    DH";

            Statistics.Logger("Added an item to quart");
        }

        public void RemoveFromQuart()
        {
            foreach (ListViewItem item in listQuart.SelectedItems)
            {
                int index = item.Index;
                listQuart.Items.RemoveAt(index);
                Statistics.CancelBuy(item.Text);
            }
            label1.Text = Statistics.PriceSum.ToString() + "    DH";

            Statistics.Logger("Removed an item from quart");
        }

        public Quart()
        {
            InitializeComponent();
        }

        private void Quart_Load(object sender, EventArgs e)
        {
            productsTableAdapter.Fill(productsDataSet1.Products);
            for (int i = 0; i < productsDataSet1.Products.Rows.Count; i++)
            {
                DataRow D = productsDataSet1.Products.Rows[i];
                ListViewItem Plist = new ListViewItem(D["Nom"].ToString());
                listProducts.Items.Add(Plist);
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            AddToQuart();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            RemoveFromQuart();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string Lg = "Bought: ";
            string Facture = "";
            foreach (ListViewItem item in listQuart.Items)
            {
                if (Lg == "Bought: ")
                    Lg += item.Text;
                else
                    Lg += " + " + item.Text;
                Facture += @" 
" + item.Text;
            }
            Facture += @"

" + Statistics.PriceSum.ToString() + " DH";
            Lg += "  Total: " + Statistics.PriceSum.ToString();

            Statistics.Logger("The purshase:\t(" + Lg + ") was made");
            MessageBox.Show(Facture, "Facture", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listQuart.Clear();
            Statistics.PriceSum = 0;
            label1.Text = "0 DH";
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            listProducts.Clear();
            productsTableAdapter.Fill(productsDataSet1.Products);
            for (int i = 0; i < productsDataSet1.Products.Rows.Count; i++)
            {
                DataRow D = productsDataSet1.Products.Rows[i];
                ListViewItem Plist = new ListViewItem(D["Nom"].ToString());
                listProducts.Items.Add(Plist);
            }
        }
    }
}
