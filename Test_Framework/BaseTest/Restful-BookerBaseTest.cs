using NUnit.Framework;
using Test_Framework.BusnesObjects.RestObjects.SwaggerPetstore;
using Test_Framework.Services.Rest.SwaggerPetstore;
using Test_Framework.NUnit;


namespace Test_Framework.BaseTest
{
    /// <summary>
    /// Базовый клас для тестов Restful-Booker
    /// </summary>
    /// <author>Maksim Ivanov</author>
    /// <createData>19.09.2021</createData>

    [TestFixture]
    [Parallelizable(ParallelScope.None)]
    public class Restful_BookerBaseTest : Test
    {
        ///<summary>
        ///Booking - GetBookingIds
        ///Возвращает идентификаторы всех бронирований, существующих в API. 
        ///Может принимать дополнительные строки запроса для поиска и возврата 
        ///подмножества идентификаторов бронирования.
        ///</summary>
        /// <author>Maksim Ivanov</author>
        /// <createData>19.09.2021</createData>

        public void GetBookingIds()
        {
            string swagger = "https://petstore.swagger.io/v2";
            var getRequest = new petUploadImageRequest();
            getRequest.petId = petId;
            getRequest.additionalMetadata = additionalMetadata;
            GetTest.SwaggerPetstore.UploadImageResponse = GetTest.SwaggerPetstore.SendUploadImage(getRequest, swagger, false);
        }
    }
}
