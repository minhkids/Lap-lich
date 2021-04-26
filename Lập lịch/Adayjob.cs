using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lập_lịch.planitem;

namespace Lập_lịch
{
    public partial class Adayjob : UserControl
    {
        private planitem job;

        public planitem Job
        {
            get { return job; }
            set { job = value; }
        }
        public Adayjob(planitem job)
        {
            cbStatus.DataSource = ListStatus;
            this.job = job;
            InitializeComponent();
            ShowInfo();
        }
        void ShowInfo()
        {
            tbjob.Text = Job.Job;
            nmFromHours.Value = Job.FromTime.X;
            nmFromMin.Value = Job.FromTime.Y;
            nmTohours.Value = Job.ToTime.X;
            nmtoMin.Value = Job.ToTime.Y;
            cbStatus.SelectedIndex = planitem.ListStatus.IndexOf(Job.Status);
            Cbdone.Checked = planitem.ListStatus.IndexOf(Job.Status) == (int)EplanItem.Done ? true : false;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private event EventHandler edited;
        public event EventHandler Edited
        {
            add { edited += value; }
            remove { edited -= value; }
        }
        private event EventHandler deleted;
        public event EventHandler Deleted
        {
            add { deleted += value; }
            remove { deleted -= value; }
        }
        private void Sua_Click(object sender, EventArgs e)
        {
            Job.Job = tbjob.Text;
            Job.FromTime = new Point((int)nmFromHours.Value, (int)nmFromMin.Value);
            Job.ToTime = new Point((int)nmTohours.Value, (int)nmtoMin.Value);
            Job.Status = planitem.ListStatus[cbStatus.SelectedIndex];
            if (edited != null)
                edited(this, new EventArgs());
        }
        
        private void Xoa_Click(object sender, EventArgs e)
        {
            if (deleted != null)
                deleted(this, new EventArgs());
        }
    }
}
