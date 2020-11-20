using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using fuzhu;

namespace LKU8.shoukuan
{
    public partial class Frmkc : Form
    {
        

        public Frmkc()
        {
            InitializeComponent();
        }

        public Frmkc(string cInvaddcode)
        {
            InitializeComponent();
            txtCAS.Text = cInvaddcode;
            Cx();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Cx();

        }

        private void Cx()
        {
            string sql = string.Format(@"SELECT c.cwhname,  b.invaddcode,  b.InvCode,b.InvName ,b.InvStd,b.ComUnitName,a.cBatch,convert(real, a.iQuantity) as  iQuantity, a.iQuantity  FROM warehouse c,
dbo.CurrentStock  a,dbo.v_bas_inventory b WHERE a.cInvCode = b.InvCode  and a.cwhcode = c.cwhcode
AND a.iQuantity>0  and b.invaddcode like '%{0}%' ", txtCAS.Text);
            gridControl1.DataSource = DbHelper.ExecuteTable(sql);
        }
    }
}
