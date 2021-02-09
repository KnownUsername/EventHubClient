/*
 * Authors: João Rodrigues and Daniel Leonard
 * Project: Practical Work, implementing services
 * Current Solution: Client of services for sport events
 * 
 * [MODEL]
 * Account -> Detailed information from an user
 * 
 * Subject: Integration of Informatic Systems
 * Degree: Graduation on Engineering of Informatic Systems
 * Lective Year: 2020/21
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Detailed information from an user
    /// </summary>
    public class Account
    {
        int accountId;
        string address;
        string shippingAddress;
        string bankId;

        #region PROPERTIES
        public string Address { get => address; set => address = value; }
        public string ShippingAddress { get => shippingAddress; set => shippingAddress = value; }
        public string BankId { get => bankId; set => bankId = value; }
        public int AccountId { get => accountId; set => accountId = value; }
        #endregion

        /// <summary>
        /// Class constructor
        /// </summary>
        public Account()
        {

        }
    }
}
