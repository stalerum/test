using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class FormAccEdit : Form
    {
        /* public FormAccEdit()
         {
             InitializeComponent();
         }*/

        public FormAccEdit(string login, string pass, string proxy)
        {
            InitializeComponent();
            tB_login.Text = login;
            tB_pass.Text = pass;
            tB_proxy.Text = proxy;
        }

        private void FormAccEdit_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //string login = tB_login.Text.Trim();
            //this.DialogResult = DialogResult.OK;
            //Form1.ToLog("fgdfg");
        }

        public string ReturnData()
        {
            string name = "vfdsfsdf";
            return name;
        }
    }
}
