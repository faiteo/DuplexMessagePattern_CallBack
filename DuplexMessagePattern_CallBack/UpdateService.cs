using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace DuplexMessagePattern_CallBack
{
    
    public class UpdateService : IUpdateService
    {
        public void ProcessUpdate()
        {
            for (int i = 0; i <= 10; i++)
            {
                OperationContext.Current.GetCallbackChannel<IUpdateServiceCallBack>().Update(i);
                Thread.Sleep(5000);
            }
        }

    }
}
