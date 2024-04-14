using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client.Events;
using RabbitMQ.Client;



namespace RConsumer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var factory = new ConnectionFactory { HostName = "localhost" };
             var connection = factory.CreateConnection();
             var channel = connection.CreateModel();

            channel.QueueDeclare(queue: "TestApp",
                                 durable: false,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);

            Console.WriteLine(" [*] Waiting for messages.");

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (model, ea) =>
            {
                try {
                    var body = ea.Body.ToArray();
                    var message = Encoding.UTF8.GetString(body);
                    Console.WriteLine($" [x] Received {message}");

                    channel.BasicAck(ea.DeliveryTag, false);

                }
                catch (Exception ex)
                {
                    channel.BasicNack(ea.DeliveryTag, false, false);
                }
                
            };
            channel.BasicConsume(queue: "TestApp",
                                 autoAck: false,
                                 consumer: consumer);

            Console.WriteLine(" Press [enter] to exit.");
            Console.ReadLine();
        }
    }
}
