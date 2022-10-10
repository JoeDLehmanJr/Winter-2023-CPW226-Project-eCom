

namespace CPW221_Project_eCom.Models
{
    public class InvoicedItems
    {
        /// <summary>
        /// The Primary Identity Key for each Invoiced Item
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// The Foreign Key for Order Number. Connects to Invoices Primary Key
        /// </summary>
        public int OrderNumber { get; set; }

        /// <summary>
        /// Number of Items in the Invoiced Items 
        /// </summary>
        public int Quantity { get; set; }
    }
}