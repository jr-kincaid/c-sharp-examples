using NUnit.Framework;

namespace ClassLibrary.DesignPatterns.Creational.Singleton
{
    [TestFixture]
    public class UserSettingsTests
    {
        [Test]
        public void SameInstanceUsed()
        {
            // We need the name both as a parameter for the first sut variable as well as Asserts.
            var name = "App 1";
            // First GetInstance call will use yesterday day's date with the current time.
            var date1 = DateTime.UtcNow.AddDays(-1);
            /*
             * Second GetInstance call will use the current time. 
             * This gets thrown away ultimately by the end of the second GetInstance call
             * because sut1 setup the instance already.
             */
            var date2 = DateTime.UtcNow;
            //The instance is created with the first call.
            var sut1 = ApplicationSettings.GetInstance(date1, name);
            // sut2 will be equal to sut1. The parameters are more or less discarded.
            var sut2 = ApplicationSettings.GetInstance(date2, "App 2");
            // This is the only test we really need.
            Assert.AreEqual(sut1, sut2);
            /*
             * Get Instance only setup the instance once. 
             * Above Assert is enough of a test. But just making the assumptions explicit.
             */
            Assert.AreEqual(date1, sut1.StartDate);
            Assert.AreEqual(date1, sut2.StartDate);
            Assert.AreEqual(name, sut1.Name);
            Assert.AreEqual(name, sut2.Name);
        }
    }
}