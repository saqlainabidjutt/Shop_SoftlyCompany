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

namespace Shop_SoftlyCompany
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Catelog_Load(object sender, EventArgs e)
        {

        }

        private void CatelogIdtxt_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Catelog c = new Catelog();
            c.Name = catelogNametxt.Text;
            c.Description = catelogDestxt.Text;
            bool success = c.Insert(c);
            if (success)
            {
                MessageBox.Show("Catelog Inserted Successfully!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
