using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace Q1
{
    public partial class CustomerArrearsReport : Form
    {
        public CustomerArrearsReport(List<Account> accountRecords)
        {
            InitializeComponent();

            dgvCustomerArrears.DataSource = (from account in accountRecords
                                             let totalArrearsInMonths = (account.PaymentPeriod == PaymentPeriod.Annual ? account.ArrearsCount * 12
                                                    : account.PaymentPeriod == PaymentPeriod.BiAnnual ? account.ArrearsCount * 6
                                                    : account.PaymentPeriod == PaymentPeriod.Quaterly ? account.ArrearsCount * 3
                                                    : account.ArrearsCount)
                                             where account.ArrearsCount > 0
                                             select new
                                             {
                                                 account.AccountID,
                                                 account.PaymentPeriod,
                                                 totalArrearsInMonths
                                             }).ToList();
        }
    }
}
