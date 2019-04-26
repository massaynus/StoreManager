namespace Store_Manager
{
    partial class ProductAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductAddForm));
            this.N = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsDataSet1 = new Store_Manager.ProductsDataSet();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Desc = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Quan = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Price = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Cat = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.productsTableAdapter1 = new Store_Manager.ProductsDataSetTableAdapters.ProductsTableAdapter();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataSet1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // N
            // 
            this.N.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.N.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Nom", true));
            this.N.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.N.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.N.HintForeColor = System.Drawing.Color.Empty;
            this.N.HintText = "";
            this.N.isPassword = false;
            this.N.LineFocusedColor = System.Drawing.Color.Blue;
            this.N.LineIdleColor = System.Drawing.Color.Gray;
            this.N.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.N.LineThickness = 3;
            this.N.Location = new System.Drawing.Point(199, 57);
            this.N.Margin = new System.Windows.Forms.Padding(4);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(454, 44);
            this.N.TabIndex = 0;
            this.N.Text = "Nom";
            this.N.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.productsDataSet1;
            // 
            // productsDataSet1
            // 
            this.productsDataSet1.DataSetName = "ProductsDataSet";
            this.productsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(83, 72);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(51, 19);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Nom:";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuTileButton2);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuTileButton1);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel4);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel1.Controls.Add(this.Desc);
            this.bunifuGradientPanel1.Controls.Add(this.Quan);
            this.bunifuGradientPanel1.Controls.Add(this.Price);
            this.bunifuGradientPanel1.Controls.Add(this.Cat);
            this.bunifuGradientPanel1.Controls.Add(this.N);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(221)))), ((int)(((byte)(23)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.ForestGreen;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(666, 483);
            this.bunifuGradientPanel1.TabIndex = 4;
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 20;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 41;
            this.bunifuTileButton1.LabelText = "Valider";
            this.bunifuTileButton1.Location = new System.Drawing.Point(134, 343);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(116, 125);
            this.bunifuTileButton1.TabIndex = 5;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(32, 280);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(102, 19);
            this.bunifuCustomLabel5.TabIndex = 1;
            this.bunifuCustomLabel5.Text = " Déscription:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(51, 228);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(83, 19);
            this.bunifuCustomLabel4.TabIndex = 1;
            this.bunifuCustomLabel4.Text = " Quantité:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(90, 176);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(44, 19);
            this.bunifuCustomLabel3.TabIndex = 1;
            this.bunifuCustomLabel3.Text = " Prix:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(40, 124);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(94, 19);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = " Catégorie:";
            // 
            // Desc
            // 
            this.Desc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Desc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Description", true));
            this.Desc.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Desc.HintForeColor = System.Drawing.Color.Empty;
            this.Desc.HintText = "";
            this.Desc.isPassword = false;
            this.Desc.LineFocusedColor = System.Drawing.Color.Blue;
            this.Desc.LineIdleColor = System.Drawing.Color.Gray;
            this.Desc.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Desc.LineThickness = 3;
            this.Desc.Location = new System.Drawing.Point(199, 265);
            this.Desc.Margin = new System.Windows.Forms.Padding(4);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(454, 44);
            this.Desc.TabIndex = 4;
            this.Desc.Text = "Déscription";
            this.Desc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Quan
            // 
            this.Quan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Quan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Quantite", true));
            this.Quan.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Quan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Quan.HintForeColor = System.Drawing.Color.Empty;
            this.Quan.HintText = "";
            this.Quan.isPassword = false;
            this.Quan.LineFocusedColor = System.Drawing.Color.Blue;
            this.Quan.LineIdleColor = System.Drawing.Color.Gray;
            this.Quan.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Quan.LineThickness = 3;
            this.Quan.Location = new System.Drawing.Point(199, 213);
            this.Quan.Margin = new System.Windows.Forms.Padding(4);
            this.Quan.Name = "Quan";
            this.Quan.Size = new System.Drawing.Size(454, 44);
            this.Quan.TabIndex = 3;
            this.Quan.Text = "0";
            this.Quan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Price
            // 
            this.Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Price.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Prix", true));
            this.Price.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Price.HintForeColor = System.Drawing.Color.Empty;
            this.Price.HintText = "";
            this.Price.isPassword = false;
            this.Price.LineFocusedColor = System.Drawing.Color.Blue;
            this.Price.LineIdleColor = System.Drawing.Color.Gray;
            this.Price.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Price.LineThickness = 3;
            this.Price.Location = new System.Drawing.Point(199, 161);
            this.Price.Margin = new System.Windows.Forms.Padding(4);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(454, 44);
            this.Price.TabIndex = 2;
            this.Price.Text = "0,00";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Cat
            // 
            this.Cat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Cat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Categorie", true));
            this.Cat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Cat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Cat.HintForeColor = System.Drawing.Color.Empty;
            this.Cat.HintText = "";
            this.Cat.isPassword = false;
            this.Cat.LineFocusedColor = System.Drawing.Color.Blue;
            this.Cat.LineIdleColor = System.Drawing.Color.Gray;
            this.Cat.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Cat.LineThickness = 3;
            this.Cat.Location = new System.Drawing.Point(199, 109);
            this.Cat.Margin = new System.Windows.Forms.Padding(4);
            this.Cat.Name = "Cat";
            this.Cat.Size = new System.Drawing.Size(454, 44);
            this.Cat.TabIndex = 1;
            this.Cat.Text = "Catégorie";
            this.Cat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton2.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton2.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton2.Image")));
            this.bunifuTileButton2.ImagePosition = 20;
            this.bunifuTileButton2.ImageZoom = 50;
            this.bunifuTileButton2.LabelPosition = 41;
            this.bunifuTileButton2.LabelText = "Annuler";
            this.bunifuTileButton2.Location = new System.Drawing.Point(433, 343);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(116, 125);
            this.bunifuTileButton2.TabIndex = 5;
            this.bunifuTileButton2.Click += new System.EventHandler(this.bunifuTileButton2_Click);
            // 
            // Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(666, 483);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ProductAddForm";
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataSet1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox N;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Quan;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Price;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Cat;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Desc;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private ProductsDataSet productsDataSet1;
        private ProductsDataSetTableAdapters.ProductsTableAdapter productsTableAdapter1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
    }
}