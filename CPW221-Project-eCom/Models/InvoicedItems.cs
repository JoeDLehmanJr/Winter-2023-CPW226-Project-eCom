

namespace CPW221_Project_eCom.Models
{
    /// <summary>
    /// Model for data about items being invoiced
    /// </summary>
    public class InvoicedItems
    {
        /// <summary>
        /// The Primary Identity Key for each Invoiced Item
        ///  NOT NULL
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// The Foreign Key for Order Number. Connects to Invoices Primary Key
        ///  NOT NULL
        /// </summary>
        public int OrderNumber { get; set; }

        /// <summary>
        /// Number of Items in the Invoiced Items 
        ///  NOT NULL
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// makes the customerLogin class into a object
        /// </summary>
        public ICollection<Invoices> _invoices { get; set; }

        /// <summary>
        /// pointer to link the Product table to this one
        /// </summary>
        public int ProductIdProduct { get; set; }

        /// <summary>
        /// collection of product
        /// </summary>
        public Product _product { get; set; }
    }
}