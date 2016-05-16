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
        int row_id;
        public FormAccEdit(int id, string login, string pass, string proxy)
        {
            InitializeComponent();
            row_id = id;
            tB_login.Text = login;
            tB_pass.Text = pass;
            tB_proxy.Text = proxy;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                main.NewFromAccEdit(row_id, tB_login.Text.Trim(), tB_pass.Text.Trim(), tB_proxy.Text.Trim());
            }
            this.Close();
        }
    }
}
