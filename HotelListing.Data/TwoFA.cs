using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelListing.API.Data
{
    public class TwoFA
    {
        #region Private Constantts
        private int C_INT_RECOVERY_TOKENS = 6;
        #endregion

        /// <summary>
        /// Primary key in the db
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Ota code
        /// </summary>
        public int OtaCode { get; set; }

        /// <summary>
        /// TODO List of recovery tokens
        /// </summary>
        //public List<string> RecoveryTokens { get; set; }

    }
}
