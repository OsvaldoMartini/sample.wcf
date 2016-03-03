using System.ServiceModel;

namespace Service.Contract
{
    [ServiceContract]
    public interface ISayHelloService
    {
        [OperationContract]
        SayHelloResponse SayHello(SayHelloRequest request);
    }
}