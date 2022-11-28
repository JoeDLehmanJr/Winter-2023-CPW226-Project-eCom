

using System.ComponentModel.DataAnnotations;

namespace CPW221_Project_eCom.Models
{
    /// <summary>
    /// Model for Customer. Uses DB values and assigns them to an individual customer for the site
    /// </summary>
	public class Customer
    {
        /// <summary>
        /// Unique Primary Identity Key for each customer
        /// NOT NULL
        /// WARNING: Two cases of CustomerId in DB. CustomerId in Customer will be both primary and foreign
        /// </summary>
        [Key]
        public int CustomerId { get; set; }

        /// <summary>
        /// First Name of User
        /// NOT NULL
        /// </summary>
        [StringLength(25, MinimumLength = 6,
            ErrorMessage = "First name must have min length of 6 and max Length of 25")]
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// LastName of User
        /// NOT NULL
        /// </summary>
        [StringLength(25, MinimumLength = 6,
            ErrorMessage = "Last name must have min length of 6 and max Length of 25")]
        [Required]
        public string LastName { get; set; }

        /// <summary>
        /// Combines FirstName and LastName into full name if needed
        /// </summary>
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        /// <summary>
        /// Primary address of customer
        /// CAN BE NULL
        /// </summary>
        [StringLength(50,
            ErrorMessage = "Address must have a max Length of 50")]
        public string Address1 { get; set; }

        /// <summary>
        /// Secondary Address of customer
        /// CAN BE NULL
        /// </summary>
        [StringLength(50,
            ErrorMessage = "Address must have a max Length of 50")]
        public string Address2 { get; set; }

        /// <summary>
        /// City of the customer
        /// CAN BE NULL
        /// </summary>
        [StringLength(58,
            ErrorMessage = "City name must have a max Length of 58")]
        public string City { get; set; }

        /// <summary>
        /// State of the customer
        /// CAN BE NULL
        /// </summary>
        [StringLength(14,
            ErrorMessage = "The state must have a max Length of 14")]
        public string State { get; set; }

        /// <summary>
        /// Zip Code of the user
        /// CAN BE NULL
        /// </summary>
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }

        /// <summary>
        /// Email of the user
        /// CAN BE NULL
        /// </summary>
        [DataType(DataType.EmailAddress)]
        [StringLength(255,
            ErrorMessage = "Email addresses are composed by taking a username plus an at symbol plus a domain name including a TLD. this whole string can not exceed 255 characters. ")]
        public string Email { get; set; }

        /// <summary>
        /// Determines whether email is confirmed and sends a boolean value
        /// </summary>
        public bool IsEmailConfirmed;

        /// <summary>
        /// Determines whether customer is subscribed and sends a boolean value
        /// </summary>
        public bool IsSubscribed;

        /// <summary>
        /// A collection of Customers from the Customer class
        /// </summary>

        public int CustomerLoginId { get; set; }


        /// <summary>
        /// makes the customerLogin class into a object
        /// </summary>
        public CustomerLogin CustomerLogin { get; set; }

        public ICollection<CustomerLogin> _CustomersLogin { get; set; }

    }
}
