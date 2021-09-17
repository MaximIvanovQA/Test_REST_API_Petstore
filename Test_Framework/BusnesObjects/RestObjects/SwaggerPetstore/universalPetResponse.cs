using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Framework.BusnesObjects.RestObjects.SwaggerPetstore
{
    public class universalPetResponse
    {
        public string id { get; set; }
        public categoryGroup category { get; set; }
        public string name { get; set; }
        public string [] photoUrls { get; set; }
        public tagsHelper [] tags { get; set; }
        public string status { get; set; }

        public class categoryGroup
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class tagsHelper
        {
            public int id { get; set; }
            public string name { get; set; }
        }


    }
}
