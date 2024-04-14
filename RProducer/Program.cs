using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;



namespace RProducer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            var factory = new ConnectionFactory { HostName = "localhost" };
            IConnection connection1 = factory.CreateConnection();
             var connection = connection1;
             var channel = connection.CreateModel();

            channel.QueueDeclare(queue: "TestApp",
                                 durable: false,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);


            int count = 0;
            while (true)
            {
                string message = $"{count++} Hello World!";
                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish(exchange: string.Empty,
                                     routingKey: "TestApp",
                                     basicProperties: null,
                                     body: body);
                Console.WriteLine($" [x] Sent {message}");
                System.Threading.Thread.Sleep(200);

               // Console.WriteLine(" Press [enter] to exit.");
               // Console.ReadLine();
            }
        }
    }
}
