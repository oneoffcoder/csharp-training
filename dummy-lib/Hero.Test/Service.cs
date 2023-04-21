using Hero.Service;

namespace Hero.UnitTests.Service
{
    public class ServiceTest
    {
        [Fact]
        public void GetAction()
        {
            var carService = new CarService();
            string action = carService.GetAction("red");
            Assert.Equal("stop", action);
        }
    }
}