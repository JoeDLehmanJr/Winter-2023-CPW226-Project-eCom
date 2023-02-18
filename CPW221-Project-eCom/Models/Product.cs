using System.ComponentModel.DataAnnotations;

namespace CPW221_Project_eCom.Models
{
    /// <summary>
    /// Model for each product
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Unique Primary Key for a product       
        /// NOT NULL
        /// </summary>
        [Key]
        public int ProductIdProduct { get; set; }

        /// <summary>
        /// Title of the product
        /// </summary>
        [Required]
        [StringLength(60,
            ErrorMessage = "Title has a limit of 60 characters")]
        public string Title { get; set; }

        /// <summary>
        /// MSRP for the product
        ///  NOT NULL
        /// </summary>
        [Required]
        [DataType(DataType.Currency)]
        public double RetailPrice { get; set; }

        /// <summary>
        /// Description of the product
        ///  NOT NULL
        /// </summary>
        [Required]
        [StringLength(255,
            ErrorMessage = "Description has a limit of 255 characters")]
        public string ProductDescription { get; set; }

        /// <summary>
        /// Category for the product. Foreign Key. Connects to ProductCategory
        ///  NOT NULL
        /// </summary>
        public int ProductCategoryId { get; set; }

        /// <summary>
        /// collection of productCategory
        /// </summary>
        public ProductCategory _productCategory { get; set; }

        /// <summary>
        /// makes the InvoicedItems class into a object
        /// </summary>
        public ICollection<InvoicedItems> _invoicedItems { get; set; }
    }
}