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
    public partial class Use_Case_input : Form
    {
        List<string> input = new List<string>();

        public Use_Case_input()
        {
            InitializeComponent();
        }

        private void Use_Case_input_FormClosing(object sender, FormClosingEventArgs e)
        {
            input.Add(tbname.Text);
            input.Add(tbsummary.Text);
            input.Add(tbassumption.Text);
            input.Add(tbdescription.Text);
            input.Add(tbexceptions.Text);
            input.Add(tbresult.Text);
            

        }
    }
}
