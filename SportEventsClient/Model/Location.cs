/*
 * Authors: João Rodrigues and Daniel Leonard
 * Project: Practical Work, implementing services
 * Current Solution: Client of services for sport events
 * 
 * [MODEL]
 * Location -> Holds coordenates of a place
 * 
 * Subject: Integration of Informatic Systems
 * Degree: Graduation on Engineering of Informatic Systems
 * Lective Year: 2020/21
 */

namespace Model
{
    /// <summary>
    /// Holds coordenates of a place
    /// </summary>
    public class Location
    {
        string latitude, longitude;

        #region PROPERTIES
        public string Latitude { get => latitude; set => latitude = value; }
        public string Longitude { get => longitude; set => longitude = value; }
        #endregion

        // Class constructor
        public Location() { }

    }
}
