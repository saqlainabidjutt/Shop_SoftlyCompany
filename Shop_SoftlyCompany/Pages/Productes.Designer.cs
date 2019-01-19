namespace Shop_TPV.Pages
{
    partial class Productes
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
            this.Update = new System.Windows.Forms.Button();
            this.OrderBy = new System.Windows.Forms.ComboBox();
            this.SearchLab = new System.Windows.Forms.ComboBox();
            this.Search = new System.Windows.Forms.Label();
            this.searchKeyword = new System.Windows.Forms.TextBox();
            this.dtProduct = new System.Windows.Forms.DataGridView();
            this.Refresh = new System.Windows.Forms.Button();
            this.Srarch = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBoxProd = new System.Windows.Forms.GroupBox();
            this.ProdStatus = new System.Windows.Forms.ComboBox();
            this.labP_STATUS = new System.Windows.Forms.Label();
            this.ProdStocktxt = new System.Windows.Forms.TextBox();
            this.labP_STOCK = new System.Windows.Forms.Label();
            this.ProdTextxt = new System.Windows.Forms.TextBox();
            this.labP_TEX = new System.Windows.Forms.Label();
            this.ProdPricetxt = new System.Windows.Forms.TextBox();
            this.labP_PRICE = new System.Windows.Forms.Label();
            this.ProdISBNtxt = new System.Windows.Forms.TextBox();
            this.labP_ISBN_CODE = new System.Windows.Forms.Label();
            this.ProdDtotxt = new System.Windows.Forms.TextBox();
            this.labP_DTO = new System.Windows.Forms.Label();
            this.ProdCatelog = new System.Windows.Forms.ComboBox();
            this.labP_FAMI_ID = new System.Windows.Forms.Label();
            this.ProdNametxt = new System.Windows.Forms.TextBox();
            this.labP_ID = new System.Windows.Forms.Label();
            this.ProdIdtxt = new System.Windows.Forms.TextBox();
            this.labP_NAME = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtProduct)).BeginInit();
            this.groupBoxProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(454, 440);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(104, 37);
            this.Update.TabIndex = 70;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // OrderBy
            // 
            this.OrderBy.FormattingEnabled = true;
            this.OrderBy.Items.AddRange(new object[] {
            "ASC",
            "DESC"});
            this.OrderBy.Location = new System.Drawing.Point(1140, 16);
            this.OrderBy.Name = "OrderBy";
            this.OrderBy.Size = new System.Drawing.Size(84, 21);
            this.OrderBy.TabIndex = 69;
            this.OrderBy.SelectedIndexChanged += new System.EventHandler(this.SearchLab_SelectedIndexChanged);
            // 
            // SearchLab
            // 
            this.SearchLab.FormattingEnabled = true;
            this.SearchLab.Location = new System.Drawing.Point(532, 15);
            this.SearchLab.Name = "SearchLab";
            this.SearchLab.Size = new System.Drawing.Size(89, 21);
            this.SearchLab.TabIndex = 68;
            this.SearchLab.SelectedIndexChanged += new System.EventHandler(this.SearchLab_SelectedIndexChanged);
            // 
            // Search
            // 
            this.Search.AccessibleName = "Name";
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(469, 17);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(57, 16);
            this.Search.TabIndex = 67;
            this.Search.Text = "Search";
            // 
            // searchKeyword
            // 
            this.searchKeyword.Location = new System.Drawing.Point(627, 16);
            this.searchKeyword.Name = "searchKeyword";
            this.searchKeyword.Size = new System.Drawing.Size(507, 20);
            this.searchKeyword.TabIndex = 66;
            this.searchKeyword.TextChanged += new System.EventHandler(this.SearchLab_SelectedIndexChanged);
            // 
            // dtProduct
            // 
            this.dtProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtProduct.Location = new System.Drawing.Point(472, 44);
            this.dtProduct.Name = "dtProduct";
            this.dtProduct.Size = new System.Drawing.Size(752, 314);
            this.dtProduct.TabIndex = 65;
            this.dtProduct.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtCatelog_RowHeaderMouseClick);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(713, 440);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(104, 37);
            this.Refresh.TabIndex = 64;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Srarch
            // 
            this.Srarch.Location = new System.Drawing.Point(584, 440);
            this.Srarch.Name = "Srarch";
            this.Srarch.Size = new System.Drawing.Size(104, 37);
            this.Srarch.TabIndex = 63;
            this.Srarch.Text = "Search";
            this.Srarch.UseVisualStyleBackColor = true;
            this.Srarch.Click += new System.EventHandler(this.Srarch_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(326, 440);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(104, 37);
            this.btnEdit.TabIndex = 62;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Location = new System.Drawing.Point(178, 440);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 37);
            this.btnAdd.TabIndex = 61;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBoxProd
            // 
            this.groupBoxProd.Controls.Add(this.ProdStatus);
            this.groupBoxProd.Controls.Add(this.labP_STATUS);
            this.groupBoxProd.Controls.Add(this.ProdStocktxt);
            this.groupBoxProd.Controls.Add(this.labP_STOCK);
            this.groupBoxProd.Controls.Add(this.ProdTextxt);
            this.groupBoxProd.Controls.Add(this.labP_TEX);
            this.groupBoxProd.Controls.Add(this.ProdPricetxt);
            this.groupBoxProd.Controls.Add(this.labP_PRICE);
            this.groupBoxProd.Controls.Add(this.ProdISBNtxt);
            this.groupBoxProd.Controls.Add(this.labP_ISBN_CODE);
            this.groupBoxProd.Controls.Add(this.ProdDtotxt);
            this.groupBoxProd.Controls.Add(this.labP_DTO);
            this.groupBoxProd.Controls.Add(this.ProdCatelog);
            this.groupBoxProd.Controls.Add(this.labP_FAMI_ID);
            this.groupBoxProd.Controls.Add(this.ProdNametxt);
            this.groupBoxProd.Controls.Add(this.labP_ID);
            this.groupBoxProd.Controls.Add(this.ProdIdtxt);
            this.groupBoxProd.Controls.Add(this.labP_NAME);
            this.groupBoxProd.Location = new System.Drawing.Point(43, 14);
            this.groupBoxProd.Name = "groupBoxProd";
            this.groupBoxProd.Size = new System.Drawing.Size(297, 275);
            this.groupBoxProd.TabIndex = 60;
            this.groupBoxProd.TabStop = false;
            this.groupBoxProd.Text = "Productes";
            this.groupBoxProd.Enter += new System.EventHandler(this.groupBoxProd_Enter);
            // 
            // ProdStatus
            // 
            this.ProdStatus.Enabled = false;
            this.ProdStatus.FormattingEnabled = true;
            this.ProdStatus.Items.AddRange(new object[] {
            "Active",
            "Deactive"});
            this.ProdStatus.Location = new System.Drawing.Point(103, 197);
            this.ProdStatus.Name = "ProdStatus";
            this.ProdStatus.Size = new System.Drawing.Size(176, 21);
            this.ProdStatus.TabIndex = 60;
            // 
            // labP_STATUS
            // 
            this.labP_STATUS.AccessibleName = "LabStatus";
            this.labP_STATUS.AutoSize = true;
            this.labP_STATUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labP_STATUS.Location = new System.Drawing.Point(3, 202);
            this.labP_STATUS.Name = "labP_STATUS";
            this.labP_STATUS.Size = new System.Drawing.Size(51, 16);
            this.labP_STATUS.TabIndex = 59;
            this.labP_STATUS.Text = "Status";
            // 
            // ProdStocktxt
            // 
            this.ProdStocktxt.Location = new System.Drawing.Point(103, 145);
            this.ProdStocktxt.Name = "ProdStocktxt";
            this.ProdStocktxt.ReadOnly = true;
            this.ProdStocktxt.Size = new System.Drawing.Size(176, 20);
            this.ProdStocktxt.TabIndex = 58;
            // 
            // labP_STOCK
            // 
            this.labP_STOCK.AccessibleName = "Name";
            this.labP_STOCK.AutoSize = true;
            this.labP_STOCK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labP_STOCK.Location = new System.Drawing.Point(3, 145);
            this.labP_STOCK.Name = "labP_STOCK";
            this.labP_STOCK.Size = new System.Drawing.Size(47, 16);
            this.labP_STOCK.TabIndex = 57;
            this.labP_STOCK.Text = "Stock";
            // 
            // ProdTextxt
            // 
            this.ProdTextxt.Location = new System.Drawing.Point(103, 119);
            this.ProdTextxt.Name = "ProdTextxt";
            this.ProdTextxt.ReadOnly = true;
            this.ProdTextxt.Size = new System.Drawing.Size(176, 20);
            this.ProdTextxt.TabIndex = 56;
            // 
            // labP_TEX
            // 
            this.labP_TEX.AccessibleName = "Name";
            this.labP_TEX.AutoSize = true;
            this.labP_TEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labP_TEX.Location = new System.Drawing.Point(3, 119);
            this.labP_TEX.Name = "labP_TEX";
            this.labP_TEX.Size = new System.Drawing.Size(34, 16);
            this.labP_TEX.TabIndex = 55;
            this.labP_TEX.Text = "Tex";
            // 
            // ProdPricetxt
            // 
            this.ProdPricetxt.Location = new System.Drawing.Point(103, 93);
            this.ProdPricetxt.Name = "ProdPricetxt";
            this.ProdPricetxt.ReadOnly = true;
            this.ProdPricetxt.Size = new System.Drawing.Size(176, 20);
            this.ProdPricetxt.TabIndex = 54;
            // 
            // labP_PRICE
            // 
            this.labP_PRICE.AccessibleName = "Name";
            this.labP_PRICE.AutoSize = true;
            this.labP_PRICE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labP_PRICE.Location = new System.Drawing.Point(3, 93);
            this.labP_PRICE.Name = "labP_PRICE";
            this.labP_PRICE.Size = new System.Drawing.Size(44, 16);
            this.labP_PRICE.TabIndex = 53;
            this.labP_PRICE.Text = "Price";
            // 
            // ProdISBNtxt
            // 
            this.ProdISBNtxt.Location = new System.Drawing.Point(103, 67);
            this.ProdISBNtxt.Name = "ProdISBNtxt";
            this.ProdISBNtxt.ReadOnly = true;
            this.ProdISBNtxt.Size = new System.Drawing.Size(176, 20);
            this.ProdISBNtxt.TabIndex = 52;
            // 
            // labP_ISBN_CODE
            // 
            this.labP_ISBN_CODE.AccessibleName = "Name";
            this.labP_ISBN_CODE.AutoSize = true;
            this.labP_ISBN_CODE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labP_ISBN_CODE.Location = new System.Drawing.Point(3, 67);
            this.labP_ISBN_CODE.Name = "labP_ISBN_CODE";
            this.labP_ISBN_CODE.Size = new System.Drawing.Size(43, 16);
            this.labP_ISBN_CODE.TabIndex = 51;
            this.labP_ISBN_CODE.Text = "ISBN";
            // 
            // ProdDtotxt
            // 
            this.ProdDtotxt.Location = new System.Drawing.Point(103, 171);
            this.ProdDtotxt.Name = "ProdDtotxt";
            this.ProdDtotxt.ReadOnly = true;
            this.ProdDtotxt.Size = new System.Drawing.Size(176, 20);
            this.ProdDtotxt.TabIndex = 50;
            // 
            // labP_DTO
            // 
            this.labP_DTO.AccessibleName = "Name";
            this.labP_DTO.AutoSize = true;
            this.labP_DTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labP_DTO.Location = new System.Drawing.Point(3, 171);
            this.labP_DTO.Name = "labP_DTO";
            this.labP_DTO.Size = new System.Drawing.Size(32, 16);
            this.labP_DTO.TabIndex = 49;
            this.labP_DTO.Text = "Dto";
            // 
            // ProdCatelog
            // 
            this.ProdCatelog.Enabled = false;
            this.ProdCatelog.FormattingEnabled = true;
            this.ProdCatelog.Items.AddRange(new object[] {
            "Active",
            "Deactive"});
            this.ProdCatelog.Location = new System.Drawing.Point(103, 224);
            this.ProdCatelog.Name = "ProdCatelog";
            this.ProdCatelog.Size = new System.Drawing.Size(176, 21);
            this.ProdCatelog.TabIndex = 45;
            this.ProdCatelog.SelectedIndexChanged += new System.EventHandler(this.ProdStatus_SelectedIndexChanged);
            // 
            // labP_FAMI_ID
            // 
            this.labP_FAMI_ID.AccessibleName = "LabStatus";
            this.labP_FAMI_ID.AutoSize = true;
            this.labP_FAMI_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labP_FAMI_ID.Location = new System.Drawing.Point(3, 229);
            this.labP_FAMI_ID.Name = "labP_FAMI_ID";
            this.labP_FAMI_ID.Size = new System.Drawing.Size(62, 16);
            this.labP_FAMI_ID.TabIndex = 44;
            this.labP_FAMI_ID.Text = "Catelog";
            this.labP_FAMI_ID.Click += new System.EventHandler(this.labSTATUS_Click);
            // 
            // ProdNametxt
            // 
            this.ProdNametxt.Location = new System.Drawing.Point(103, 41);
            this.ProdNametxt.Name = "ProdNametxt";
            this.ProdNametxt.ReadOnly = true;
            this.ProdNametxt.Size = new System.Drawing.Size(176, 20);
            this.ProdNametxt.TabIndex = 11;
            // 
            // labP_ID
            // 
            this.labP_ID.AccessibleName = "Name";
            this.labP_ID.AutoSize = true;
            this.labP_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labP_ID.Location = new System.Drawing.Point(3, 19);
            this.labP_ID.Name = "labP_ID";
            this.labP_ID.Size = new System.Drawing.Size(21, 16);
            this.labP_ID.TabIndex = 6;
            this.labP_ID.Text = "Id";
            // 
            // ProdIdtxt
            // 
            this.ProdIdtxt.Location = new System.Drawing.Point(103, 15);
            this.ProdIdtxt.Name = "ProdIdtxt";
            this.ProdIdtxt.ReadOnly = true;
            this.ProdIdtxt.Size = new System.Drawing.Size(176, 20);
            this.ProdIdtxt.TabIndex = 7;
            // 
            // labP_NAME
            // 
            this.labP_NAME.AccessibleName = "Name";
            this.labP_NAME.AutoSize = true;
            this.labP_NAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labP_NAME.Location = new System.Drawing.Point(3, 41);
            this.labP_NAME.Name = "labP_NAME";
            this.labP_NAME.Size = new System.Drawing.Size(49, 16);
            this.labP_NAME.TabIndex = 8;
            this.labP_NAME.Text = "Name";
            // 
            // Productes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 490);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.OrderBy);
            this.Controls.Add(this.SearchLab);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.searchKeyword);
            this.Controls.Add(this.dtProduct);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Srarch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBoxProd);
            this.Name = "Productes";
            this.Text = "Productes";
            this.Load += new System.EventHandler(this.Productes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtProduct)).EndInit();
            this.groupBoxProd.ResumeLayout(false);
            this.groupBoxProd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.ComboBox OrderBy;
        private System.Windows.Forms.ComboBox SearchLab;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.TextBox searchKeyword;
        private System.Windows.Forms.DataGridView dtProduct;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button Srarch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBoxProd;
        private System.Windows.Forms.ComboBox ProdCatelog;
        private System.Windows.Forms.Label labP_FAMI_ID;
        private System.Windows.Forms.TextBox ProdNametxt;
        private System.Windows.Forms.Label labP_ID;
        private System.Windows.Forms.TextBox ProdIdtxt;
        private System.Windows.Forms.Label labP_NAME;
        private System.Windows.Forms.TextBox ProdISBNtxt;
        private System.Windows.Forms.Label labP_ISBN_CODE;
        private System.Windows.Forms.TextBox ProdDtotxt;
        private System.Windows.Forms.Label labP_DTO;
        private System.Windows.Forms.ComboBox ProdStatus;
        private System.Windows.Forms.Label labP_STATUS;
        private System.Windows.Forms.TextBox ProdStocktxt;
        private System.Windows.Forms.Label labP_STOCK;
        private System.Windows.Forms.TextBox ProdTextxt;
        private System.Windows.Forms.Label labP_TEX;
        private System.Windows.Forms.TextBox ProdPricetxt;
        private System.Windows.Forms.Label labP_PRICE;
    }
}