namespace Shop_TPV.Pages
{
    partial class Catelogs
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
            this.catelogNametxt = new System.Windows.Forms.TextBox();
            this.catelogDestxt = new System.Windows.Forms.TextBox();
            this.labDESCRIPTION = new System.Windows.Forms.Label();
            this.labNAME = new System.Windows.Forms.Label();
            this.CatelogIdtxt = new System.Windows.Forms.TextBox();
            this.labID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.catelogDto = new System.Windows.Forms.TextBox();
            this.labDTO = new System.Windows.Forms.Label();
            this.catelogStatus = new System.Windows.Forms.ComboBox();
            this.labSTATUS = new System.Windows.Forms.Label();
            this.Refresh = new System.Windows.Forms.Button();
            this.Srarch = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.OrderBy = new System.Windows.Forms.ComboBox();
            this.SearchLab = new System.Windows.Forms.ComboBox();
            this.Search = new System.Windows.Forms.Label();
            this.searchKeyword = new System.Windows.Forms.TextBox();
            this.dtCatelog = new System.Windows.Forms.DataGridView();
            this.Update = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtCatelog)).BeginInit();
            this.SuspendLayout();
            // 
            // catelogNametxt
            // 
            this.catelogNametxt.Location = new System.Drawing.Point(103, 50);
            this.catelogNametxt.Name = "catelogNametxt";
            this.catelogNametxt.ReadOnly = true;
            this.catelogNametxt.Size = new System.Drawing.Size(176, 20);
            this.catelogNametxt.TabIndex = 11;
            // 
            // catelogDestxt
            // 
            this.catelogDestxt.Location = new System.Drawing.Point(103, 150);
            this.catelogDestxt.Multiline = true;
            this.catelogDestxt.Name = "catelogDestxt";
            this.catelogDestxt.ReadOnly = true;
            this.catelogDestxt.Size = new System.Drawing.Size(176, 79);
            this.catelogDestxt.TabIndex = 10;
            // 
            // labDESCRIPTION
            // 
            this.labDESCRIPTION.AccessibleName = "Name";
            this.labDESCRIPTION.AutoSize = true;
            this.labDESCRIPTION.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDESCRIPTION.Location = new System.Drawing.Point(3, 150);
            this.labDESCRIPTION.Name = "labDESCRIPTION";
            this.labDESCRIPTION.Size = new System.Drawing.Size(87, 16);
            this.labDESCRIPTION.TabIndex = 9;
            this.labDESCRIPTION.Text = "Description";
            // 
            // labNAME
            // 
            this.labNAME.AccessibleName = "Name";
            this.labNAME.AutoSize = true;
            this.labNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNAME.Location = new System.Drawing.Point(3, 50);
            this.labNAME.Name = "labNAME";
            this.labNAME.Size = new System.Drawing.Size(49, 16);
            this.labNAME.TabIndex = 8;
            this.labNAME.Text = "Name";
            // 
            // CatelogIdtxt
            // 
            this.CatelogIdtxt.Location = new System.Drawing.Point(103, 15);
            this.CatelogIdtxt.Name = "CatelogIdtxt";
            this.CatelogIdtxt.ReadOnly = true;
            this.CatelogIdtxt.Size = new System.Drawing.Size(176, 20);
            this.CatelogIdtxt.TabIndex = 7;
            // 
            // labID
            // 
            this.labID.AccessibleName = "Name";
            this.labID.AutoSize = true;
            this.labID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labID.Location = new System.Drawing.Point(3, 19);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(21, 16);
            this.labID.TabIndex = 6;
            this.labID.Text = "Id";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.catelogDto);
            this.groupBox1.Controls.Add(this.labDTO);
            this.groupBox1.Controls.Add(this.catelogStatus);
            this.groupBox1.Controls.Add(this.labSTATUS);
            this.groupBox1.Controls.Add(this.catelogDestxt);
            this.groupBox1.Controls.Add(this.catelogNametxt);
            this.groupBox1.Controls.Add(this.labID);
            this.groupBox1.Controls.Add(this.CatelogIdtxt);
            this.groupBox1.Controls.Add(this.labDESCRIPTION);
            this.groupBox1.Controls.Add(this.labNAME);
            this.groupBox1.Location = new System.Drawing.Point(32, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 263);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Catelogs";
            // 
            // catelogDto
            // 
            this.catelogDto.Location = new System.Drawing.Point(103, 113);
            this.catelogDto.Name = "catelogDto";
            this.catelogDto.ReadOnly = true;
            this.catelogDto.Size = new System.Drawing.Size(176, 20);
            this.catelogDto.TabIndex = 47;
            // 
            // labDTO
            // 
            this.labDTO.AccessibleName = "Name";
            this.labDTO.AutoSize = true;
            this.labDTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDTO.Location = new System.Drawing.Point(3, 113);
            this.labDTO.Name = "labDTO";
            this.labDTO.Size = new System.Drawing.Size(32, 16);
            this.labDTO.TabIndex = 46;
            this.labDTO.Text = "Dto";
            // 
            // catelogStatus
            // 
            this.catelogStatus.Enabled = false;
            this.catelogStatus.FormattingEnabled = true;
            this.catelogStatus.Items.AddRange(new object[] {
            "Active",
            "Deactive"});
            this.catelogStatus.Location = new System.Drawing.Point(103, 76);
            this.catelogStatus.Name = "catelogStatus";
            this.catelogStatus.Size = new System.Drawing.Size(176, 21);
            this.catelogStatus.TabIndex = 45;
            // 
            // labSTATUS
            // 
            this.labSTATUS.AccessibleName = "LabStatus";
            this.labSTATUS.AutoSize = true;
            this.labSTATUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSTATUS.Location = new System.Drawing.Point(3, 81);
            this.labSTATUS.Name = "labSTATUS";
            this.labSTATUS.Size = new System.Drawing.Size(51, 16);
            this.labSTATUS.TabIndex = 44;
            this.labSTATUS.Text = "Status";
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(702, 440);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(104, 37);
            this.Refresh.TabIndex = 53;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Srarch
            // 
            this.Srarch.Location = new System.Drawing.Point(573, 440);
            this.Srarch.Name = "Srarch";
            this.Srarch.Size = new System.Drawing.Size(104, 37);
            this.Srarch.TabIndex = 52;
            this.Srarch.Text = "Search";
            this.Srarch.UseVisualStyleBackColor = true;
            this.Srarch.Click += new System.EventHandler(this.Srarch_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(315, 440);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(104, 37);
            this.btnEdit.TabIndex = 51;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Location = new System.Drawing.Point(167, 440);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 37);
            this.btnAdd.TabIndex = 49;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // OrderBy
            // 
            this.OrderBy.FormattingEnabled = true;
            this.OrderBy.Items.AddRange(new object[] {
            "ASC",
            "DESC"});
            this.OrderBy.Location = new System.Drawing.Point(1129, 16);
            this.OrderBy.Name = "OrderBy";
            this.OrderBy.Size = new System.Drawing.Size(84, 21);
            this.OrderBy.TabIndex = 58;
            this.OrderBy.SelectedIndexChanged += new System.EventHandler(this.SearchLab_SelectedIndexChanged);
            // 
            // SearchLab
            // 
            this.SearchLab.FormattingEnabled = true;
            this.SearchLab.Location = new System.Drawing.Point(521, 15);
            this.SearchLab.Name = "SearchLab";
            this.SearchLab.Size = new System.Drawing.Size(89, 21);
            this.SearchLab.TabIndex = 57;
            this.SearchLab.SelectedIndexChanged += new System.EventHandler(this.SearchLab_SelectedIndexChanged);
            // 
            // Search
            // 
            this.Search.AccessibleName = "Name";
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(458, 17);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(57, 16);
            this.Search.TabIndex = 56;
            this.Search.Text = "Search";
            // 
            // searchKeyword
            // 
            this.searchKeyword.Location = new System.Drawing.Point(616, 16);
            this.searchKeyword.Name = "searchKeyword";
            this.searchKeyword.Size = new System.Drawing.Size(507, 20);
            this.searchKeyword.TabIndex = 55;
            this.searchKeyword.TextChanged += new System.EventHandler(this.SearchLab_SelectedIndexChanged);
            // 
            // dtCatelog
            // 
            this.dtCatelog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCatelog.Location = new System.Drawing.Point(461, 44);
            this.dtCatelog.Name = "dtCatelog";
            this.dtCatelog.Size = new System.Drawing.Size(752, 314);
            this.dtCatelog.TabIndex = 54;
            this.dtCatelog.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtCatelog_RowHeaderMouseClick);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(443, 440);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(104, 37);
            this.Update.TabIndex = 59;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Catelogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 499);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.OrderBy);
            this.Controls.Add(this.SearchLab);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.searchKeyword);
            this.Controls.Add(this.dtCatelog);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Srarch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Name = "Catelogs";
            this.Text = "Catelogs";
            this.Load += new System.EventHandler(this.Catelogs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtCatelog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox catelogNametxt;
        private System.Windows.Forms.TextBox catelogDestxt;
        private System.Windows.Forms.Label labDESCRIPTION;
        private System.Windows.Forms.Label labNAME;
        private System.Windows.Forms.TextBox CatelogIdtxt;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button Srarch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox OrderBy;
        private System.Windows.Forms.ComboBox SearchLab;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.TextBox searchKeyword;
        private System.Windows.Forms.DataGridView dtCatelog;
        private System.Windows.Forms.TextBox catelogDto;
        private System.Windows.Forms.Label labDTO;
        private System.Windows.Forms.ComboBox catelogStatus;
        private System.Windows.Forms.Label labSTATUS;
        private System.Windows.Forms.Button Update;
    }
}