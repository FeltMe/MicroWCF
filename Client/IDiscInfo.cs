using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCF2
{
    [ServiceContract]
    interface IDiscInfo
    {
        [OperationContract]
        string[] GetDiskInfo(string path);
    }
}
