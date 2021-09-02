using System;
using System.Net;
using Newtonsoft.Json;
using Test_Framework.BusnesObjects.RestObjects.SwaggerPetstore;
using RestSharp;

namespace Test_Framework.Services.Rest.SwaggerPetstore
{
    /// <summary>
    /// Клас для работы с api Swagger Petstore 
    /// (https://petstore.swagger.io/#/user/loginUser)
    /// </summary>
    /// <author>Maksim Ivanov</author>
    /// <createDate>02.09.2021</createDate>
    public class SwaggerPetstore
    {
        #region pet/uploadImage
        private const string petUploadImageResponseUrl = "/pet/{petId}/uploadImage";
        public petUploadImageResponse UploadImageResponse { get; set; }
        public petUploadImageRequest UploadImageRequest { get; set; }

        public petUploadImageResponse SendUploadImage (petUploadImageRequest requestParams, string swagger, bool checkeResult = false)
        {
            int repeat = 2;
            while (repeat > 0)
            {
                var url = swagger + petUploadImageResponseUrl;
                var client = new RestClient(url);
                var request = new RestRequest();
                request.AddParameter("petId", requestParams.petId);
                request.AddParameter("additionalMetadata", requestParams.additionalMetadata);
                var response = client.Execute<petUploadImageResponse>(request);
                petUploadImageResponse cr = JsonConvert.DeserializeObject<petUploadImageResponse>(response.Content);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return cr;
                }
                else
                {
                    if (checkeResult == false) return cr;
                    repeat--;
                }
            }
            throw new Exception();
            

        }
        #endregion
    }
}
