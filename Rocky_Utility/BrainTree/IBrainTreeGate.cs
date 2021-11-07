using Braintree;

namespace RockyStore_Utility.BrainTree
{
    public interface IBrainTreeGate
    {
        IBraintreeGateway CreateGateway();

        IBraintreeGateway GetGateway();
    }
}
