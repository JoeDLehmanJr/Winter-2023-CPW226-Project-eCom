

namespace CPW221_Project_eCom.Models
{
    /// <summary>
    /// Model for each Invoice
    /// </summary>
    public class Invoices
    {
        /// <summary>
        /// Unique primary key for Invoices
        ///  NOT NULL
        /// </summary>
        public int OrderNumber { get; set; }

        //PLACEHOLDER
        /// <summary>
        /// the date the order was made
        /// needs construction of way to handle datetime data
        /// convert to string?
        ///  NOT NULL
        /// </summary>
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// The description for the status of the order
        ///  NOT NULL
        /// </summary>
        public string Status { get; set; }

        //PLACEHOLDER
        /// <summary>
        /// the date the order is estimated to arrive at customer's HoR
        /// needs construction of way to handle datetime data
        /// convert to string?
        /// </summary>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Id of the customer assigned to product. Foreign Key. Connects to Customer
        ///  NOT NULL
        /// </summary>
        public int CustomerId { get; set; }

        //PLACEHOLDER
        /// <summary>
        /// Determines if the order was made online or by other means and returns boolean value
        /// </summary>
        public boolean isOnlineOrder;
    }
}