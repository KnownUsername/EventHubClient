/*
 * Authors: João Rodrigues and Daniel Leonard
 * Project: Practical Work, implementing services
 * Current Solution: Client of services for sport events
 * 
 * [MODEL]
 * User - Defines a user
 * 
 * Subject: Integration of Informatic Systems
 * Degree: Graduation on Engineering of Informatic Systems
 * Lective Year: 2020/21
 */

namespace Model
{
    /// <summary>
    /// Defines a user
    /// </summary>
    public class User
    {
        int id, accountId;
        string name;
        string email;
        string password;

        #region PROPERTIES

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public int AccountId { get => accountId; set => accountId = value; }
        #endregion

        /// <summary>
        /// Class constructor
        /// </summary>
        public User()
        {

        }

    }
}