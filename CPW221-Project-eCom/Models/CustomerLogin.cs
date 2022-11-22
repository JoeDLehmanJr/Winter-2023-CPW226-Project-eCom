using System.ComponentModel.DataAnnotations;

namespace CPW221_Project_eCom.Models
{   
    /// <summary>
    /// Model for user's login account data
    /// </summary>
    public class CustomerLogin
    {
        /// <summary>
        /// Unique Primary Identity Key for each customer
        /// NOT NULL
        /// WARNING: Two cases of CustomerId in DB. CustomerId in CustomerLogin will be primary
        /// </summary>
        [Key]
        public int CustomerLoginId { get; set; }

        /// <summary>
        /// User name of the customer account
        /// </summary>
        [StringLength(60, MinimumLength = 6,
            ErrorMessage = "UserName must have min length of 6 and max Length of 60")]
        [Required]
        public string UserName { get; set; }

        //PLACEHOLDER
        /// <summary>
        /// Password of the customer account
        /// Will need to ensure privacy of the password
        /// </summary>
        [StringLength(18, MinimumLength = 6,
            ErrorMessage = "Password must have min length of 6 and max Length of 18")]
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }

        /// <summary>
        /// A collection of Customers from the Customer class
        /// </summary>
        public ICollection<Customer> Customers { get; set; }
    }
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string UserName { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
    }
}