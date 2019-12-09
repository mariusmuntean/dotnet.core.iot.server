using System;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace GrpcGreeter {
    public class GreeterService : Location.LocationBase {
        private readonly ILogger<GreeterService> _logger;

        public GreeterService (ILogger<GreeterService> logger) {
            _logger = logger;
        }

        public override Task<Ok> UpdateLocation (NewLocation request, ServerCallContext context) {

            Console.WriteLine ($"Roll {request.Roll} Pitch {request.Pitch} Yaw {request.Yaw}");

            return Task.FromResult (new Ok ());
        }
    }
}