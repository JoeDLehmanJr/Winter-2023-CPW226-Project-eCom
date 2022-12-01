

using System.ComponentModel.DataAnnotations;

namespace CPW221_Project_eCom.Models
{
    /// <summary>
    /// Category for product when searching for revelvant items related to a search
    /// </summary>
	public class ProductCategory
    {
        /// <summary>
        /// Unique Primary Key for ProductCategory
        ///  NOT NULL
        /// </summary>
        [Key]
        public int ProductCategoryId { get; set; }

        /// <summary>
        /// Name of the category for a product
        ///  NOT NULL
        /// </summary>
        [Required]
        [StringLength(75,
            ErrorMessage = "Category Name has a limit of 75 characters")]
        public string ProductCategoryName { get; set; }

        /// <summary>
        /// Description of the product category
        ///  NOT NULL
        /// </summary>
        [Required]
        [StringLength(255,
            ErrorMessage = "Description has a limit of 255 characters")]
        public string ProductCategoryDescription { get; set; }

        /// <summary>
        /// makes the customerLogin class into a object
        /// </summary>
        public ICollection<Product> _product { get; set; }
    }
}