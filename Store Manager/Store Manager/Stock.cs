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
    public partial class Stock : UserControl
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            try
            {
                productsTableAdapter.FillBy(productsDataSet1.Products);
                StockDataGrid.Refresh();
            }
            catch (Exception ex)
            {
                
            }
            

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            ProductAddForm f = new ProductAddForm();
            f.ShowDialog();
            this.productsTableAdapter.Fill(this.productsDataSet1.Products);
            this.Refresh();
        }


        private void bunifuMetroTextbox1_Enter(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "";
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            string S = bunifuMetroTextbox1.Text + "%";

            if(bunifuMetroTextbox1.Text == "") { }
            else
                productsTableAdapter.FillBySearch(productsDataSet1.Products, S, S, S);
        }

        private void bunifuMetroTextbox1_Leave(object sender, EventArgs e)
        {
            productsTableAdapter.Fill(productsDataSet1.Products);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            productsTableAdapter.Fill(productsDataSet1.Products);
        }

        private void StockDataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
             this.productsTableAdapter.Update(this.productsDataSet1.Products);
        }

        private void StockDataGrid_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.productsTableAdapter.Update(this.productsDataSet1.Products);
        }

        private void StockDataGrid_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            this.productsTableAdapter.Update(this.productsDataSet1.Products);
        }

        private void StockDataGrid_Validated(object sender, EventArgs e)
        {
            this.productsTableAdapter.Update(this.productsDataSet1.Products);
        }

        private void StockDataGrid_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            this.productsTableAdapter.Update(this.productsDataSet1.Products);
        }
    }
}
