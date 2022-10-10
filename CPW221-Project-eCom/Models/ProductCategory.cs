

namespace CPW221_Project_eCom.Models
{
    /// <summary>
    /// Category for product when searching for revelvant items related to a search
    /// </summary>
	public class ProductCategory
    {
        /// <summary>
        /// Unique Primary Key for ProductCategory
        /// </summary>
        public int ProductCategoryId { get; set; }

        /// <summary>
        /// Name of the category for a product
        /// </summary>
        public string ProductCategoryName { get; set; }

        /// <summary>
        /// Description of the product category
        /// </summary>
        public string ProductCategoryDescription { get; set; }