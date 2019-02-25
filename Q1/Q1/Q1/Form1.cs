using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
    public partial class Form1 : Form
    {
        List<WaterMeter> WaterMeterRecords;
        List<Account> AccountRecords;

        public Form1()
        {
            InitializeComponent();

            WaterMeterRecords = new List<WaterMeter>() {
                new WaterMeter
                {
                    MetreID = 100,
                    VolumeUsed = 68405,
                    HasBeenServiced = false,
                    OwnerAccountID = 10001
                },
                new WaterMeter
                {
                    MetreID = 101,
                    VolumeUsed = 11369,
                    HasBeenServiced = true,
                    OwnerAccountID = 10002
                },
                new WaterMeter
                {
                    MetreID = 102,
                    VolumeUsed = 138115,
                    HasBeenServiced = false,
                    OwnerAccountID = 10003
                },
                new WaterMeter
                {
                    MetreID = 103,
                    VolumeUsed = 102191,
                    HasBeenServiced = true,
                    OwnerAccountID = 10004
                },
                new WaterMeter
                {
                    MetreID = 104,
                    VolumeUsed = 791007,
                    HasBeenServiced = false,
                    OwnerAccountID = 10005
                }
            };

            AccountRecords = new List<Account>()
            {
                new Account {AccountID = 10001, EirCode = "K64R102", PaymentPeriod = PaymentPeriod.Annual, ArrearsCount = 2 },
                new Account {AccountID = 10002, EirCode = "K64R103", PaymentPeriod = PaymentPeriod.Monthly, ArrearsCount = 2},
                new Account {AccountID = 10003, EirCode = "K64R104", PaymentPeriod = PaymentPeriod.Quaterly, ArrearsCount = 1},
                new Account {AccountID = 10004, EirCode = "K64R101", PaymentPeriod = PaymentPeriod.Monthly, ArrearsCount = 0},
                new Account {AccountID = 10005, EirCode = "K64R102", PaymentPeriod = PaymentPeriod.BiAnnual, ArrearsCount = 0},
                new Account {AccountID = 10006, EirCode = "K64R103", PaymentPeriod = PaymentPeriod.BiAnnual, ArrearsCount = 0}
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvWaterMeters.DataSource = (from waterMeter in WaterMeterRecords
                                         select waterMeter).ToList();

            dgvAccount.DataSource = null;
        }

        private void dgvWaterMeters_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int selectedAccountID = Convert.ToInt32(dgvWaterMeters.Rows[e.RowIndex].Cells[3].Value);

                dgvAccount.DataSource = (from account in AccountRecords
                                         where account.AccountID == selectedAccountID
                                         select account).ToList();
            }
        }

        private void rbMetreID_CheckedChanged(object sender, EventArgs e)
        {
            if(rbMetreID.Checked)
            {
                dgvWaterMeters.DataSource = (from waterMeter in WaterMeterRecords
                                             orderby waterMeter.MetreID
                                             select waterMeter).ToList();

                dgvAccount.DataSource = null;
            }
        }

        private void rbVolumeUsed_CheckedChanged(object sender, EventArgs e)
        {
            dgvWaterMeters.DataSource = (from WaterMeter in WaterMeterRecords
                                         orderby WaterMeter.VolumeUsed
                                         select WaterMeter).ToList();

            dgvAccount.DataSource = null;
        }

        private void btnCustomerArrears_Click(object sender, EventArgs e)
        {
            using (CustomerArrearsReport custAR = new CustomerArrearsReport(AccountRecords))
            {
                custAR.ShowDialog();
            }
        }

        private void btnSummaryReport_Click(object sender, EventArgs e)
        {
            int totalVolWaterUsed = (from waterMeter in WaterMeterRecords
                                     select waterMeter.VolumeUsed).Sum();

            int totalAccountsInArrears = (from account in AccountRecords
                                          where account.ArrearsCount > 0
                                          select account.ArrearsCount).Count();

            string msg = $"Total volume of water used = {totalVolWaterUsed} & total number of accounts in arrears is {totalAccountsInArrears}";
            MessageBox.Show(msg);
        }
    }
}