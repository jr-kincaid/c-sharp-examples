namespace ClassLibrary.DesignPatterns.Creational.Factory
{
    /// <summary>
    /// Line Item
    /// </summary>
    public class LineItem
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="name">Product Name</param>
        /// <param name="quantity">Quantity</param>
        /// <param name="initialPrice">Initial Price</param>
        public LineItem(string name, int quantity, decimal initialPrice)
        {
            Name = name;
            Quantity = quantity;
            Price = initialPrice;
        }

        /// <summary>
        /// Product Name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Quanity of the Product.
        /// </summary>
        public int Quantity { get; private set; }

        /// <summary>
        /// Final Price.
        /// </summary>
        public virtual decimal Price { get; private set; }
    }
}
