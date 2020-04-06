using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestDotvvm.Model
{
    public class TestData
    {
        public string ProjectName { get; set; }
        public DateTime Expiration { get; set; }
        public decimal HoursAwarded { get; set; }
        public decimal HoursUsed { get; set; }
        public decimal HoursRemaining { get; set; }
        public string Active { get; set; }
    }
}