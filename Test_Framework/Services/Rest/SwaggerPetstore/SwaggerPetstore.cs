using System;
using System.Net;
using Newtonsoft.Json;
using Test_Framework.BusnesObjects.RestObjects.SwaggerPetstore;
using RestSharp;

namespace Test_Framework.Services.Rest.SwaggerPetstore
{
    /// <summary>
    /// Класc для работы с api Swagger Petstore 
    /// (https://petstore.swagger.io/#/user/loginUser)
    /// </summary>
    /// <author>Maksim Ivanov</author>
    /// <createDate>02.09.2021</createDate>
    public class SwaggerPetstore
    {
        #region post pet/{petId}uploadImage Uploads an image

        public petUploadImageResponse UploadImageResponse { get; set; }
        public petUploadImageRequest UploadImageRequest { get; set; }

        public petUploadImageResponse SendUploadImage (petUploadImageRequest requestParams, string swagger, bool checkeResult = false)
        {
            int repeat = 2;
            while (repeat > 0)
            {
                var url = swagger + "/pet/" + requestParams.petId + "/uploadImage";
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

        #region get pet/{petId} Find pet by ID
        public universalPetResponse FindPetResponse { get; set; }
        public findPetRequest FindPetRequest { get; set; }

        public universalPetResponse FindPet (findPetRequest requestParams, string swagger, bool checkeResult = false)
        {
            int repeat = 2;
            while (repeat > 0)
            {
                var url = swagger + "/pet/" + requestParams.petId;
                var client = new RestClient(url);
                var request = new RestRequest();
                request.AddParameter("petId", requestParams.petId);
                var response = client.Execute<universalPetResponse>(request);
                universalPetResponse cr = JsonConvert.DeserializeObject<universalPetResponse>(response.Content);
                if(response.StatusCode == HttpStatusCode.OK)
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
