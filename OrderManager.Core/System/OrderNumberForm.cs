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
    public partial class OrderNumberForm : RadForm
    {
        public string OrderNumber { get; set; }
        public OrderNumberForm()
        {
            InitializeComponent();
          
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrderNumberForm_Load(object sender, EventArgs e)
        {
            lblOrderNumber.Text = OrderNumber;
        }
    }
}
