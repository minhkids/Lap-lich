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
        #region Peoperties
        public List<List<Button>> Matrix { get; set; }
        
        private List<string> DateOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        #endregion
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
            Matrix = new List<List<Button>>();
            Button oldbtn = new Button()
            {
                Width = 0,
                Height = 0,
                Location = new Point(0,0)
            };
            for (int i = 0; i < Ins.DayaColumn; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Ins.DayaWeek; j++)
                {
                    Button btn = new Button() { Width = Ins.DateButtonW,Height = Ins.DateButtonH};
                    btn.Location = new Point(oldbtn.Location.X + oldbtn.Width, oldbtn.Location.Y);

                    PnMatrix.Controls.Add(btn);
                    Matrix[i].Add(btn);
                    oldbtn = btn;
                }
                oldbtn = new Button()
                {
                    Width = 0,
                    Height = 0,
                    Location = new Point(0, oldbtn.Location.Y + Ins.DateButtonH)
                };
            }
            AddNumberMatrix(dptkDate.Value);
        }
        int Dateofmonth(DateTime date)
        {
            switch(date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
                        return 29;
                    else
                        return 28;
                default:
                    return 30;
            }
        }
        void AddNumberMatrix(DateTime date)
        {
            
            DateTime useDate = new DateTime(date.Year, date.Month, 1);
            
            int line = 0;
            for ( int i = 1; i <= Dateofmonth(date); i++)
            {
                int column = DateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                //Console.WriteLine("Day la column"+ column);
                //Console.WriteLine("Day la line "+ line);
                //Console.WriteLine("use date to string " + useDate.DayOfWeek.ToString());
               // Console.WriteLine("usedate" + useDate);
                Button btn = Matrix[line][column];
                btn.Text = i.ToString();
                if (column >= 6)
                {
                    line++;
                }
                useDate = useDate.AddDays(1);
            }
        }
    }
}
