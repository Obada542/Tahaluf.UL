using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;
        public PaymentController(IPaymentService _paymentService) 
        {
            this._paymentService = _paymentService;
        }
        [HttpPost] 
        public float GetCard([FromBody]Payment payment)
        {
            return _paymentService.GetCard(payment);
        }
        [HttpPut]
        public bool ChangeAmoutCard([FromBody] Payment payment)
        {
            return _paymentService.ChangeAmoutCard(payment);
        }
        [HttpPost,Route("payfines/{id}")]
        public bool PayFines( int id)
        {
            return _paymentService.PayFines(id);
        }
    }
}
