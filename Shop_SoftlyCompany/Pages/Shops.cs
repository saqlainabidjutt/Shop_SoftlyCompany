using Shop_SoftlyCompany.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_TPV.Pages
{
    public partial class Shops : Form
    {
        Shop sh = new Shop();
        DataTable dtShop;
        bool FreadOnly = false;
        private string searchLbTxt = "";
        public Shops()
        {
            InitializeComponent();
        }
        private void RefreshData()
        {
            dtShop = sh.Select();
            dShops.DataSource = dtShop;
        }
        private void ValuesCambo(List<Label> labels,String action)
        {
            foreach (var lbl in labels)
            {
                if (lbl.Name.StartsWith("lab") && action=="load")
                {
                    SearchLab.Items.Add(lbl.Text);
                }
                if (lbl.Text== SearchLab.GetItemText(SearchLab.SelectedItem) && action == "search")
                {
                    //.GetItemText(this.ComboBox.SelectedItem)
                    var tmp = lbl.Name.Substring(3);
                    int Place = tmp.IndexOf("_");
                    string result = tmp.Remove(Place, 1).Insert(Place, ".");
                    this.searchLbTxt = result;
                }
            }
        }
        private void Shops_Load(object sender, EventArgs e)
        {
            RefreshData();
            List<Label> labels = this.groupShop.Controls.OfType<Label>().ToList();
            ValuesCambo(labels,"load");
            labels = this.groupAddr.Controls.OfType<Label>().ToList();
            ValuesCambo(labels, "load");
        }
        private bool permission()
        {
            return this.FreadOnly;
        }
        private Address getAdressValues()
        {
            Address addr = new Address();
            addr.telefone = addrTelefon.Text;
            addr.street = addrStreet.Text;
            addr.buildingNo = addrBuildingNum.Text;
            addr.floor = addrFloor.Text;
            addr.door = addrDoor.Text;
            addr.postalCode = addrPostalCode.Text;
            addr.city = addrCity.Text;
            addr.provenc = addrProvence.Text;
            addr.country = addrCountry.Text;
            return addr;
        }
        private Shop getShopValues()
        {
            Shop s = new Shop();
            s.name = shopName.Text;
            s.identity = shopIdentity.Text;
            s.status = shopStatus.Text;
            s.role = "Shop";
            return s;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (permission()) { 
                Address addr = new Address();
                addr = getAdressValues();
                long addrId = addr.Insert(addr);
                if (addrId!=0)
                {
                    Shop s = new Shop();
                    s = getShopValues();
                    s.addrId = (int)addrId;
                    bool success = s.Insert(s);
                    if(success)
                    {
                        clear();
                        RefreshData();
                        MessageBox.Show("Shop Inserted Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error! in Shop");
                    }
                }
                else
                {
                    MessageBox.Show("Error in Addr!");
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
            List<TextBox> txtbxs = this.groupShop.Controls.OfType<TextBox>().ToList();
            clear(txtbxs);
            txtbxs = this.groupAddr.Controls.OfType<TextBox>().ToList();
            clear(txtbxs);
            shopStatus.Text = "";
            searchKeyword.Text = "";
            SearchLab.Text = "";
            OrderBy.Text = "";

        }
        private void dShops_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row_ind = e.RowIndex;
            shopIdtxt.Text = dShops.Rows[row_ind].Cells[0].Value.ToString();
            addrId.Text = dShops.Rows[row_ind].Cells[13].Value.ToString();
            shopName.Text = dShops.Rows[row_ind].Cells[1].Value.ToString();
            shopIdentity.Text = dShops.Rows[row_ind].Cells[2].Value.ToString();
            shopStatus.Text = dShops.Rows[row_ind].Cells[3].Value.ToString();
            addrTelefon.Text = dShops.Rows[row_ind].Cells[4].Value.ToString();
            addrStreet.Text = dShops.Rows[row_ind].Cells[5].Value.ToString();
            addrBuildingNum.Text = dShops.Rows[row_ind].Cells[6].Value.ToString();
            addrFloor.Text = dShops.Rows[row_ind].Cells[7].Value.ToString();
            addrDoor.Text = dShops.Rows[row_ind].Cells[8].Value.ToString();
            addrPostalCode.Text = dShops.Rows[row_ind].Cells[9].Value.ToString();
            addrCity.Text = dShops.Rows[row_ind].Cells[10].Value.ToString();
            addrProvence.Text = dShops.Rows[row_ind].Cells[11].Value.ToString();
            addrCountry.Text = dShops.Rows[row_ind].Cells[12].Value.ToString();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (permission())
            {
                Address addr = new Address();
                addr = getAdressValues();
                addr.Id = Convert.ToInt32(addrId.Text);
                if (addr.Update(addr))
                {
                    Shop s = new Shop();
                    s = getShopValues();
                    s.Id = Convert.ToInt32(shopIdtxt.Text);
                    bool success = s.Update(s);
                    if (success)
                    {
                        clear();
                        RefreshData();
                        MessageBox.Show("Shop Updated Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error! in Updated Shop");
                    }
                }
                else
                {
                    MessageBox.Show("Error in Updated Addr Shop !");
                }
            }
        }

        private void Srarch_Click(object sender, EventArgs e)
        {
            if (permission())
            {
                Address addr = new Address();
                addr = getAdressValues();
                Shop s = new Shop();
                s = getShopValues();
                dtShop = sh.Search(s, addr);
                dShops.DataSource = dtShop;
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            clear();
            RefreshData();
        }
        private void ReadOnlyAct(List<TextBox> txtbxs,bool act)
        {
            foreach (var txtbx in txtbxs)
            {
                txtbx.ReadOnly = act;
            }
            shopIdtxt.ReadOnly = true;
            addrId.ReadOnly = true;
            shopStatus.Enabled = !act;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<TextBox> txtbxs = this.groupShop.Controls.OfType<TextBox>().ToList();
            ReadOnlyAct(txtbxs, FreadOnly);
            txtbxs = this.groupAddr.Controls.OfType<TextBox>().ToList();
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

        private void Telefon_Click(object sender, EventArgs e)
        {

        }

        private void addrTelefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void Identity_Click(object sender, EventArgs e)
        {

        }
        private void DoSearch()
        {
            List<Label> labels = this.groupShop.Controls.OfType<Label>().ToList();
            ValuesCambo(labels, "search");
            labels = this.groupAddr.Controls.OfType<Label>().ToList();
            ValuesCambo(labels, "search");
            dtShop = sh.Search(this.searchLbTxt, searchKeyword.Text, OrderBy.GetItemText(OrderBy.SelectedItem));
            dShops.DataSource = dtShop;
            this.searchLbTxt = "";
        }
        private void SearchLab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchLab.GetItemText(SearchLab.SelectedItem)!="" && searchKeyword.Text != "") { 
                 DoSearch();
            }if(SearchLab.GetItemText(SearchLab.SelectedItem) != "" && OrderBy.GetItemText(OrderBy.SelectedItem) != "")
            {
                DoSearch();
            }
        }
    }
}
