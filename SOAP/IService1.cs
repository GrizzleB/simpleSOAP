using System.ServiceModel;

namespace SOAP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string Greet(string s1, string s2);

        [OperationContract]
        double MilesToKM(double d1);

    }

}
