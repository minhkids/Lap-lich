using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calender
{
    public partial class AJob : UserControl
    {
        private PlanItem job;
        public PlanItem Job
        {
            get { return job; }
            set { job = value; }
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

        public AJob(PlanItem job)
        {
            InitializeComponent();

            cbStatus.DataSource = PlanItem.ListStatus;

            this.Job = job;

            ShowInfo();
        }
        void ShowInfo()
        {
            txbJob.Text = Job.Job;
            nmFromHours.Value = Job.FromTime.X;
            nmFromMinute.Value = Job.FromTime.Y;
            nmToHours.Value = Job.ToTime.X;
            nmToMinute.Value = Job.ToTime.Y;
            cbStatus.SelectedIndex = PlanItem.ListStatus.IndexOf(Job.Status);
            ckbDone.Checked = PlanItem.ListStatus.IndexOf(Job.Status) == (int)EPlanItem.DONE ? true : false;
        }
        private void txbJob_TextChanged(object sender, EventArgs e)
        {

        }
        private void ckbDone_CheckedChanged_1(object sender, EventArgs e)
        {
            cbStatus.SelectedIndex = ckbDone.Checked ? (int)EPlanItem.DONE : (int)EPlanItem.DOING;
            
        }
        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            Job.Job = txbJob.Text;
            Job.FromTime = new Point((int)nmFromHours.Value, (int)nmFromMinute.Value);
            Job.ToTime = new Point((int)nmToHours.Value, (int)nmToMinute.Value);
            Job.Status = PlanItem.ListStatus[cbStatus.SelectedIndex];

            if (edited != null)
                edited(this, new EventArgs());
        }
        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbStatus.SelectedIndex == (int)EPlanItem.DONE)
            {
                panel1.BackColor = Color.Green;
            }
            else
            {
                panel1.BackColor = Color.White;
            }
            if (cbStatus.SelectedIndex == (int)EPlanItem.COMING)
            {
                panel1.BackColor = Color.Blue;
            }
            if (cbStatus.SelectedIndex == (int)EPlanItem.MISSED)
            {
                panel1.BackColor = Color.Red;
            }
            if (cbStatus.SelectedIndex == (int)EPlanItem.DOING)
            {
                panel1.BackColor = Color.Gray;
            }
        }
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (deleted != null)
                deleted(this, new EventArgs());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nmFromHours_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
