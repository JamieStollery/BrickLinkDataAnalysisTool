using Data.Common;
using System.Threading.Tasks;

namespace Data.LocalDB
{
    public class OrdersDatabaseInitializer : IDatabaseInitializer
    {
        private readonly IDapperWrapper _dapperWrapper;

        public OrdersDatabaseInitializer(IDapperWrapper dapperWrapper)
        {
            _dapperWrapper = dapperWrapper;
        }

        public async Task CreateTables()
        {
            await CreateOrdersTable();
            await CreatePaymentsTable();
            await CreateCostsTable();
            await CreateItemsTable();
            await CreateOrderItemsTable();
        }

        private async Task CreateOrdersTable()
        {
            var sql = @"CREATE TABLE IF NOT EXISTS Orders(
                            Order_id INT PRIMARY KEY,
                            Buyer_name VARCHAR(128),
                            Date_ordered DATETIME,
                            Seller_name VARCHAR(128),
                            Status VARCHAR(128),
                            Store_name VARCHAR(128),
                            Total_count INT,
                            Unique_count INT
                        )";
            await _dapperWrapper.ExecuteAsync(sql);
        }

        private async Task CreatePaymentsTable()
        {
            var sql = @"CREATE TABLE IF NOT EXISTS Payments(
                            Order_id INT PRIMARY KEY,
                            Method VARCHAR(128),
                            Status VARCHAR(128),
                            Date_paid DATETIME,
                            Currency_code VARCHAR(128),
                            CONSTRAINT FK_OrderPayment FOREIGN KEY (Order_id) REFERENCES Orders(Order_id)
                        )";
            await _dapperWrapper.ExecuteAsync(sql);
        }

        private async Task CreateCostsTable()
        {
            var sql = @"CREATE TABLE IF NOT EXISTS Costs(
                            Order_id INT PRIMARY KEY,
                            Subtotal DECIMAL(8,4),
                            Grand_total DECIMAL(8,4),
                            Currency_code VARCHAR(128),
                            CONSTRAINT FK_OrderCost FOREIGN KEY (Order_id) REFERENCES Orders(Order_id)
                        )";
            await _dapperWrapper.ExecuteAsync(sql);
        }

        private async Task CreateItemsTable()
        {
            var sql = @"CREATE TABLE IF NOT EXISTS Items(
                            No VARCHAR(128),
                            Name VARCHAR(128),
                            Type VARCHAR(128),
                            CategoryID INT,
                            CONSTRAINT PK_Item PRIMARY KEY (No)
                        )";
            await _dapperWrapper.ExecuteAsync(sql);
        }

        private async Task CreateOrderItemsTable()
        {
            var sql = @"CREATE TABLE IF NOT EXISTS OrderItems(
                            Order_id INT,
                            Inventory_id INT,
                            Item_no VARCHAR(128),
                            Color_id INT,
                            Quantity INT,
                            New_or_used CHAR(1),
                            Completeness VARCHAR(128),
                            Unit_price VARCHAR(128),
                            Unit_price_final VARCHAR(128),
                            Disp_unit_price VARCHAR(128),
                            Disp_unit_price_final VARCHAR(128),
                            Currency_code VARCHAR(128),
                            Disp_currency_code VARCHAR(128),
                            Description VARCHAR(128),
                            Remarks VARCHAR(128),
                            CONSTRAINT PK_OrderItem PRIMARY KEY (Order_id, Inventory_id),
                            CONSTRAINT FK_OrderOrderItem FOREIGN KEY (Order_id) REFERENCES Orders(Order_id),
                            CONSTRAINT FK_ItemOrderItem FOREIGN KEY (Item_no) REFERENCES Items(No)
                        )";
            await _dapperWrapper.ExecuteAsync(sql);
        }
    }
}
