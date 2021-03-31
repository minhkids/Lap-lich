﻿using System;
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
            SetDefaultDate();
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
            clearMatrix();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);
           

            int line = 0;
            for ( int i = 1; i <= Dateofmonth(date); i++)
            {
                int column = DateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
              
                Button btn = Matrix[line][column];
                btn.Text = i.ToString();
                if (Equaldate(useDate, DateTime.Now))
                {
                    btn.BackColor = Color.YellowGreen;
                }
                if (Equaldate(useDate, date))
                {
                    btn.BackColor = Color.Yellow;
                }
                if (column >= 6)
                {
                    line++;
                }
                useDate = useDate.AddDays(1);
            }
        }
        bool Equaldate(DateTime DateA, DateTime DateB)
        {
            return DateA.Year == DateB.Year && DateA.Month == DateB.Month && DateA.Day == DateB.Day;
        }
        private void dptkDate_ValueChanged(object sender, EventArgs e)
        {
            AddNumberMatrix((sender as DateTimePicker).Value);
        }
        void SetDefaultDate()
        {
            dptkDate.Value = DateTime.Now;
        }
        void clearMatrix()
        {
            for (int i = 0; i < Matrix.Count;i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {

                    Button btn = Matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.White;
                }    

            }    
        }

        private void btnpre_Click(object sender, EventArgs e)
        {
            dptkDate.Value = dptkDate.Value.AddMonths(-1);
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            dptkDate.Value = dptkDate.Value.AddMonths(1);
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            SetDefaultDate();
        }
    }
}
