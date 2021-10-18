using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Repository
{
    public class TransactionRepository
    {
        private static CentuDY_dbEntities db = new CentuDY_dbEntities();

        public static List<HeaderTransaction> GetAllHeaderTransactionData()
        {
            return db.HeaderTransactions.ToList();
        }
    }
}