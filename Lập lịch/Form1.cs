using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lập_lịch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMatrix();
        }
        void LoadMatrix()
        {
            Button oldbtn = new Button()
            {
                Width = 0,
                Height = 0,
                Location = new Point(0,0)
            };
            for (int i = 0; i < Ins.DayaColumn; i++)
            {
                for (int j = 0; j < Ins.DayaWeek; j++)
                {
                    Button btn = new Button() { Width = Ins.DateButtonW,Height = Ins.DateButtonH};
                    btn.Location = new Point(oldbtn.Location.X + oldbtn.Width, oldbtn.Location.Y);

                    PnMatrix.Controls.Add(btn);
                    oldbtn = btn;
                }
                oldbtn = new Button()
                {
                    Width = 0,
                    Height = 0,
                    Location = new Point(0, oldbtn.Location.Y + Ins.DateButtonH)
                };
            }
        }
    }
}
