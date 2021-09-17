using Test_Framework.BaseTest;
using NUnit.Framework;

namespace TestSwaggerPetStore.SwaggerPetstore.Tests.Pet
{
    [TestFixture]
    class Get_FindPet : SwaggerPetstoreBaseTest
    {
        [Test]
        public void PositiveSmoke()
        {
            string idError = "Id не совпадает с ожидемым";
            string nameCategoryNotEquels = "Имя в категории не соответствует ожидаемому";
            string nameNotEquels = "Имя животного не соответсвует ожидаемому";
            string breed = "Порода не соответсвует ожидаемому";
            string statusNotEquls = "Статус не соответствует ожидаемому";

            int id = 7574746;

            FindPet(id);

            Assert.IsTrue(GetTest.SwaggerPetstore.FindPetResponse.id == id.ToString(), idError);
            Assert.IsTrue(GetTest.SwaggerPetstore.FindPetResponse.category.name == "Cat", nameCategoryNotEquels);
            Assert.IsTrue(GetTest.SwaggerPetstore.FindPetResponse.name == "Hardy", nameNotEquels);
            Assert.IsTrue(GetTest.SwaggerPetstore.FindPetResponse.tags[0].name == "Mainecoon", breed);
            Assert.IsTrue(GetTest.SwaggerPetstore.FindPetResponse.status == "sold", statusNotEquls);

        }
    }
}
