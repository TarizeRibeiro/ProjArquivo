using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Service
{
    [ServiceContract]
    public interface IArquivoService
    {
        [OperationContract]
        void RecuperarArquivo();
    }
}
