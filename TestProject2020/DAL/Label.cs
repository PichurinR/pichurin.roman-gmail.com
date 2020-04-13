using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class Label
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Dashboard DashboardId { get; set; }
        public IEnumerable<Ticket> Tickets { get; set; }
    }
}
