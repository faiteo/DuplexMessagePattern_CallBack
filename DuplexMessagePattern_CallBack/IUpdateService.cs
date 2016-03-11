using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace DuplexMessagePattern_CallBack
{
    
    [ServiceContract(CallbackContract = typeof(IUpdateServiceCallBack))]
    public interface IUpdateService
    {
        [OperationContract(IsOneWay=true)]
        void ProcessUpdate();
    }

    public interface IUpdateServiceCallBack
    {
        [OperationContract(IsOneWay = true)]
        void Update(int currentValue);
    }
}
