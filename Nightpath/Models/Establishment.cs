using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nightpath.Models
{
    public class Establishment
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Schedule { get; set; }
        public int NIF { get; set; }
        public int UserID { get; set; }
        public int RegionID { get; set; }
        public int DistrictID { get; set; }

        public virtual User User { get; set; }
        public virtual Region Region { get; set; }
        public virtual District District { get; set; }






    }
}