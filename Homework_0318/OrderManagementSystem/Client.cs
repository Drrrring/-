namespace OrderManagementSystem
{
    public class Client
    {
        public string Name { get; }
        public string ClientId { get; }

        public Client(string name, string clientId)
        {
            Name = name;
            ClientId = clientId;
        }
    }
}