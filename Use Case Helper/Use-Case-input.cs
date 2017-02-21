using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Use_Case_Helper
{
    public partial class Use_Case_input : Form
    {
        public List<string> input = new List<string>();
        int wichcases = 0;
        public Use_Case_input()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            wichcases++;
            
            input.Add("*" + wichcases.ToString() + "*" +  tbname.Text);
            input.Add("*" + wichcases.ToString() + "*" + tbsummary.Text);
            input.Add("*" + wichcases.ToString() + "*" + tbassumption.Text);
            input.Add("*"  + wichcases.ToString() + "*" + tbdescription.Text);
            input.Add("*" + wichcases.ToString() + "*" + tbexceptions.Text);
            input.Add("*" + wichcases.ToString() + "*" + tbresult.Text);

            this.Close();
        }


    }

}
