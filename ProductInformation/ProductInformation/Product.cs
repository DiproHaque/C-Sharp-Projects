using System;
using System.Collections.Generic;
using System.Text;

namespace ProductInformation
{
   internal class Product
    {
        internal struct DateOfProduction
        {
            private byte day;
            private string month;
            private ushort year;

            internal byte Day
            {
                get { return this.day; }
                set { this.day = value; }
            }
            internal string Month
            {
                get { return this.month; }
                set { this.month = value; }
            }
            internal ushort Year
            {
                get { return this.year; }
                set { this.year = value; }
            }

            internal DateOfProduction(byte day, string month, ushort year)
            {
                this.day = day;
                this.month = month;
                this.year = year;
            }
            internal void ShowProductionDate()
            {
                Console.WriteLine("The Date of Production:");
                Console.WriteLine("Day:{0}", this.day);
                Console.WriteLine("Month: {0}", this.month);
                Console.WriteLine("Year: {0}", this.year);

            }
   
        }
        private ushort id;
        private double quantity;
        private double price;
        private DateOfProduction productionDate;
        private string manufacturerName;

        internal ushort Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        internal double Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }

        internal double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        internal DateOfProduction ProductionDate
        {
            get { return this.productionDate; }
            set { this.productionDate = value; }
        }

        internal string ManufacturerName
        {
            get { return this.manufacturerName; }
            set { this.manufacturerName = value; }
        }

        internal Product(ushort id, double quantity, double price, DateOfProduction productionDate, string manufacturerName)
        {
            this.Id = id;
            this.Quantity = quantity;
            this.Price = price;
            this.ProductionDate = productionDate;
            this.ManufacturerName = manufacturerName;
        }

        internal virtual void ShowInfo()
        {
            Console.WriteLine("Product Id: {0}", this.Id);
            Console.WriteLine("Quantity of Product: {0}", this.Quantity);
            Console.WriteLine("Price of Product: {0}", this.Price);
            Console.WriteLine("Day of Production: {0}", this.ProductionDate);
            Console.WriteLine("Name of Manufacturer: {0}", this.ManufacturerName);
        }
    }
}
