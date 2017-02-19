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
        List<string> input = new List<string>();
        int i = 0;

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

            i++;
            
            File.AppendAllText(@"C:\Users\Maarten\Desktop\Applicaties Visualstudio\Use Case Helper\Use Case Helper\bin\Debug\Saves.txt", i + System.Environment.NewLine + tbname.Text +System.Environment.NewLine+ tbsummary.Text + System.Environment.NewLine + tbassumption.Text + System.Environment.NewLine + tbdescription.Text + System.Environment.NewLine + tbexceptions.Text + System.Environment.NewLine + tbresult.Text);
        }
    }
}
