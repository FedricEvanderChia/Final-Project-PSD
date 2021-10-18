using CentuDY.Model;
using CentuDY.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentuDY.View
{
    public partial class TransactionReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TransactionCrystalReport transactionCrystalReport = new TransactionCrystalReport();
            TransactionDataSet transactionDataSet = GetDataSet(TransactionRepository.GetAllHeaderTransactionData());
            transactionCrystalReport.SetDataSource(transactionDataSet);
            crvTransaction.ReportSource = transactionCrystalReport;
        }

        private TransactionDataSet GetDataSet(List<HeaderTransaction> transactions)
        {
            TransactionDataSet transactionDataSet = new TransactionDataSet();
            var headerTransaction = transactionDataSet.HeaderTransaction;
            var detailTransaction = transactionDataSet.DetailTransaction;
            var footerTransaction = transactionDataSet.FooterTransaction;

            foreach(var header in transactions)
            {
                var headerRow = headerTransaction.NewRow();
                headerRow["TransactionId"] = header.TransactionId;
                headerRow["User Name"] = header.User.Name;
                headerRow["TransactionDate"] = header.TransactionDate;
                headerTransaction.Rows.Add(headerRow);

                //var grandTotal = 0;

                foreach (var detail in header.DetailTransactions)
                {
                    var detailRow = detailTransaction.NewRow();
                    detailRow["TransactionId"] = detail.TransactionId;
                    detailRow["MedicineName"] = detail.Medicine.Name;
                    detailRow["Quantity"] = detail.Quantity;
                    //grandTotal += detail.Quantity.Value;
                    detailRow["Price"] = detail.Medicine.Price;
                    detailTransaction.Rows.Add(detailRow);
                }

                var footerRow = footerTransaction.NewRow();

                //footerRow["GrandTotal"] = grandTotal.ToString();
                footerTransaction.Rows.Add(footerRow);
            }

            return transactionDataSet;
        }
    }
}