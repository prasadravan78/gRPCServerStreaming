using Google.Api.Gax.Grpc;
using Grpc.Core;
using ServerStream;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ServerStream.ServerStreamingService;

namespace gRPC_Server_Streaming_Server
{
    public class ServerStreamingImplementation : ServerStreamingServiceBase
    {
        public override async Task ServerStream(ServerStreamingRequest request, IServerStreamWriter<ServerStreamingResponse> responseStream, ServerCallContext context)
        {
            string output = string.Empty;
            Console.WriteLine("Server received request on " + DateTime.Now);
            Console.WriteLine(request.ToString());

            foreach (int i in Enumerable.Range(1, 1000))
            {
                output = "Hello " + request.Stream.FirstName + " " + request.Stream.LastName + " Response count " + i;
                await responseStream.WriteAsync( new ServerStreamingResponse() { ServerResponse = output });
            }
        }
    }
}
