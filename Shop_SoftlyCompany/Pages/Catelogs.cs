using Shop_TPV.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_SoftlyCompany.Pages
{
    public partial class Catelogs : Form
    {
        public Catelogs()
        {
            InitializeComponent();
        }
        Catelog catelog = new Catelog();
        DataTable dtCate;
        bool FreadOnly = false;
        private string searchLbTxt = "";
        private void RefreshData()
        {
            dtCate = catelog.Select();
            dtCatelog.DataSource = dtCate;
        }
        private bool permission()
        {
            return this.FreadOnly;
        }
        private Catelog getCatelogsValues()
        {
            Catelog cate = new Catelog();
            cate.Name = catelogNametxt.Text;
            cate.Description = catelogDestxt.Text;
            cate.Dto = Convert.ToSingle(catelogDto.Text);
            cate.Status = catelogStatus.Text;
            return cate;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (permission())
            {
                Catelog c = new Catelog();
                c = getCatelogsValues();
                bool success = c.Insert(c);
                if (success)
                {
                    clear();
                    RefreshData();
                    MessageBox.Show("Catelog Inserted Successfully!");
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }
        }
        private void ValuesCambo(List<Label> labels, String action)
        {
            foreach (var lbl in labels)
            {
                if (lbl.Name.StartsWith("lab") && action == "load")
                {
                    SearchLab.Items.Add(lbl.Text);
                }
                if (lbl.Text == SearchLab.GetItemText(SearchLab.SelectedItem) && action == "search")
                {
                    //.GetItemText(this.ComboBox.SelectedItem)
                    var tmp = lbl.Name.Substring(3);
                    this.searchLbTxt = tmp;
                }
            }
        }
        private void Catelogs_Load(object sender, EventArgs e)
        {
            RefreshData();
            List<Label> labels = this.groupBox1.Controls.OfType<Label>().ToList();
            ValuesCambo(labels, "load");
        }

        private void ReadOnlyAct(List<TextBox> txtbxs, bool act)
        {
            foreach (var txtbx in txtbxs)
            {
                txtbx.ReadOnly = act;
            }
            catelogStatus.Enabled = !act;
            CatelogIdtxt.ReadOnly = true;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<TextBox> txtbxs = this.groupBox1.Controls.OfType<TextBox>().ToList();
            ReadOnlyAct(txtbxs, FreadOnly);
            if (FreadOnly)
            {
                this.FreadOnly = false;
            }
            else
            {
                this.FreadOnly = true;
            }
        }
        private void clear(List<TextBox> txtbxs)
        {
            foreach (var txtbx in txtbxs)
            {
                txtbx.Text = "";
            }
        }
        private void clear()
        {
            List<TextBox> txtbxs = this.groupBox1.Controls.OfType<TextBox>().ToList();
            clear(txtbxs);
            catelogStatus.Text = "";
            searchKeyword.Text = "";
            SearchLab.Text = "";
            OrderBy.Text = "";

        }
        private void Refresh_Click(object sender, EventArgs e)
        {
            clear();
            RefreshData();
        }

        private void dtCatelog_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row_ind = e.RowIndex;
            CatelogIdtxt.Text = dtCatelog.Rows[row_ind].Cells[0].Value.ToString();
            catelogNametxt.Text = dtCatelog.Rows[row_ind].Cells[1].Value.ToString();
            catelogStatus.Text = dtCatelog.Rows[row_ind].Cells[2].Value.ToString();
            catelogDto.Text = dtCatelog.Rows[row_ind].Cells[3].Value.ToString();
            catelogDestxt.Text = dtCatelog.Rows[row_ind].Cells[4].Value.ToString();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (permission())
            {
                    Catelog c = new Catelog();
                    c = getCatelogsValues();
                    c.Id = Convert.ToInt32(CatelogIdtxt.Text);
                    bool success = c.Update(c);
                    if (success)
                    {
                        clear();
                        RefreshData();
                        MessageBox.Show("Catelog Updated Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error! in Updated Shop");
                    }
            }
        }

        private void Srarch_Click_1(object sender, EventArgs e)
        {
            if (permission())
            {
                Catelog c = new Catelog();
                c = getCatelogsValues();
                dtCate = c.Search(c);
                dtCatelog.DataSource = dtCate;
            }
        }
        private void DoSearch()
        {
            List<Label> labels = this.groupBox1.Controls.OfType<Label>().ToList();
            ValuesCambo(labels, "search");
            dtCate = catelog.Search(this.searchLbTxt, searchKeyword.Text, OrderBy.GetItemText(OrderBy.SelectedItem));
            dtCatelog.DataSource = dtCate;
            this.searchLbTxt = "";
        }
        private void SearchLab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchLab.GetItemText(SearchLab.SelectedItem) != "" && searchKeyword.Text != "")
            {
                DoSearch();
            }
            if (SearchLab.GetItemText(SearchLab.SelectedItem) != "" && OrderBy.GetItemText(OrderBy.SelectedItem) != "")
            {
                DoSearch();
            }
        }
    }
}
