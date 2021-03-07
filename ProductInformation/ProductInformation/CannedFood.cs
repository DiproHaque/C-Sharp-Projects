using System;
using System.Collections.Generic;
using System.Text;

namespace ProductInformation
{
    internal class CannedFood : Product
    {
        internal struct Expire
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

        internal Expire(byte day, string month, ushort year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        internal void ShowExpiryDate()
        {
            Console.WriteLine("The Date of Expiration:");
            Console.WriteLine("Day:{0}", this.day);
            Console.WriteLine("Month: {0}", this.month);
            Console.WriteLine("Year: {0}", this.year);

        }
    }
        private Expire expiryDate;

        internal Expire ExpiryDate
        {
            get { return this.expiryDate; }
            set { this.expiryDate = value; }
        }

        private double totalPrice; 
      //  internal double Totalprice()
        //{
        //    price*.5=totalPrice
            
        //}

        internal CannedFood(ushort id, double quantity, double price, DateOfProduction productionDate, string manufacturerName, Expire expiryDate):base(id,quantity,price,productionDate,manufacturerName)
        {
            this.expiryDate = expiryDate;
        }

        internal override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Date of Expiration :{0}", this.expiryDate);
        }
        
    }
}
