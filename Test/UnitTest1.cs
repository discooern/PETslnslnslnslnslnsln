using PETslnslnslnslnslnsln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        public FunctionsLayer func = new FunctionsLayer();

        [TestMethod]
        public void TestMethod()
        {
            // Aarrange
            int countBefore = func.AgentsList.Count;
            Agents tmp = new Agents()
            {
                ID = 1,
                PersonID = 1
            };

            // Act
            func.AddAgent(tmp);

            //Assert
            Assert.AreEqual(countBefore + 1, func.NationalitiesList.Count);
        }
    }
}
