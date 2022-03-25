using System;

namespace OrderManagementSystem
{
    [Serializable]
    public class Client
    {
        public string Name { get; }
        public string ClientId { get; }

        public Client(){}
        
        public Client(string name, string clientId)
        {
            Name = name;
            ClientId = clientId;
        }

        public override bool Equals(object? obj)
        {
            Client temp = obj as Client;
            return temp != null && this.ClientId.Equals(temp.ClientId);
        }

        public override int GetHashCode()
        {
            return ClientId.GetHashCode() * 2;
        }
    }
}