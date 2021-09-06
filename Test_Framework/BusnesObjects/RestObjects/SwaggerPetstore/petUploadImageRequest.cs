using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Framework.BusnesObjects.RestObjects.SwaggerPetstore
{
    public class petUploadImageRequest
    {
        public int petId { get; set; }
        public string additionalMetadata { get; set; }
        
        //public file file { get: set; }

    }
}
