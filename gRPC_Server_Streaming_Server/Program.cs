using Grpc.Core;
using ServerStream;
using System;
using System.IO;

namespace gRPC_Server_Streaming_Server
{
    class Program
    {
        const int portNumber = 50051;
        static void Main(string[] args)
        {
            Server server = null;
            try
            {
                server = new Server
                {
                    Services =
                    {
                        ServerStreamingService.BindService(new ServerStreamingImplementation())
                    },
                    Ports =
                    { 
                        new ServerPort("localhost", portNumber,ServerCredentials.Insecure)
                    }
                };

                server.Start();
                Console.WriteLine("Server started on port: " + portNumber);

                Console.ReadKey();
            }
            catch (IOException exception)
            {
                Console.WriteLine("Server failed to start " + exception.Message);
                throw;
            }
            finally 
            {
                if (server != null)
                {
                    server.ShutdownAsync().Wait();
                }
            }
        }
    }
}
