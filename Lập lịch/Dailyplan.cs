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
    public partial class Dailyplan : Form
    {
        FlowLayoutPanel fpannel = new FlowLayoutPanel();
        public Dailyplan(DateTime date, PlanData job)
        {
            InitializeComponent();
            this.date = date;
            this.job = job;            
            dateTimePicker1.Value = date;
            
            panel2.Controls.Add(fpannel);
            fpannel.Width = panel2.Width;
            fpannel.Height = panel2.Height;           
        }
        private DateTime date; 

        public DateTime Date
        { 
            get { return date; }
            set { date = value; }
        }
        private PlanData job;

        public PlanData Job
        {
            get { return job; }
            set { job = value; }
        }
        void Showjobbydate(DateTime date)
        {
            fpannel.Controls.Clear();
            if (Job != null && Job.Job != null)
            {
                List<planitem> todayjob = GetJobByday(date);
                for (int i = 0; i < GetJobByday(date).Count; i++)
                {
                    Adayjob ajob = new Adayjob(Job.Job[i]);
                    ajob.Edited += Ajob_Edited;
                    ajob.Deleted += Ajob_Deleted;
                    fpannel.Controls.Add(ajob);
                }
            }
        }

        private void Ajob_Deleted(object sender, EventArgs e)
        {
            Adayjob uc = sender as Adayjob;
            planitem job = uc.Job;

            fpannel.Controls.Remove(uc);
            Job.Job.Remove(job);
        }

        private void Ajob_Edited(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        List<planitem> GetJobByday(DateTime date)
        {
            return Job.Job.Where(p => p.Date.Year == date.Year && p.Date.Month == date.Month && p.Date.Day == date.Day).ToList();
        }
        private void thêmLịch_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void Dailyplan_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Showjobbydate((sender as DateTimePicker).Value);
        }

        private void btnNextday_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(1);
        }

        private void btnpreviosday_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(-1);
        }
    }
}
