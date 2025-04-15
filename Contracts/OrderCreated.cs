using messaging_with_aspnetcore_and_rabbitmq.domain.entities;

namespace messaging_with_aspnetcore_and_rabbitmq.Contracts;

public class OrderCreated(Guid id, Customer customer)
{
    public Guid Id { get; set; } = id;
    public Customer Customer { get; set; } = customer;
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public override string ToString()
        => $"Pedido criado! ID: {Id} para o cliente {Customer.FullName}. Data da criação: {CreatedAt:d}";
}