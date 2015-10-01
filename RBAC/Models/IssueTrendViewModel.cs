using RBAC.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RBAC.Models
{
    [Serializable]
    public class IssueTrendViewModel
    {
        public int TicketName { get; set; }
        public DateTime  CreationDate { get; set; }
        public DateTime  AssignedDateTime { get; set; }
        public DateTime ResolvedDateTime { get; set; }
        public PriorityType Priority { get; set; }

    }
}