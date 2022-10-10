

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
        public int ProductId { get; set; }

        /// <summary>
        /// MSRP for the product
        ///  NOT NULL
        /// </summary>
        public double RetailPrice { get; set; }

        /// <summary>
        /// Description of the product
        ///  NOT NULL
        /// </summary>
        public string ProductDescription { get; set; }

        /// <summary>
        /// Category for the product. Foreign Key. Connects to ProductCategory
        ///  NOT NULL
        /// </summary>
        public int ProductCategoryId { get; set; }
    }
}