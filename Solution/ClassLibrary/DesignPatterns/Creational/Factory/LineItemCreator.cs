namespace ClassLibrary.DesignPatterns.Creational.Factory
{
    /// <summary>
    /// The Creator is abstract, so sale discounts or promotions
    /// can be applied to a line item, 
    /// by creating a concrete instance of this class.
    /// </summary>
    public abstract class LineItemCreator
    {
        /// <summary>
        /// Creates a Line Item.
        /// </summary>
        /// <param name="name">Name of Product.</param>
        /// <param name="quanity">Quantity Purchased.</param>
        /// <param name="initialPrice">Initial Price for the product.</param>
        /// <returns></returns>
        public abstract LineItem CreateLineItem(string name, int quanity, decimal initialPrice);
    }
}
