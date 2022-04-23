using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Repository
{
    public interface IPaymentRepository
    {
        float GetCard(Payment payment);
        bool ChangeAmoutCard(Payment payment);
        bool PayFines(int id);
    }
}
