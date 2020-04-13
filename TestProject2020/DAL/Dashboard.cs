using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class Dashboard
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Label> Labels { get; set; }
    }
}
