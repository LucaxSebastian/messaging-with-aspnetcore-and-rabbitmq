using MassTransit;
using messaging_with_aspnetcore_and_rabbitmq.Contracts;
using messaging_with_aspnetcore_and_rabbitmq.domain.entities;
using Microsoft.AspNetCore.Mvc;
using System;

namespace messaging_with_aspnetcore_and_rabbitmq.Controllers;

[ApiController]
[Route("api/orders")]
public class OrdersController(IBus bus) : ControllerBase
{
    private readonly IBus _bus = bus;

    [HttpPost]
    public async Task<IActionResult> CreateOrder([FromBody] OrderCreated orderCreated)
    {
        var orderId = Guid.NewGuid();

        var customer = new Customer(
            orderCreated.Customer.Id,
            orderCreated.Customer.FullName,
            orderCreated.Customer.Email);

        await _bus.Publish(new OrderCreated(orderId, customer));

        return Ok(new { OrderId = orderId });
    }
}

