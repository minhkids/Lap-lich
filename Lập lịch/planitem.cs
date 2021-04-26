using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lập_lịch
{
    public class planitem
    {
        private DateTime date;

        private string job;
        private Point toTime;
    public string Job 
        { get => job; set => job = value; }
        // cai time no bat dau thi dung point de chon ra phut cho de
    public Point FromTime 
        { get => fromTime; set => fromTime = value; }
    public string Status
        { get => status; set => status = value; }
    public DateTime Date
        { get => date; set => date = value; }
        // point ket thuc cx vay
    public Point ToTime 
        { get => toTime; set => toTime = value; }

        private Point fromTime;
        private string status;
        // taoj cai mang cho cac cong viec cua status
        public static List<string> ListStatus = new List<string>() { "Done", "Doing", "Coming", "Missed" };
       // dung khai bao mang liet ke status da dinh nghia
        public enum EplanItem
        {
            Done,
            Doing,
            Coming,
            Missed
        }
        
    }
}
