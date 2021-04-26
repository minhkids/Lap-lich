using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static Lập_lịch.planitem;

namespace Lập_lịch
{
    public partial class Form1 : Form
    {
        #region Peoperties
        private string filepath = "data.xml";
        public List<List<Button>> Matrix { get; set; }
        public PlanData Job
        {
            get { return job; }
            set { job = value; }
        }
        // mang dateofweek dua ra ty nua dua vao day de lam column
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
        private PlanData job;

        private void Form1_Load(object sender, EventArgs e)
        {           
            LoadMatrix();
            try
            {
                Job = Deserializefromxml(filepath) as PlanData;
            }
            catch
            {
                SetDefaultJob();
            }
        }
        void SetDefaultJob()
        {
            Job = new PlanData();
            Job.Job = new List<planitem>();
            Job.Job.Add(new planitem()
            {
                Date = DateTime.Now,
                FromTime = new Point(4, 0),
                ToTime = new Point(5, 0),
                Job = "Thử nghiệm thôi!!!",
                Status = planitem.ListStatus[(int)EplanItem.Doing]
            });
            Job = new PlanData();
            Job.Job = new List<planitem>();
            Job.Job.Add(new planitem()
            {
                Date = DateTime.Now,
                FromTime = new Point(4, 0),
                ToTime = new Point(5, 0),
                Job = "Thử nghiệm thôi!!!",
                Status = planitem.ListStatus[(int)EplanItem.Doing]
            });
            Job = new PlanData();
            Job.Job = new List<planitem>();
            Job.Job.Add(new planitem()
            {
                Date = DateTime.Now,
                FromTime = new Point(4, 0),
                ToTime = new Point(5, 0),
                Job = "Thử nghiệm thôi!!!",
                Status = planitem.ListStatus[(int)EplanItem.Done]
            });
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
            {// nhung cai nay da dinh nghia
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Ins.DayaWeek; j++)
                {
                    Button btn = new Button() { Width = Ins.DateButtonW,Height = Ins.DateButtonH};
                    btn.Location = new Point(oldbtn.Location.X + oldbtn.Width, oldbtn.Location.Y);
                    btn.Click += Btn_Click;
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

        private void Btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as Button).Text))
                return;
            Dailyplan daily = new Dailyplan(new DateTime(dptkDate.Value.Year,dptkDate.Value.Month,Convert.ToInt32((sender as Button).Text)),Job);
            daily.ShowDialog();
        }

        int Dateofmonth(DateTime date)
        {// cai nay tu hieu
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
                // cai nay khoi tao column do dem cac ngay trong tuan roi tao thanh cac cot
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
                {// column eo the lon hon 6 dau neu lon hon sang trang
                    line++;
                }
                useDate = useDate.AddDays(1);
            }
        }
        bool Equaldate(DateTime DateA, DateTime DateB)
        {
            // cai nay ty goi ham so sanh cac gia tri chon va gia tri hom do
            return DateA.Year == DateB.Year && DateA.Month == DateB.Month && DateA.Day == DateB.Day;
        }
        private void dptkDate_ValueChanged(object sender, EventArgs e)
        {
            AddNumberMatrix((sender as DateTimePicker).Value);
        }
        // default dua ve gia tri ban dau
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
        private void SerializeToXML(object data, string filepath)
        {
            FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write);          
            XmlSerializer sr = new XmlSerializer(typeof(PlanData));            
            sr.Serialize(fs, data);

            fs.Close();
        }

        private object Deserializefromxml(string filepath)
        {
            FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            try
            {
                XmlSerializer sr = new XmlSerializer(typeof(PlanData));

                object result = sr.Deserialize(fs);
                fs.Close();
                return result;
            }
            catch (Exception e)
            {
                fs.Close();
                throw new NotImplementedException();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeToXML(Job, filepath);
        }
    }
}
