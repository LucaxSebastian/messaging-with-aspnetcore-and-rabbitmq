using MassTransit;
using messaging_with_aspnetcore_and_rabbitmq.Contracts;

namespace messaging_with_aspnetcore_and_rabbitmq.Consumers;

public class OrderCreatedConsumer : IConsumer<OrderCreated>
{
    public OrderCreatedConsumer() { }

    public Task Consume(ConsumeContext<OrderCreated> context)
    {
        Console.WriteLine(context.Message);

        return  Task.CompletedTask; 
    }
}

