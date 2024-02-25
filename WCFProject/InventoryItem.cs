using System.Runtime.Serialization;

namespace WCFProject
{
    [DataContract]
    public class InventoryItem
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public int Quantity { get; set; }

        [DataMember]
        public decimal UnitPrice { get; set; }
    }
}
