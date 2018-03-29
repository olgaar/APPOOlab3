using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using APPOOlab2.Interfaces;
using System.Threading.Tasks;

namespace APPOOlab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.setId(5); book.setName("Tom Sawyer Mark Twain"); book.setPrice(90); book.setQuantity(30);

            IDbAccessable dbAccessor = new DbAccessor();
            Stock stock = new Stock(dbAccessor);
            stock.DeleteBookById(5);
            stock.AddNewBook(book);
            stock.ChangeQuantity(5, 20);

            ICatalogPrintable catalogPrinterConsole = new CatalogConsolePrinter();
            MarketingDepartment manager = new MarketingDepartment(dbAccessor, catalogPrinterConsole);
            manager.ChangePrice(1, 100);
            manager.ChangeName(5, "Tommy");
            manager.ShowCatalog();
            manager.ShowBookById(1);

            ICatalogPrintable catalogPrinterFile = new CatalogFilePrinter();
            ClientInterface customer = new ClientInterface(dbAccessor, catalogPrinterFile);
            customer.ShowCatalog();
            customer.BuyBook(5);
            customer.ShowCatalog();

            manager.ShowCatalog();
            stock.DeleteBookById(5);
            manager.ShowCatalog();
            

        }
    }
}
