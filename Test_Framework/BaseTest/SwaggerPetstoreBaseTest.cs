using NUnit.Framework;
using Test_Framework.BusnesObjects.RestObjects.SwaggerPetstore;

namespace Test_Framework.BaseTest
{
    /// <summary>
    /// Базовый клас для тестов SwaggerPetstore
    /// </summary>
    /// <author>Maksim Ivanov</author>
    /// <createData>03.09.2021</createData>
    [TestFixture]
    [Parallelizable(ParallelScope.None)]
    public abstract class SwaggerPetstoreBaseTest 
    {
        ///<summary>
        ///upload an image (/pet/{petId}/uploadImage)
        ///</summary>
        /// <author>Maksim Ivanov</author>
        /// <createData>03.09.2021</createData>
        
        public void UploadImage (string petId, string additionalMetadata)
        {
            string swagger = "https://petstore.swagger.io/v2";
            //getRequest = new petUploadImageRequest();
            //getRequest.petId = petId;
            //getRequest.additionalMetadata = additionalMetadata;
            //getResponse = SendUploadImage(getRequest, swagger);
        }

    }
}
