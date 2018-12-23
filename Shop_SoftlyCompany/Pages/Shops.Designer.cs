using System.Reflection;
using System.Resources;

namespace Shop_TPV.Pages
{
    partial class Shops
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
            this.shopName = new System.Windows.Forms.TextBox();
            this.labS_NAME = new System.Windows.Forms.Label();
            this.shopIdtxt = new System.Windows.Forms.TextBox();
            this.catelogId = new System.Windows.Forms.Label();
            this.addrFloor = new System.Windows.Forms.TextBox();
            this.labA_FLOOR = new System.Windows.Forms.Label();
            this.addrBuildingNum = new System.Windows.Forms.TextBox();
            this.labA_BUILDINGNUM = new System.Windows.Forms.Label();
            this.addrStreet = new System.Windows.Forms.TextBox();
            this.labA_STREET = new System.Windows.Forms.Label();
            this.addrTelefon = new System.Windows.Forms.TextBox();
            this.labA_TELEFON = new System.Windows.Forms.Label();
            this.addrDoor = new System.Windows.Forms.TextBox();
            this.labA_DOORNUM = new System.Windows.Forms.Label();
            this.labS_STATUS = new System.Windows.Forms.Label();
            this.shopIdentity = new System.Windows.Forms.TextBox();
            this.labS_USER_IDENTITY = new System.Windows.Forms.Label();
            this.addrPostalCode = new System.Windows.Forms.TextBox();
            this.labA_POSTALCODE = new System.Windows.Forms.Label();
            this.addrCity = new System.Windows.Forms.TextBox();
            this.labA_CITY = new System.Windows.Forms.Label();
            this.addrProvence = new System.Windows.Forms.TextBox();
            this.labA_PROVENCE = new System.Windows.Forms.Label();
            this.addrCountry = new System.Windows.Forms.TextBox();
            this.labA_COUNTRY = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dShops = new System.Windows.Forms.DataGridView();
            this.searchKeyword = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.shopStatus = new System.Windows.Forms.ComboBox();
            this.addrId = new System.Windows.Forms.TextBox();
            this.Srarch = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.OrderBy = new System.Windows.Forms.ComboBox();
            this.SearchLab = new System.Windows.Forms.ComboBox();
            this.groupAddr = new System.Windows.Forms.GroupBox();
            this.addrIdLab = new System.Windows.Forms.Label();
            this.groupShop = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dShops)).BeginInit();
            this.groupAddr.SuspendLayout();
            this.groupShop.SuspendLayout();
            this.SuspendLayout();
            // 
            // shopName
            // 
            this.shopName.Location = new System.Drawing.Point(98, 50);
            this.shopName.Name = "shopName";
            this.shopName.ReadOnly = true;
            this.shopName.Size = new System.Drawing.Size(220, 20);
            this.shopName.TabIndex = 9;
            // 
            // labS_NAME
            // 
            this.labS_NAME.AccessibleName = "Name";
            this.labS_NAME.AutoSize = true;
            this.labS_NAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labS_NAME.Location = new System.Drawing.Point(26, 54);
            this.labS_NAME.Name = "labS_NAME";
            this.labS_NAME.Size = new System.Drawing.Size(49, 16);
            this.labS_NAME.TabIndex = 8;
            this.labS_NAME.Text = "Name";
            // 
            // shopIdtxt
            // 
            this.shopIdtxt.Location = new System.Drawing.Point(98, 24);
            this.shopIdtxt.Name = "shopIdtxt";
            this.shopIdtxt.ReadOnly = true;
            this.shopIdtxt.Size = new System.Drawing.Size(95, 20);
            this.shopIdtxt.TabIndex = 7;
            // 
            // catelogId
            // 
            this.catelogId.AccessibleName = "Name";
            this.catelogId.AutoSize = true;
            this.catelogId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catelogId.Location = new System.Drawing.Point(49, 27);
            this.catelogId.Name = "catelogId";
            this.catelogId.Size = new System.Drawing.Size(21, 16);
            this.catelogId.TabIndex = 6;
            this.catelogId.Text = "Id";
            // 
            // addrFloor
            // 
            this.addrFloor.Location = new System.Drawing.Point(119, 124);
            this.addrFloor.Name = "addrFloor";
            this.addrFloor.ReadOnly = true;
            this.addrFloor.Size = new System.Drawing.Size(220, 20);
            this.addrFloor.TabIndex = 11;
            // 
            // labA_FLOOR
            // 
            this.labA_FLOOR.AccessibleName = "labFloor";
            this.labA_FLOOR.AutoSize = true;
            this.labA_FLOOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labA_FLOOR.Location = new System.Drawing.Point(47, 128);
            this.labA_FLOOR.Name = "labA_FLOOR";
            this.labA_FLOOR.Size = new System.Drawing.Size(44, 16);
            this.labA_FLOOR.TabIndex = 10;
            this.labA_FLOOR.Text = "Floor";
            // 
            // addrBuildingNum
            // 
            this.addrBuildingNum.Location = new System.Drawing.Point(119, 98);
            this.addrBuildingNum.Name = "addrBuildingNum";
            this.addrBuildingNum.ReadOnly = true;
            this.addrBuildingNum.Size = new System.Drawing.Size(220, 20);
            this.addrBuildingNum.TabIndex = 13;
            // 
            // labA_BUILDINGNUM
            // 
            this.labA_BUILDINGNUM.AccessibleName = "LabbuildingNum";
            this.labA_BUILDINGNUM.AutoSize = true;
            this.labA_BUILDINGNUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labA_BUILDINGNUM.Location = new System.Drawing.Point(13, 102);
            this.labA_BUILDINGNUM.Name = "labA_BUILDINGNUM";
            this.labA_BUILDINGNUM.Size = new System.Drawing.Size(78, 16);
            this.labA_BUILDINGNUM.TabIndex = 12;
            this.labA_BUILDINGNUM.Text = "Build Num";
            // 
            // addrStreet
            // 
            this.addrStreet.Location = new System.Drawing.Point(119, 72);
            this.addrStreet.Name = "addrStreet";
            this.addrStreet.ReadOnly = true;
            this.addrStreet.Size = new System.Drawing.Size(220, 20);
            this.addrStreet.TabIndex = 15;
            // 
            // labA_STREET
            // 
            this.labA_STREET.AccessibleName = "Name";
            this.labA_STREET.AutoSize = true;
            this.labA_STREET.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labA_STREET.Location = new System.Drawing.Point(42, 76);
            this.labA_STREET.Name = "labA_STREET";
            this.labA_STREET.Size = new System.Drawing.Size(49, 16);
            this.labA_STREET.TabIndex = 14;
            this.labA_STREET.Text = "Street";
            // 
            // addrTelefon
            // 
            this.addrTelefon.Location = new System.Drawing.Point(119, 46);
            this.addrTelefon.Name = "addrTelefon";
            this.addrTelefon.ReadOnly = true;
            this.addrTelefon.Size = new System.Drawing.Size(220, 20);
            this.addrTelefon.TabIndex = 17;
            this.addrTelefon.TextChanged += new System.EventHandler(this.addrTelefon_TextChanged);
            // 
            // labA_TELEFON
            // 
            this.labA_TELEFON.AccessibleName = "Name";
            this.labA_TELEFON.AutoSize = true;
            this.labA_TELEFON.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labA_TELEFON.Location = new System.Drawing.Point(30, 50);
            this.labA_TELEFON.Name = "labA_TELEFON";
            this.labA_TELEFON.Size = new System.Drawing.Size(61, 16);
            this.labA_TELEFON.TabIndex = 16;
            this.labA_TELEFON.Text = "Telefon";
            this.labA_TELEFON.Click += new System.EventHandler(this.Telefon_Click);
            // 
            // addrDoor
            // 
            this.addrDoor.Location = new System.Drawing.Point(119, 150);
            this.addrDoor.Name = "addrDoor";
            this.addrDoor.ReadOnly = true;
            this.addrDoor.Size = new System.Drawing.Size(220, 20);
            this.addrDoor.TabIndex = 19;
            // 
            // labA_DOORNUM
            // 
            this.labA_DOORNUM.AccessibleName = "LabDoorNum";
            this.labA_DOORNUM.AutoSize = true;
            this.labA_DOORNUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labA_DOORNUM.Location = new System.Drawing.Point(49, 154);
            this.labA_DOORNUM.Name = "labA_DOORNUM";
            this.labA_DOORNUM.Size = new System.Drawing.Size(42, 16);
            this.labA_DOORNUM.TabIndex = 18;
            this.labA_DOORNUM.Text = "Door";
            // 
            // labS_STATUS
            // 
            this.labS_STATUS.AccessibleName = "LabStatus";
            this.labS_STATUS.AutoSize = true;
            this.labS_STATUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labS_STATUS.Location = new System.Drawing.Point(19, 107);
            this.labS_STATUS.Name = "labS_STATUS";
            this.labS_STATUS.Size = new System.Drawing.Size(51, 16);
            this.labS_STATUS.TabIndex = 20;
            this.labS_STATUS.Text = "Status";
            // 
            // shopIdentity
            // 
            this.shopIdentity.Location = new System.Drawing.Point(98, 76);
            this.shopIdentity.Name = "shopIdentity";
            this.shopIdentity.ReadOnly = true;
            this.shopIdentity.Size = new System.Drawing.Size(220, 20);
            this.shopIdentity.TabIndex = 23;
            // 
            // labS_USER_IDENTITY
            // 
            this.labS_USER_IDENTITY.AccessibleName = "Name";
            this.labS_USER_IDENTITY.AutoSize = true;
            this.labS_USER_IDENTITY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labS_USER_IDENTITY.Location = new System.Drawing.Point(12, 81);
            this.labS_USER_IDENTITY.Name = "labS_USER_IDENTITY";
            this.labS_USER_IDENTITY.Size = new System.Drawing.Size(58, 16);
            this.labS_USER_IDENTITY.TabIndex = 22;
            this.labS_USER_IDENTITY.Text = "Identity";
            this.labS_USER_IDENTITY.Click += new System.EventHandler(this.Identity_Click);
            // 
            // addrPostalCode
            // 
            this.addrPostalCode.Location = new System.Drawing.Point(119, 176);
            this.addrPostalCode.Name = "addrPostalCode";
            this.addrPostalCode.ReadOnly = true;
            this.addrPostalCode.Size = new System.Drawing.Size(220, 20);
            this.addrPostalCode.TabIndex = 27;
            // 
            // labA_POSTALCODE
            // 
            this.labA_POSTALCODE.AccessibleName = "labPostalCode";
            this.labA_POSTALCODE.AutoSize = true;
            this.labA_POSTALCODE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labA_POSTALCODE.Location = new System.Drawing.Point(2, 180);
            this.labA_POSTALCODE.Name = "labA_POSTALCODE";
            this.labA_POSTALCODE.Size = new System.Drawing.Size(89, 16);
            this.labA_POSTALCODE.TabIndex = 26;
            this.labA_POSTALCODE.Text = "PostalCode";
            // 
            // addrCity
            // 
            this.addrCity.Location = new System.Drawing.Point(119, 202);
            this.addrCity.Name = "addrCity";
            this.addrCity.ReadOnly = true;
            this.addrCity.Size = new System.Drawing.Size(220, 20);
            this.addrCity.TabIndex = 31;
            // 
            // labA_CITY
            // 
            this.labA_CITY.AccessibleName = "labCity";
            this.labA_CITY.AutoSize = true;
            this.labA_CITY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labA_CITY.Location = new System.Drawing.Point(57, 206);
            this.labA_CITY.Name = "labA_CITY";
            this.labA_CITY.Size = new System.Drawing.Size(34, 16);
            this.labA_CITY.TabIndex = 30;
            this.labA_CITY.Text = "City";
            // 
            // addrProvence
            // 
            this.addrProvence.Location = new System.Drawing.Point(119, 228);
            this.addrProvence.Name = "addrProvence";
            this.addrProvence.ReadOnly = true;
            this.addrProvence.Size = new System.Drawing.Size(220, 20);
            this.addrProvence.TabIndex = 33;
            // 
            // labA_PROVENCE
            // 
            this.labA_PROVENCE.AccessibleName = "labProvence";
            this.labA_PROVENCE.AutoSize = true;
            this.labA_PROVENCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labA_PROVENCE.Location = new System.Drawing.Point(17, 232);
            this.labA_PROVENCE.Name = "labA_PROVENCE";
            this.labA_PROVENCE.Size = new System.Drawing.Size(74, 16);
            this.labA_PROVENCE.TabIndex = 32;
            this.labA_PROVENCE.Text = "Provence";
            // 
            // addrCountry
            // 
            this.addrCountry.Location = new System.Drawing.Point(119, 254);
            this.addrCountry.Name = "addrCountry";
            this.addrCountry.ReadOnly = true;
            this.addrCountry.Size = new System.Drawing.Size(220, 20);
            this.addrCountry.TabIndex = 35;
            // 
            // labA_COUNTRY
            // 
            this.labA_COUNTRY.AccessibleName = "LabCountry";
            this.labA_COUNTRY.AutoSize = true;
            this.labA_COUNTRY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labA_COUNTRY.Location = new System.Drawing.Point(31, 254);
            this.labA_COUNTRY.Name = "labA_COUNTRY";
            this.labA_COUNTRY.Size = new System.Drawing.Size(60, 16);
            this.labA_COUNTRY.TabIndex = 34;
            this.labA_COUNTRY.Text = "Country";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(336, 479);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(104, 37);
            this.btnEdit.TabIndex = 39;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(465, 479);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(104, 37);
            this.Update.TabIndex = 38;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Location = new System.Drawing.Point(188, 479);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 37);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dShops
            // 
            this.dShops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dShops.Location = new System.Drawing.Point(409, 41);
            this.dShops.Name = "dShops";
            this.dShops.Size = new System.Drawing.Size(572, 403);
            this.dShops.TabIndex = 40;
            this.dShops.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dShops_RowHeaderMouseClick);
            // 
            // searchKeyword
            // 
            this.searchKeyword.Location = new System.Drawing.Point(535, 13);
            this.searchKeyword.Name = "searchKeyword";
            this.searchKeyword.Size = new System.Drawing.Size(379, 20);
            this.searchKeyword.TabIndex = 41;
            this.searchKeyword.TextChanged += new System.EventHandler(this.SearchLab_SelectedIndexChanged);
            // 
            // Search
            // 
            this.Search.AccessibleName = "Name";
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(406, 14);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(57, 16);
            this.Search.TabIndex = 42;
            this.Search.Text = "Search";
            // 
            // shopStatus
            // 
            this.shopStatus.Enabled = false;
            this.shopStatus.FormattingEnabled = true;
            this.shopStatus.Items.AddRange(new object[] {
            "Active",
            "Deactive"});
            this.shopStatus.Location = new System.Drawing.Point(98, 102);
            this.shopStatus.Name = "shopStatus";
            this.shopStatus.Size = new System.Drawing.Size(220, 21);
            this.shopStatus.TabIndex = 43;
            // 
            // addrId
            // 
            this.addrId.Location = new System.Drawing.Point(119, 19);
            this.addrId.Name = "addrId";
            this.addrId.ReadOnly = true;
            this.addrId.Size = new System.Drawing.Size(95, 20);
            this.addrId.TabIndex = 46;
            // 
            // Srarch
            // 
            this.Srarch.Location = new System.Drawing.Point(594, 479);
            this.Srarch.Name = "Srarch";
            this.Srarch.Size = new System.Drawing.Size(104, 37);
            this.Srarch.TabIndex = 47;
            this.Srarch.Text = "Search";
            this.Srarch.UseVisualStyleBackColor = true;
            this.Srarch.Click += new System.EventHandler(this.Srarch_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(723, 479);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(104, 37);
            this.Refresh.TabIndex = 48;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // OrderBy
            // 
            this.OrderBy.FormattingEnabled = true;
            this.OrderBy.Items.AddRange(new object[] {
            "ASC",
            "DESC"});
            this.OrderBy.Location = new System.Drawing.Point(920, 13);
            this.OrderBy.Name = "OrderBy";
            this.OrderBy.Size = new System.Drawing.Size(61, 21);
            this.OrderBy.TabIndex = 50;
            this.OrderBy.SelectedIndexChanged += new System.EventHandler(this.SearchLab_SelectedIndexChanged);
            // 
            // SearchLab
            // 
            this.SearchLab.FormattingEnabled = true;
            this.SearchLab.Location = new System.Drawing.Point(467, 12);
            this.SearchLab.Name = "SearchLab";
            this.SearchLab.Size = new System.Drawing.Size(62, 21);
            this.SearchLab.TabIndex = 49;
            this.SearchLab.SelectedIndexChanged += new System.EventHandler(this.SearchLab_SelectedIndexChanged);
            // 
            // groupAddr
            // 
            this.groupAddr.Controls.Add(this.addrIdLab);
            this.groupAddr.Controls.Add(this.addrCountry);
            this.groupAddr.Controls.Add(this.labA_COUNTRY);
            this.groupAddr.Controls.Add(this.addrProvence);
            this.groupAddr.Controls.Add(this.labA_PROVENCE);
            this.groupAddr.Controls.Add(this.addrCity);
            this.groupAddr.Controls.Add(this.addrId);
            this.groupAddr.Controls.Add(this.labA_CITY);
            this.groupAddr.Controls.Add(this.addrPostalCode);
            this.groupAddr.Controls.Add(this.labA_POSTALCODE);
            this.groupAddr.Controls.Add(this.addrDoor);
            this.groupAddr.Controls.Add(this.labA_DOORNUM);
            this.groupAddr.Controls.Add(this.addrFloor);
            this.groupAddr.Controls.Add(this.labA_FLOOR);
            this.groupAddr.Controls.Add(this.addrBuildingNum);
            this.groupAddr.Controls.Add(this.labA_BUILDINGNUM);
            this.groupAddr.Controls.Add(this.addrStreet);
            this.groupAddr.Controls.Add(this.labA_STREET);
            this.groupAddr.Controls.Add(this.addrTelefon);
            this.groupAddr.Controls.Add(this.labA_TELEFON);
            this.groupAddr.Location = new System.Drawing.Point(28, 175);
            this.groupAddr.Name = "groupAddr";
            this.groupAddr.Size = new System.Drawing.Size(346, 281);
            this.groupAddr.TabIndex = 51;
            this.groupAddr.TabStop = false;
            this.groupAddr.Text = "Address";
            // 
            // addrIdLab
            // 
            this.addrIdLab.AccessibleName = "Name";
            this.addrIdLab.AutoSize = true;
            this.addrIdLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addrIdLab.Location = new System.Drawing.Point(70, 23);
            this.addrIdLab.Name = "addrIdLab";
            this.addrIdLab.Size = new System.Drawing.Size(21, 16);
            this.addrIdLab.TabIndex = 52;
            this.addrIdLab.Text = "Id";
            // 
            // groupShop
            // 
            this.groupShop.Controls.Add(this.shopIdtxt);
            this.groupShop.Controls.Add(this.catelogId);
            this.groupShop.Controls.Add(this.shopName);
            this.groupShop.Controls.Add(this.labS_NAME);
            this.groupShop.Controls.Add(this.shopIdentity);
            this.groupShop.Controls.Add(this.shopStatus);
            this.groupShop.Controls.Add(this.labS_USER_IDENTITY);
            this.groupShop.Controls.Add(this.labS_STATUS);
            this.groupShop.Location = new System.Drawing.Point(33, 26);
            this.groupShop.Name = "groupShop";
            this.groupShop.Size = new System.Drawing.Size(325, 143);
            this.groupShop.TabIndex = 52;
            this.groupShop.TabStop = false;
            this.groupShop.Text = "Shop";
            // 
            // Shops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1124, 528);
            this.Controls.Add(this.groupShop);
            this.Controls.Add(this.groupAddr);
            this.Controls.Add(this.OrderBy);
            this.Controls.Add(this.SearchLab);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Srarch);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.searchKeyword);
            this.Controls.Add(this.dShops);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.btnAdd);
            this.Name = "Shops";
            this.Text = "Shops";
            this.Load += new System.EventHandler(this.Shops_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dShops)).EndInit();
            this.groupAddr.ResumeLayout(false);
            this.groupAddr.PerformLayout();
            this.groupShop.ResumeLayout(false);
            this.groupShop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox shopName;
        private System.Windows.Forms.Label labS_NAME;
        private System.Windows.Forms.TextBox shopIdtxt;
        private System.Windows.Forms.Label catelogId;
        private System.Windows.Forms.TextBox addrFloor;
        private System.Windows.Forms.Label labA_FLOOR;
        private System.Windows.Forms.TextBox addrBuildingNum;
        private System.Windows.Forms.Label labA_BUILDINGNUM;
        private System.Windows.Forms.TextBox addrStreet;
        private System.Windows.Forms.Label labA_STREET;
        private System.Windows.Forms.TextBox addrTelefon;
        private System.Windows.Forms.Label labA_TELEFON;
        private System.Windows.Forms.TextBox addrDoor;
        private System.Windows.Forms.Label labA_DOORNUM;
        private System.Windows.Forms.Label labS_STATUS;
        private System.Windows.Forms.TextBox shopIdentity;
        private System.Windows.Forms.Label labS_USER_IDENTITY;
        private System.Windows.Forms.TextBox addrPostalCode;
        private System.Windows.Forms.Label labA_POSTALCODE;
        private System.Windows.Forms.TextBox addrCity;
        private System.Windows.Forms.Label labA_CITY;
        private System.Windows.Forms.TextBox addrProvence;
        private System.Windows.Forms.Label labA_PROVENCE;
        private System.Windows.Forms.TextBox addrCountry;
        private System.Windows.Forms.Label labA_COUNTRY;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dShops;
        private System.Windows.Forms.TextBox searchKeyword;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.ComboBox shopStatus;
        private System.Windows.Forms.TextBox addrId;
        private System.Windows.Forms.Button Srarch;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.ComboBox OrderBy;
        private System.Windows.Forms.ComboBox SearchLab;
        private System.Windows.Forms.GroupBox groupAddr;
        private System.Windows.Forms.GroupBox groupShop;
        private System.Windows.Forms.Label addrIdLab;
    }
}