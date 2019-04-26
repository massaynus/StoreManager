namespace Store_Manager
{
    partial class VendorAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendorAddForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.productsDataSet1 = new Store_Manager.ProductsDataSet();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Adrs = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Tele = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CIN = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.P = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.N = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.vendeurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.vendeurTableAdapter = new Store_Manager.ProductsDataSetTableAdapters.VendeurTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendeurBindingSource)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.bunifuTileButton2.LabelText = "&Annuler";
            this.bunifuTileButton2.Location = new System.Drawing.Point(433, 343);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(116, 125);
            this.bunifuTileButton2.TabIndex = 5;
            this.bunifuTileButton2.Click += new System.EventHandler(this.bunifuTileButton2_Click);
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
            this.bunifuTileButton1.LabelText = "&Valider";
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
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(61, 276);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(73, 19);
            this.bunifuCustomLabel5.TabIndex = 1;
            this.bunifuCustomLabel5.Text = "Adresse:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(103, 225);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(31, 19);
            this.bunifuCustomLabel4.TabIndex = 1;
            this.bunifuCustomLabel4.Text = "N°:";
            // 
            // productsDataSet1
            // 
            this.productsDataSet1.DataSetName = "ProductsDataSet";
            this.productsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(93, 174);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(41, 19);
            this.bunifuCustomLabel3.TabIndex = 1;
            this.bunifuCustomLabel3.Text = "CIN:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(61, 123);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(73, 19);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Prénom:";
            // 
            // Adrs
            // 
            this.Adrs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Adrs.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Adrs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Adrs.HintForeColor = System.Drawing.Color.Empty;
            this.Adrs.HintText = "";
            this.Adrs.isPassword = false;
            this.Adrs.LineFocusedColor = System.Drawing.Color.Blue;
            this.Adrs.LineIdleColor = System.Drawing.Color.Gray;
            this.Adrs.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Adrs.LineThickness = 3;
            this.Adrs.Location = new System.Drawing.Point(199, 265);
            this.Adrs.Margin = new System.Windows.Forms.Padding(4);
            this.Adrs.Name = "Adrs";
            this.Adrs.Size = new System.Drawing.Size(454, 44);
            this.Adrs.TabIndex = 4;
            this.Adrs.Text = "Adresse...";
            this.Adrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Tele
            // 
            this.Tele.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tele.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Tele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Tele.HintForeColor = System.Drawing.Color.Empty;
            this.Tele.HintText = "";
            this.Tele.isPassword = false;
            this.Tele.LineFocusedColor = System.Drawing.Color.Blue;
            this.Tele.LineIdleColor = System.Drawing.Color.Gray;
            this.Tele.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Tele.LineThickness = 3;
            this.Tele.Location = new System.Drawing.Point(199, 213);
            this.Tele.Margin = new System.Windows.Forms.Padding(4);
            this.Tele.Name = "Tele";
            this.Tele.Size = new System.Drawing.Size(454, 44);
            this.Tele.TabIndex = 3;
            this.Tele.Text = "00212555";
            this.Tele.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CIN
            // 
            this.CIN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CIN.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CIN.HintForeColor = System.Drawing.Color.Empty;
            this.CIN.HintText = "";
            this.CIN.isPassword = false;
            this.CIN.LineFocusedColor = System.Drawing.Color.Blue;
            this.CIN.LineIdleColor = System.Drawing.Color.Gray;
            this.CIN.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.CIN.LineThickness = 3;
            this.CIN.Location = new System.Drawing.Point(199, 161);
            this.CIN.Margin = new System.Windows.Forms.Padding(4);
            this.CIN.Name = "CIN";
            this.CIN.Size = new System.Drawing.Size(454, 44);
            this.CIN.TabIndex = 2;
            this.CIN.Text = "X0000000";
            this.CIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // P
            // 
            this.P.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.P.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.P.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.P.HintForeColor = System.Drawing.Color.Empty;
            this.P.HintText = "";
            this.P.isPassword = false;
            this.P.LineFocusedColor = System.Drawing.Color.Blue;
            this.P.LineIdleColor = System.Drawing.Color.Gray;
            this.P.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.P.LineThickness = 3;
            this.P.Location = new System.Drawing.Point(199, 109);
            this.P.Margin = new System.Windows.Forms.Padding(4);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(454, 44);
            this.P.TabIndex = 1;
            this.P.Text = "Prénom";
            this.P.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // N
            // 
            this.N.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.N.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendeurBindingSource, "Nom", true));
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
            // vendeurBindingSource
            // 
            this.vendeurBindingSource.DataMember = "Vendeur";
            this.vendeurBindingSource.DataSource = this.productsDataSet1;
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
            this.bunifuGradientPanel1.Controls.Add(this.Adrs);
            this.bunifuGradientPanel1.Controls.Add(this.Tele);
            this.bunifuGradientPanel1.Controls.Add(this.CIN);
            this.bunifuGradientPanel1.Controls.Add(this.P);
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
            this.bunifuGradientPanel1.TabIndex = 5;
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
            // vendeurTableAdapter
            // 
            this.vendeurTableAdapter.ClearBeforeFill = true;
            // 
            // VendorAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 483);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "VendorAddForm";
            this.Text = "VendorAddForm";
            ((System.ComponentModel.ISupportInitialize)(this.productsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendeurBindingSource)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Adrs;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Tele;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CIN;
        private Bunifu.Framework.UI.BunifuMaterialTextbox P;
        private Bunifu.Framework.UI.BunifuMaterialTextbox N;
        private ProductsDataSet productsDataSet1;
        private System.Windows.Forms.BindingSource vendeurBindingSource;
        private ProductsDataSetTableAdapters.VendeurTableAdapter vendeurTableAdapter;
    }
}