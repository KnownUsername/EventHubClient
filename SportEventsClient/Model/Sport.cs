/*
 * Authors: João Rodrigues and Daniel Leonard
 * Project: Practical Work, implementing services
 * Current Solution: Client of services for sport events
 * 
 * [MODEL]
 * Sport -> Corresponds a sport, with an identifying id
 * 
 * Subject: Integration of Informatic Systems
 * Degree: Graduation on Engineering of Informatic Systems
 * Lective Year: 2020/21
 */

namespace Model
{
    /// <summary>
    /// Corresponds a sport, with an identifying id
    /// </summary>
    public class Sport
    {
        int id;
        string name;

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        #endregion

        /// <summary>
        /// Class constructor
        /// </summary>
        public Sport()
        {

        }
    }
}