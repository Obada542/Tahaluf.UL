using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Service
{
    public interface IPaymentService
    {
        float GetCard(Payment payment);
        bool ChangeAmoutCard(Payment payment);
        bool PayFines(int id);

    }
}
