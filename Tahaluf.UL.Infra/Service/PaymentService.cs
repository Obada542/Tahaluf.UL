using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Repository;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.Infra.Service
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository; 
        public PaymentService(IPaymentRepository _paymentRepository)
        {
            this._paymentRepository = _paymentRepository;
        }
        public bool ChangeAmoutCard(Payment payment)
        { 
            return _paymentRepository.ChangeAmoutCard(payment);
        }

        public float GetCard(Payment payment)
        {
            return _paymentRepository.GetCard(payment);
        }
        public bool PayFines(int id)
        {
            return _paymentRepository.PayFines(id);
        }

    }
}
