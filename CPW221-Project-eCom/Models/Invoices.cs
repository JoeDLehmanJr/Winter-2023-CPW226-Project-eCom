

using System.ComponentModel.DataAnnotations;

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
        [Key]
        public int OrderNumber { get; set; }

        //PLACEHOLDER
        /// <summary>
        /// the date the order was made
        /// needs construction of way to handle datetime data
        /// convert to string?
        ///  NOT NULL
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// The description for the status of the order
        ///  NOT NULL
        /// </summary>
        public string? Status { get; set; }

        //PLACEHOLDER
        /// <summary>
        /// the date the order is estimated to arrive at customer's HoR
        /// needs construction of way to handle datetime data
        /// convert to string?
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Id of the customer assigned to product. Foreign Key. Connects to Customer
        ///  NOT NULL
        /// </summary>
        public int invoicesCustomerId { get; set; }

        //PLACEHOLDER
        /// <summary>
        /// Determines if the order was made online or by other means and returns boolean value
        /// </summary>
        public bool isOnlineOrder;

        /// <summary>
        /// makes the customer class into a object
        /// </summary>
        public ICollection<Customer>? _Customer { get; set; }

        /// <summary>
        /// pointer to link the invoices items table to this one
        /// </summary>
        public int OrderNumberId { get; set; }

        /// <summary>
        /// collection of invoice items
        /// </summary>
        public ICollection<InvoicedItems>? _InvoicedItems { get; set; }

    }
}