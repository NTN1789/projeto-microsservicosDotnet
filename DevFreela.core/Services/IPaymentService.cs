using System;
using DevFreela.core.DTOs;

namespace DevFreela.core.Services
{


public interface IPaymentService
{

      void ProcessPayment(PaymentInfoDTO paymentInfoDTO);

}

}