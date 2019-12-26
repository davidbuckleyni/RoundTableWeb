using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace CoreLibary
{
    public partial class LoginForm : RadForm
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public LoginForm()
        {
            InitializeComponent();
          
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
