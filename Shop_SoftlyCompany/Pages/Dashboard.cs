using Shop_SoftlyCompany.Pages;
using Shop_TPV.Classes;
using Shop_TPV.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_TPV
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
        }
        private void Catelog_Load(object sender, EventArgs e)
        {
          //  Assembly a = Assembly.Load("Shop_TPV");
            //ResourceManager rm = new ResourceManager("Shop_TPV.Lang.en_uk", a);
        }

        private void CatelogIdtxt_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
        }

        private void catelogId_Click(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void shopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shops shops = new Shops();
            shops.Show();
        }

        private void catelogName_Click(object sender, EventArgs e)
        {

        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catelogs catelogs = new Catelogs();
            catelogs.Show();
        }
    }
}
