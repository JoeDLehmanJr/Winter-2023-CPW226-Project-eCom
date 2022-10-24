

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
        public int CustomerId { get; set; }

        /// <summary>
        /// First Name of User
        /// NOT NULL
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// LastName of User
        /// NOT NULL
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Combines FirstName and LastName into full name if needed
        /// </summary>
        public string FullName
        {
            return FullName = FirstName + " " + LastName;
        }

        /// <summary>
        /// Primary address of customer
        /// CAN BE NULL
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// Secondary Address of customer
        /// CAN BE NULL
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// City of the customer
        /// CAN BE NULL
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// State of the customer
        /// CAN BE NULL
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Zip Code of the user
        /// CAN BE NULL
        /// </summary>
        public int ZipCode { get; set; }

        /// <summary>
        /// Email of the user
        /// CAN BE NULL
        /// </summary>
        public string Email { get; set; }

        //PLACEHOLDER
        /// <summary>
        /// Determines whether email is confirmed and sends a boolean value
        /// </summary>
        public bool IsEmailConfirmed;

        //PLACEHOLDER
        /// <summary>
        /// Determines whether customer is subscribed and sends a boolean value
        /// </summary>
        public bool IsSubscribed;

    }
}