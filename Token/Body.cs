using System;

namespace Token
{
    public class Body
    {
        /// <summary>
        /// key used to match users to token
        /// </summary>
        public Key publicKey;
        /// <summary>
        /// key used to authenticate to db
        /// </summary>
        private Key authKey;
        /// <summary>
        /// user ID that created token
        /// </summary>
        public string CreatorID;
        /// <summary>
        /// created date of token
        /// </summary>
        public DateTime createdDate;
        /// <summary>
        /// name given to token by creator
        /// </summary>
        public string name;

    }
}