using System.ServiceModel;

namespace WCF2
{
    [ServiceContract]
    public interface IDiscInfo
    {
        [OperationContract]
        string[] GetDiskInfo(string path);
    }
}
