/*
 * Authors: João Rodrigues and Daniel Leonard
 * Project: Practical Work, implementing services
 * Current Solution: Client of services for sport events
 * 
 * [MODEL]
 * Team - Defines a team of an event
 * 
 * Subject: Integration of Informatic Systems
 * Degree: Graduation on Engineering of Informatic Systems
 * Lective Year: 2020/21
 */

namespace Model
{
    /// <summary>
    /// Enumerates leaderboards' places
    /// </summary>
    public enum Place
    {
        first = 1,
        second = 2,
        third = 3,
        fourth = 4,
        fifth = 5,
        sixth = 6,
        seventh = 7,
        eighth = 8,
        na = 0
    }

    /// <summary>
    /// Defines a team of an event
    /// </summary>
    public class Team
    {
        int id;
        //List<User> members;
        Place position;

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        //List<User> Members { get => members; set => members = value; }
        public Place Position { get => position; set => position = value; }
        #endregion

        public Team()
        {

        }
    }
}

