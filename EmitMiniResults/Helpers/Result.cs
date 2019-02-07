using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmitMiniResults.Helpers
{
    public class Result
    {
        public Result()
        {
            EmitCardNumber = 0;
            CompetitorName = "";
            EndResultTime = 0;
        }
        public int EmitCardNumber { get; set; }
        public string CompetitorName { get; set; }
        public int EndResultTime { get; set; }
    }
}
