using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HuntTracker.Models
{
    public class Hunt
    {

        public int HuntID { get; set; }
        public string Date { get; set; }
        public string TimeOfStart { get; set; }
        public string TimeOfEnd { get; set; }

        public string Season { get; set; }
        public string Weather { get; set; }
        public string UsedScentControl { get; set; }
        public int NumberOfDoes { get; set; }

        public int NumberOfBucks { get; set; }
        public int Harvested { get; set; }

        public string TreeStandLocation { get; set; }

        public IEnumerable<Category> Categories { get; set; }
     
    }


}
