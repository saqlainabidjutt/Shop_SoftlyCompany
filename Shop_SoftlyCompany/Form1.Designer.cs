namespace Shop_SoftlyCompany
{
    partial class Form1
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
            this.catelogId = new System.Windows.Forms.Label();
            this.CatelogIdtxt = new System.Windows.Forms.TextBox();
            this.catelogName = new System.Windows.Forms.Label();
            this.catelogDes = new System.Windows.Forms.Label();
            this.catelogDestxt = new System.Windows.Forms.TextBox();
            this.catelogNametxt = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // catelogId
            // 
            this.catelogId.AccessibleName = "Name";
            this.catelogId.AutoSize = true;
            this.catelogId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catelogId.Location = new System.Drawing.Point(101, 83);
            this.catelogId.Name = "catelogId";
            this.catelogId.Size = new System.Drawing.Size(21, 16);
            this.catelogId.TabIndex = 0;
            this.catelogId.Text = "Id";
            // 
            // CatelogIdtxt
            // 
            this.CatelogIdtxt.Location = new System.Drawing.Point(255, 79);
            this.CatelogIdtxt.Name = "CatelogIdtxt";
            this.CatelogIdtxt.ReadOnly = true;
            this.CatelogIdtxt.Size = new System.Drawing.Size(173, 20);
            this.CatelogIdtxt.TabIndex = 1;
            this.CatelogIdtxt.TextChanged += new System.EventHandler(this.CatelogIdtxt_TextChanged);
            // 
            // catelogName
            // 
            this.catelogName.AccessibleName = "Name";
            this.catelogName.AutoSize = true;
            this.catelogName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catelogName.Location = new System.Drawing.Point(101, 114);
            this.catelogName.Name = "catelogName";
            this.catelogName.Size = new System.Drawing.Size(49, 16);
            this.catelogName.TabIndex = 2;
            this.catelogName.Text = "Name";
            // 
            // catelogDes
            // 
            this.catelogDes.AccessibleName = "Name";
            this.catelogDes.AutoSize = true;
            this.catelogDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catelogDes.Location = new System.Drawing.Point(101, 152);
            this.catelogDes.Name = "catelogDes";
            this.catelogDes.Size = new System.Drawing.Size(87, 16);
            this.catelogDes.TabIndex = 3;
            this.catelogDes.Text = "Description";
            // 
            // catelogDestxt
            // 
            this.catelogDestxt.Location = new System.Drawing.Point(255, 152);
            this.catelogDestxt.Multiline = true;
            this.catelogDestxt.Name = "catelogDestxt";
            this.catelogDestxt.Size = new System.Drawing.Size(173, 79);
            this.catelogDestxt.TabIndex = 4;
            // 
            // catelogNametxt
            // 
            this.catelogNametxt.Location = new System.Drawing.Point(255, 114);
            this.catelogNametxt.Name = "catelogNametxt";
            this.catelogNametxt.Size = new System.Drawing.Size(173, 20);
            this.catelogNametxt.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.Location = new System.Drawing.Point(140, 283);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 37);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(417, 283);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(104, 37);
            this.Update.TabIndex = 7;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(277, 283);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 37);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.catelogNametxt);
            this.Controls.Add(this.catelogDestxt);
            this.Controls.Add(this.catelogDes);
            this.Controls.Add(this.catelogName);
            this.Controls.Add(this.CatelogIdtxt);
            this.Controls.Add(this.catelogId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Catelog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label catelogId;
        private System.Windows.Forms.TextBox CatelogIdtxt;
        private System.Windows.Forms.Label catelogName;
        private System.Windows.Forms.TextBox catelogDestxt;
        private System.Windows.Forms.TextBox catelogNametxt;
        private System.Windows.Forms.Label catelogDes;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button btnDelete;
    }
}

