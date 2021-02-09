/*
 * Authors: João Rodrigues and Daniel Leonard
 * Project: Practical Work, implementing services
 * Current Solution: Client of services for sport events
 * 
 * [MODEL]
 * Session - Current session of an user
 * 
 * Subject: Integration of Informatic Systems
 * Degree: Graduation on Engineering of Informatic Systems
 * Lective Year: 2020/21
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    /// <summary>
    /// Current session of an user
    /// </summary>
    public static class Session
    {
        static User currentUser = new User(); // identifies who's the user
        static string token; // Authorization's Token to use service's methods 

        public static User CurrentUser
        {
            get => currentUser; set => currentUser = value;
        }
        public static string Token { get => token; set => token = value; }

    }
}
