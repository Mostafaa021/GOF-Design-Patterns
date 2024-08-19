using StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{

    public interface IExportService
    {
        void Export(Order order);
    }
    public class CSVExportService : IExportService
    {
        public void Export(Order order)
        {
            Console.WriteLine($"CSV Exporting .....{order.Name}  , {order.Customer} , {order.Amount}");

        }
    }
    public class PDFExportService : IExportService
    {
        public void Export(Order order)
        {
            Console.WriteLine($"PDF Exporting .....{order.Name}  , {order.Customer} , {order.Amount}");


        }
    }
    public class XMLExportService : IExportService
    {
        public void Export(Order order)
        {
            Console.WriteLine($"XML Exporting .....{order.Name}  , {order.Customer} , {order.Amount}");

        }
    }
    public class Order // context 
    {
        public int Id { get; set; }
        public int Amount { get; set; }

        public string Name { get; set; }

        public string Customer { get; set; }
        public string Description { get; set; }

        // public IExportService? _exportService { get; set; }
        public Order(int id, int amount, string name, string customer, string description)
        {
            Id = id;
            Amount = amount;
            Name = name;
            Customer = customer;
            Description = description;
        }

        public void Export(IExportService exportService)
        {
            if (exportService == null)
                throw new NullReferenceException(nameof(exportService));
            exportService?.Export(this);
        }
    }

}
