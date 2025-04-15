namespace messaging_with_aspnetcore_and_rabbitmq.domain.entities;

public class Customer(int id, string fullName, string email)
{
    public int  Id { get; set; } = id;
    public string FullName { get; set; } = fullName;
    public string Email { get; set; } = email;
}