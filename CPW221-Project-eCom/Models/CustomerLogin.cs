

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
        public int CustomerLoginId { get; set; }

        /// <summary>
        /// User name of the customer account
        /// </summary>
        public string UserName { get; set; }

        //PLACEHOLDER
        /// <summary>
        /// Password of the customer account
        /// Will need to ensure privacy of the password
        /// </summary>
        public string Password { get; set; }
    }
}