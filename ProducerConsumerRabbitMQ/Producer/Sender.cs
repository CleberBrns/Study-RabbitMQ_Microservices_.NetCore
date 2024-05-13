using RabbitMQ.Client;
using System.Text;

namespace Producer
{
    public class Sender
    {
        public static void Main(string[] args)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };

            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare("BasicTest", false, false, false, null);

                string message = $"Getting started with .Net Core RabbitMQ - At {DateTime.Now.ToShortTimeString()}";
                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish(string.Empty, "BasicTest", null, body);
                Console.WriteLine("Sent message {0}...", message);
            }

            Console.WriteLine("Press [enter] to exit the Sender App...");
            Console.ReadKey();
        }
    }
}
