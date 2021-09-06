using NUnit.Framework;
using Test_Framework.BusnesObjects.RestObjects.SwaggerPetstore;
using Test_Framework.Services.Rest.SwaggerPetstore;
using Test_Framework.NUnit;
namespace Test_Framework.BaseTest
{
    /// <summary>
    /// Базовый клас для тестов SwaggerPetstore
    /// </summary>
    /// <author>Maksim Ivanov</author>
    /// <createData>03.09.2021</createData>
    [TestFixture]
    [Parallelizable(ParallelScope.None)]
    public abstract class SwaggerPetstoreBaseTest : Test
    {
        ///<summary>
        ///upload an image (/pet/{petId}/uploadImage)
        ///</summary>
        /// <author>Maksim Ivanov</author>
        /// <createData>03.09.2021</createData>
        
        public void UploadImage (int petId, string additionalMetadata)
        {
            string swagger = "https://petstore.swagger.io/v2";
            var getRequest = new petUploadImageRequest();
            getRequest.petId = petId;
            getRequest.additionalMetadata = additionalMetadata;
            GetTest.SwaggerPetstore.UploadImageResponse = GetTest.SwaggerPetstore.SendUploadImage(getRequest, swagger, false);
        }

    }
}
