namespace P02_SalesDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SalesContext context = new SalesContext();

            

            context.sales.Add(new() { CustomerId = 3, ProductId = 1, StoreId = 1 });
            context.SaveChanges();
        }
    }
}