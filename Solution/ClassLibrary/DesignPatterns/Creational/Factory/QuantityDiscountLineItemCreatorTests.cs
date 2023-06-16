using NUnit.Framework;

namespace ClassLibrary.DesignPatterns.Creational.Factory
{
    [TestFixture]
    public class QuantityDiscountLineItemCreatorTests
    {
        [TestCase("A", 1, 5.0, 5.0)]
        [TestCase("A", 4, 5.0, 5.0)]
        [TestCase("B", 5, 5.0, 4.75)]
        [TestCase("C", 6, 5.0, 4.75)]
        [TestCase("C", 9, 10.0, 9.5)]
        [TestCase("C", 10, 10.0, 9)]
        [TestCase("C", 11, 10.0, 9)]
        public void CreateLineItem(string name, int quantity, decimal initialPrice, decimal discountedPrice)
        {
            var sut = new QuantityDiscountLineItemCreator();
            var result = sut.CreateLineItem(name, quantity, initialPrice);
            Assert.IsNotNull(result);
            Assert.AreEqual(quantity, result.Quantity);
            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(discountedPrice, result.Price);
            var expectedType = quantity < 5 ? typeof(LineItem) : typeof(PremiumLineItem);
            //Illustrates that the type changes if quantity is higher than 4.
            Assert.AreEqual(expectedType, result.GetType());
        }
    }
}
