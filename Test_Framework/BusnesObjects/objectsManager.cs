using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Framework.BusnesObjects
{
    ///<summary>
    ///Класс выдает доступ к общим полям.
    ///</summary>
    public class objectsManager
    {
        private static objectsManager _manager;

        public static objectsManager GetInstance()
            => _manager ?? (_manager = new objectsManager());
        public Services.Rest.SwaggerPetstore.SwaggerPetstore SwaggerPetstore { get; } = new Services.Rest.SwaggerPetstore.SwaggerPetstore();

    }
}
