using NUnit.Framework;
using ScreenPlay.Tasks;

namespace ScreenPlay.Test
{
    public class EmployeeTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Login.As(Driver, "admin", "admin123");
        }

        [Test]
        public void AddEmployeeTest()
        {
            AddEmployee.WithData(Driver, "Audy", "audy.prueba@gmail.com", "42 south Street", "+13156785432");
            Assert.IsTrue(AcceptAlert.Success(Driver));
        }
    }
}
