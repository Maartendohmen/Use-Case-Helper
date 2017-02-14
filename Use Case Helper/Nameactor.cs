using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Use_Case_Helper
{
    public partial class Nameactor : Form
    {
       
        public Nameactor()
        {
            InitializeComponent();
        }

        private void tbconfirm_Click(object sender, EventArgs e)
        {
            if (tbname.Text == "")
            {
                MessageBox.Show("Please fill in a name for the actor");
            }
            else
            {
                Close();
            }
        }
    }
}
