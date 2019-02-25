using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public enum PaymentPeriod
    {
        Annual = 1,
        BiAnnual,
        Quaterly,
        Monthly
    }

    public class Account
    {
        public int AccountID { get; set; }
        public string EirCode { get; set; }
        public PaymentPeriod PaymentPeriod { get; set; }
        public int ArrearsCount { get; set; }
    }
}
