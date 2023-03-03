namespace ba1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = "";
        public short SupplierID { get; set; }
        public short CategoryID { get; set; }
        public string QuantityPerUnit { get; set; } = "";
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public short ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

        //"id": 1,
        //"productName": "Chai",
        //"supplierID": 1,
        //"categoryID": 1,
        //"quantityPerUnit": "10 boxes x 20 bags",
        //"unitPrice": 18,
        //"unitsInStock": 39,
        //"unitsOnOrder": 0,
        //"reorderLevel": 10,
        //"discontinued": false
    }
}
