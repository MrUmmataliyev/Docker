﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments.Domain.Models
{
    public class PaymentModel
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public DateTimeOffset DateOfPayment { get; set; }

    }
}
