namespace ConsoleApp.Sesion3
{
    public class Exercise1
    {
        public static void Execute()
        {
            Client newClient = new Client(
                fullName: "Philip Pérez Castro",
                phone: 945124544,
                email: "jp1@gmail.com",
                isNewClient: true,
                address: "San Antonio z-8"
                );

            Console.Write(newClient.ToString());
        }

    }

    struct Client
    {
        string FullName { get; set; }
        int Phone { get; set; }
        string Email { get; set; }
        string Address { get; set; }
        Boolean IsNewClient { get; set; }

        public Client(string fullName, int phone, string email, string address, bool isNewClient)
        {
            FullName = fullName;
            Phone = phone;
            Email = email;
            Address = address;
            IsNewClient = isNewClient;
        }


        public override string ToString()
        {
            return $"Name: {FullName}\nPhone: {Phone}\nEmail: {Email}\nAddress:{Address}\nIs new client: {IsNewClient}";
        }
    }
}
