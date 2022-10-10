

namespace CPW221_Project_eCom.Models
{
    /// <summary>
    /// Model for each product
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Unique Primary Key for a product
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// MSRP for the product
        /// </summary>
        public double RetailPrice { get; set; }

        /// <summary>
        /// Description of the product
        /// </summary>
        public string ProductDescription { get; set; }

        /// <summary>
        /// Category for the product. Foreign Key. Connects to ProductCategory
        /// </summary>
        public int ProductCategoryId { get; set; }
    }
}