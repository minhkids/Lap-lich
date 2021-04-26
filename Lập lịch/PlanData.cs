using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lập_lịch
{
    [Serializable]
    public class PlanData
    {
        private List<planitem> job;

        internal List<planitem> Job
        { get => job; set => job = value; }
    }
}
