using Grpc.Core;
using ServerStream;
using System;
using System.Threading.Tasks;

namespace gRPC_Server_Streaming_Client
{
    class Program
    {
        const string serverUrl = "localhost:50051";
        static async Task Main(string[] args)
        {
            Channel channel = new Channel(serverUrl, ChannelCredentials.Insecure);

            await channel.ConnectAsync().ContinueWith((task) =>
            {
                if (task.Status == TaskStatus.RanToCompletion)
                {
                    Console.WriteLine("Client connected successfully.");
                }
            });

            var client = new ServerStreamingService.ServerStreamingServiceClient(channel);

            var serverStream = new ServerStreamMsg
            { 
                FirstName="First Name",
                LastName ="Last Name"                
            };

            var serverStreamingRequest = new ServerStreamingRequest()
            {
                Stream = serverStream
            };

            var response = client.ServerStream(serverStreamingRequest);

            while (await response.ResponseStream.MoveNext())
            {
                Console.WriteLine("Response : " + response.ResponseStream.Current.ServerResponse);
                await Task.Delay(200);
            }
            channel.ShutdownAsync().Wait();

            Console.ReadKey();
        }
    }
}
