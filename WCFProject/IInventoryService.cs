using System.ServiceModel;

namespace WCFProject
{
    [ServiceContract]
    public interface IInventoryService
    {
        [OperationContract]
        int AddInventoryItem(InventoryItem item);

        [OperationContract]
        InventoryItem GetInventoryItem(int itemId);

        [OperationContract]
        void UpdateInventoryItem(InventoryItem item);

        [OperationContract]
        void DeleteInventoryItem(int itemId);
    }
}
