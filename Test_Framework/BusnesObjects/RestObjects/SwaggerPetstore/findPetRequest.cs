using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Framework.BusnesObjects.RestObjects.SwaggerPetstore
{
    public class findPetRequest
    {
        public int petId { get; set; }

        public class Period
        {
            public int id { get; set; }
            public DateTime startdate { get; set; }
            public DateTime enddate { get; set; }
        }

        public class Root
        {
            public List<Period> period { get; set; }
        }
    }
}
