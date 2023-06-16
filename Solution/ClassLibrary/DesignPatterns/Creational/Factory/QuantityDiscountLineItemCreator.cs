namespace ClassLibrary.DesignPatterns.Creational.Factory
{
    /// <summary>
    /// Creates Items with possible discounts.
    /// </summary>
    public class QuantityDiscountLineItemCreator : LineItemCreator
    {
        /// <summary>
        /// Creates a Line Item
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="quantity">Quantity</param>
        /// <param name="initialPrice">Initial Price</param>
        /// <returns></returns>
        public override LineItem CreateLineItem(string name, int quantity, decimal initialPrice)
        {
            //Avoids repeated code by creating a function variable that gets each call down to passing just the discount at the call site.
            Func<decimal, LineItem> createPremiumLineItem = (x) => new PremiumLineItem(name, quantity, initialPrice, x);

            return quantity switch
            {
                //First three pattern matches end up create a Premium Line Item.
                >= 10 => createPremiumLineItem((decimal).10),
                >= 5 => createPremiumLineItem((decimal).05),
                _ => new LineItem(name, quantity, initialPrice)
            };
        }
    }
}
