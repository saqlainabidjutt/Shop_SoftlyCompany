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
    public partial class Suppliers : Form
    {
        Supplier sp = new Supplier();
        DataTable dtSupp;
        bool FreadOnly = false;
        private string searchLbTxt = "";
        public Suppliers()
        {
            InitializeComponent();
        }
        private void RefreshData()
        {
            dtSupp = sp.Select();
            dSupp.DataSource = dtSupp;
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
                    string result = tmp.Remove(Place, 1).Insert(Place, ".");
                    this.searchLbTxt = result;
                }
            }
        }
        private void Suppliers_Load(object sender, EventArgs e)
        {
            RefreshData();
            List<Label> labels = this.groupSupp.Controls.OfType<Label>().ToList();
            ValuesCambo(labels, "load");
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
        private Supplier getSuppValues()
        {
            Supplier sup = new Supplier();
            sup.Name = suppName.Text;
            sup.Fname = suppFName.Text;
            sup.Lname = suppLName.Text;
            sup.UserIdentity = suppIdentity.Text;
            sup.Email = suppEmail.Text;
            sup.Status = suppStatus.Text;
            return sup;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (permission())
            {
                Address addr = new Address();
                addr = getAdressValues();
                long addrId = addr.Insert(addr);
                if (addrId != 0)
                {
                    Supplier s = new Supplier();
                    s = getSuppValues();
                    s.AddrId = (int)addrId;
                    bool success = s.Insert(s);
                    if (success)
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
            List<TextBox> txtbxs = this.groupSupp.Controls.OfType<TextBox>().ToList();
            clear(txtbxs);
            txtbxs = this.groupAddr.Controls.OfType<TextBox>().ToList();
            clear(txtbxs);
            suppStatus.Text = "";
            searchKeyword.Text = "";
            SearchLab.Text = "";
            OrderBy.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dSupp_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //S.ID,S.NAME as Name,S.FIRSTNAME as FirstName,S.LASTNAME as LastName,S.USER_IDENTITY,S.EMAIL as Email,S.STATUS,
            //7:A.TELEFON,A.STREET,A.BUILDINGNUM,A.FLOOR,A.DOORNUM,A.POSTALCODE,A.CITY,A.PROVENCE,A.COUNTRY,A.ID as Address_Id"
            int row_ind = e.RowIndex;
            suppIdtxt.Text = dSupp.Rows[row_ind].Cells[0].Value.ToString();
            addrId.Text = dSupp.Rows[row_ind].Cells[16].Value.ToString();
            suppName.Text = dSupp.Rows[row_ind].Cells[1].Value.ToString();
            suppFName.Text = dSupp.Rows[row_ind].Cells[2].Value.ToString();
            suppLName.Text = dSupp.Rows[row_ind].Cells[3].Value.ToString();
            suppIdentity.Text = dSupp.Rows[row_ind].Cells[4].Value.ToString();
            suppEmail.Text = dSupp.Rows[row_ind].Cells[5].Value.ToString();
            suppStatus.Text = dSupp.Rows[row_ind].Cells[6].Value.ToString();
            addrTelefon.Text = dSupp.Rows[row_ind].Cells[7].Value.ToString();
            addrStreet.Text = dSupp.Rows[row_ind].Cells[8].Value.ToString();
            addrBuildingNum.Text = dSupp.Rows[row_ind].Cells[9].Value.ToString();
            addrFloor.Text = dSupp.Rows[row_ind].Cells[10].Value.ToString();
            addrDoor.Text = dSupp.Rows[row_ind].Cells[11].Value.ToString();
            addrPostalCode.Text = dSupp.Rows[row_ind].Cells[12].Value.ToString();
            addrCity.Text = dSupp.Rows[row_ind].Cells[13].Value.ToString();
            addrProvence.Text = dSupp.Rows[row_ind].Cells[14].Value.ToString();
            addrCountry.Text = dSupp.Rows[row_ind].Cells[15].Value.ToString();
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
                    Supplier s = new Supplier();
                    s = getSuppValues();
                    s.Id = Convert.ToInt32(suppIdtxt.Text);
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
                Supplier s = new Supplier();
                s = getSuppValues();
                dtSupp = sp.Search(s, addr);
                dSupp.DataSource = dtSupp;
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            clear();
            RefreshData();
        }
        private void ReadOnlyAct(List<TextBox> txtbxs, bool act)
        {
            foreach (var txtbx in txtbxs)
            {
                txtbx.ReadOnly = act;
            }
            suppIdtxt.ReadOnly = true;
            addrId.ReadOnly = true;
            suppStatus.Enabled = !act;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<TextBox> txtbxs = this.groupSupp.Controls.OfType<TextBox>().ToList();
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
        private void DoSearch()
        {
            List<Label> labels = this.groupSupp.Controls.OfType<Label>().ToList();
            ValuesCambo(labels, "search");
            labels = this.groupAddr.Controls.OfType<Label>().ToList();
            ValuesCambo(labels, "search");
            dtSupp = sp.Search(this.searchLbTxt, searchKeyword.Text, OrderBy.GetItemText(OrderBy.SelectedItem));
            dSupp.DataSource = dtSupp;
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
            if (searchKeyword.Text != "" && SearchLab.GetItemText(SearchLab.SelectedItem) == "" && OrderBy.GetItemText(OrderBy.SelectedItem) == "")
            {
                DoSearch();
            }
        }
    }
}
