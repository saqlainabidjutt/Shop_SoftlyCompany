using Shop_TPV.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Shop_TPV.Pages
{
    public partial class Productes : Form
    {
        private Product prod = new Product();
        private DataTable dtProd;
        private Catelog cate = new Catelog();
        private DataTable dtCate;
        private bool FreadOnly = false;
        private string searchLbTxt = "";
        public Productes()
        {
            InitializeComponent();
        }
        private void RefreshData()
        {
            dtProd = prod.Select();
            dtProduct.DataSource = dtProd;
        }
        private void Productes_Load(object sender, EventArgs e)
        {
            RefreshData();
            List<Label> labels = this.groupBoxProd.Controls.OfType<Label>().ToList();
            ValuesCambo(labels, "load");
            //fill camboBox with Catelog
            dtCate = cate.Select();
            ProdCatelog.DataSource = dtCate;
            ProdCatelog.DisplayMember = "Name";
            ProdCatelog.ValueMember = "Id";
        }

        private bool permission()
        {
            return this.FreadOnly;
        }
        private void ReadOnlyAct(List<TextBox> txtbxs, bool act)
        {
            foreach (var txtbx in txtbxs)
            {
                txtbx.ReadOnly = act;
            }
            ProdStatus.Enabled = !act;
            ProdCatelog
                .Enabled = !act;
            ProdIdtxt.ReadOnly = true;
        }
        private String ValidateData(Product p, string operation)
        {
            string err = "OK";
            if (operation == "add" || operation == "update")
            {
                if (p.Name == "")
                {
                    err = "Name is  a required Field.";
                }
                if (p.Status == "")
                {
                    err = "Status is  a required Field.";
                }
                if (p.ISBN == "")
                {
                    err = "ISBN is  a required Field.";
                }

                if (p.Price <= 0)
                {
                    err = "Price is  a required Field.";
                }
                if (p.FamiID <= 0)
                {
                    err = "Catelog is  a required Field.";
                }
                if (operation == "search")
                {
                    if (p.Name == "" && p.Status == "" && p.ISBN == "" && p.Price == 0 && p.Tex==0 && p.Stock == 0 && p.Dto == 0 && p.FamiID == 0)
                    {
                        err = "Write something to perfourm search.";
                    }
                }
            }
            return err;
        }
        private Product GetProductsValues()
        {
            Product prod = new Product();
            prod.Name = ProdNametxt.Text;
            prod.ISBN = ProdISBNtxt.Text;
            if (ProdPricetxt.Text != "")
            {
                prod.Price = Convert.ToSingle(ProdPricetxt.Text);
            }
            if (ProdTextxt.Text != "")
            {
                prod.Tex = Convert.ToSingle(ProdTextxt.Text);
            }
            if (ProdStocktxt.Text != "")
            {
                prod.Stock = Convert.ToInt32(ProdStocktxt.Text);
            }
            if (ProdDtotxt.Text != "")
            {
                prod.Dto = Convert.ToSingle(ProdDtotxt.Text);
            }
            prod.Status = ProdStatus.Text;
            if (ProdCatelog.Text != "")
            {
                prod.FamiID = Convert.ToInt32(ProdCatelog.SelectedValue.ToString());
            }
            return prod;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (permission())
            {
                Product p = new Product();
                p = GetProductsValues();
                string validation = ValidateData(p, "add");
                if (validation == "OK")
                {
                    bool success = p.Insert(p);
                    if (success)
                    {
                        clear();
                        RefreshData();
                        MessageBox.Show("Product Inserted Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                    }
                }
                else
                {
                    MessageBox.Show(validation);
                }
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
            List<TextBox> txtbxs = this.groupBoxProd.Controls.OfType<TextBox>().ToList();
            clear(txtbxs);
            //do Not Remove
            ProdStatus.Text = "";
            searchKeyword.Text = "";
            SearchLab.Text = "";
            OrderBy.Text = "";

        }
        private void groupBoxProd_Enter(object sender, EventArgs e)
        {

        }

        private void labSTATUS_Click(object sender, EventArgs e)
        {

        }

        private void ProdStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<TextBox> txtbxs = this.groupBoxProd.Controls.OfType<TextBox>().ToList();
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

        private void Update_Click(object sender, EventArgs e)
        {
            if (permission())
            {

                Product p = new Product();
                if (ProdIdtxt.Text != "")
                {
                    p = GetProductsValues();
                    p.Id = Convert.ToInt32(ProdIdtxt.Text);
                    string validation = ValidateData(p, "update");
                    if (validation == "OK")
                    {
                        bool success = p.Update(p);
                        if (success)
                        {
                            clear();
                            RefreshData();
                            MessageBox.Show("Product Updated Successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Error! in Updated Product.");
                        }
                    }
                    else
                    {
                        MessageBox.Show(validation);
                    }
                }
                else
                {
                    MessageBox.Show("Product not Exist!");
                }
            }
        }

        private void Srarch_Click(object sender, EventArgs e)
        {
            if (permission())
            {
                Product c = new Product();
                c = GetProductsValues();
                string validation = ValidateData(c, "search");
                if (validation == "OK")
                {
                    dtProd = c.Search(c);
                }
                else
                {
                    MessageBox.Show(validation);
                }
                dtProduct.DataSource = dtProd;
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

                    int Place = tmp.IndexOf("_");
                    string result = "";
                    if (Place > 0) { 
                         result = tmp.Remove(Place, 1).Insert(Place, ".");
                    }
                    this.searchLbTxt = result;
                }
            }
        }
        private void DoSearch()
        {
            List<Label> labels = this.groupBoxProd.Controls.OfType<Label>().ToList();
            ValuesCambo(labels, "search");

            dtProd = prod.Search(this.searchLbTxt, searchKeyword.Text, OrderBy.GetItemText(OrderBy.SelectedItem));
            dtProduct.DataSource = dtProd;
            this.searchLbTxt = "";
        }
        private void Refresh_Click(object sender, EventArgs e)
        {
            clear();
            RefreshData();
        }

        private void dtCatelog_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row_ind = e.RowIndex;
            ProdIdtxt.Text = dtProduct.Rows[row_ind].Cells[0].Value.ToString();
            ProdNametxt.Text = dtProduct.Rows[row_ind].Cells[1].Value.ToString();
            ProdISBNtxt.Text = dtProduct.Rows[row_ind].Cells[2].Value.ToString();
            ProdPricetxt.Text = dtProduct.Rows[row_ind].Cells[3].Value.ToString();
            ProdTextxt.Text = dtProduct.Rows[row_ind].Cells[4].Value.ToString();
            ProdStocktxt.Text = dtProduct.Rows[row_ind].Cells[5].Value.ToString();
            ProdDtotxt.Text = dtProduct.Rows[row_ind].Cells[6].Value.ToString();
            ProdStatus.Text = dtProduct.Rows[row_ind].Cells[7].Value.ToString();
            ProdCatelog.Text = dtProduct.Rows[row_ind].Cells[8].Value.ToString();
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
            if (searchKeyword.Text != "" && SearchLab.GetItemText(SearchLab.SelectedItem) == "" && OrderBy.GetItemText(OrderBy.SelectedItem) == "")
            {
                DoSearch();
            }
        }
    }
}
