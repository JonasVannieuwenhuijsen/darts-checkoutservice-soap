using System.ServiceModel;

namespace DartCheckout.Models
{
    [ServiceContract]
    public interface IDartCheckout
    {
        [OperationContract]
        public string getCheckout(string getal);

    }
}
