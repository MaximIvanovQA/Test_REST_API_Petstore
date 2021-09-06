using Test_Framework.BusnesObjects;
using NUnit.Framework;

namespace Test_Framework.NUnit
{
    /// <summary>
    /// Базовый класс для NUnit тестов
    /// </summary>
     
    [TestFixture]
    [Parallelizable(ParallelScope.None)]
    public abstract class Test
    {
        protected objectsManager GetTest;

        protected Test()
        {
            GetTest = objectsManager.GetInstance();
        }
    }
}
