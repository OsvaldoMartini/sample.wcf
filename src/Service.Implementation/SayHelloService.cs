using Service.Contract;

namespace Service.Implementation
{
    public class SayHelloService : ISayHelloService
    {
        public SayHelloResponse SayHello(SayHelloRequest request)
        {
            return new SayHelloResponse
            {
                HelloMessage = string.Format("Hi {0}",request.Name),
            };
        }
    }
}