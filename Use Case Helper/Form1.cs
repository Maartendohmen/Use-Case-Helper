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
    public partial class Form1 : Form
    {
        int aantalman = 0;
        Graphics g;
        Nameactor name = new Nameactor();
        Use_Case_input usecaseinput = new Use_Case_input();
        Pen p = new Pen(Color.Black, 3);

        public Form1()
        {
            InitializeComponent();
        }
    
        private void pnteken_Click(object sender, EventArgs e)
        {
            if (rbtnactor.Checked && rbtncreate.Checked)
            {
                Point a = pnteken.PointToClient(Cursor.Position);

                if (a.X < 140)
                {
                    MessageBox.Show("X = " + a.X.ToString() + " " + "Y = " + a.Y.ToString());

                    if (aantalman == 0)
                    {
                        name.ShowDialog();
                        label1.Visible = true;
                        label1.Text = name.tbname.Text;

                        g = pnteken.CreateGraphics();

                        Point linkervoetb = new Point(20, 80);
                        Point linkervoete = new Point(60, 60);
                        Point rechtervoetb = new Point(100, 80);
                        Point rechtervoete = new Point(60, 60);
                        Point rugb = new Point(60, 60);
                        Point ruge = new Point(60, 20);
                        Point armb = new Point(20, 40);
                        Point arme = new Point(100, 40);

                        g.DrawLine(p, linkervoetb, linkervoete);
                        g.DrawLine(p, rechtervoetb, rechtervoete);
                        g.DrawLine(p, rugb, ruge);
                        g.DrawLine(p, armb, arme);
                        g.DrawEllipse(p, 50, 0, 20, 20);
                    }

                    if (aantalman == 1)
                    {
                        name.ShowDialog();
                        label2.Visible = true;
                        label2.Text = name.tbname.Text;

                        g = pnteken.CreateGraphics();

                        Point linkervoetb = new Point(20, 180);
                        Point linkervoete = new Point(60, 160);
                        Point rechtervoetb = new Point(100, 180);
                        Point rechtervoete = new Point(60, 160);
                        Point rugb = new Point(60, 160);
                        Point ruge = new Point(60, 120);
                        Point armb = new Point(20, 140);
                        Point arme = new Point(100, 140);

                        g.DrawLine(p, linkervoetb, linkervoete);
                        g.DrawLine(p, rechtervoetb, rechtervoete);
                        g.DrawLine(p, rugb, ruge);
                        g.DrawLine(p, armb, arme);
                        g.DrawEllipse(p, 50, 100, 20, 20);
                    }

                    if (aantalman == 2)
                    {
                        name.ShowDialog();
                        label3.Visible = true;
                        label3.Text = name.tbname.Text;

                        g = pnteken.CreateGraphics();

                        Point linkervoetb = new Point(20, 280);
                        Point linkervoete = new Point(60, 260);
                        Point rechtervoetb = new Point(100, 280);
                        Point rechtervoete = new Point(60, 260);
                        Point rugb = new Point(60, 260);
                        Point ruge = new Point(60, 220);
                        Point armb = new Point(20, 240);
                        Point arme = new Point(100, 240);

                        g.DrawLine(p, linkervoetb, linkervoete);
                        g.DrawLine(p, rechtervoetb, rechtervoete);
                        g.DrawLine(p, rugb, ruge);
                        g.DrawLine(p, armb, arme);
                        g.DrawEllipse(p, 50, 200, 20, 20);
                    }

                    if (aantalman > 2)
                    {
                        MessageBox.Show("You have reached the maximum number of actors");
                    }

                    aantalman++;
                }

                else
                {
                    usecaseinput.ShowDialog();
          
                    g = pnteken.CreateGraphics();

                    string name = usecaseinput.tbname.Text;
                    Font font = new Font("Arial", 12);
                    Brush r = new SolidBrush(Color.Black);

                    g.DrawString(name, font, r, a.X-40,a.Y-30);
                  SizeF lengte =  g.MeasureString(name, font);

                    g.DrawEllipse(p, a.X - 50, a.Y - 40, lengte.Width + 15,lengte.Height + 15);




                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Color background = Color.FromKnownColor(KnownColor.Control);
            g.Clear(background);
        }
    }
}
