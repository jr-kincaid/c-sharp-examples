namespace ClassLibrary.DesignPatterns.Creational.Factory
{
    /// <summary>
    /// Premium Line Item
    /// </summary>
    internal class PremiumLineItem : LineItem
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="productName">Product Name</param>
        /// <param name="quantity">Quantity</param>
        /// <param name="initialPrice">Initial Price</param>
        /// <param name="discount">Discount</param>
        public PremiumLineItem(string productName, int quantity, decimal initialPrice, decimal discount) : base(productName, quantity, initialPrice)
        {
            _Discount = discount;
        }

        /// <summary>
        /// Discount to Apply.
        /// </summary>
        private decimal _Discount { get; set; }

        /// <summary>
        /// Price with Discount Applied.
        /// </summary>
        public override decimal Price => base.Price * (1-_Discount);
    }
}
