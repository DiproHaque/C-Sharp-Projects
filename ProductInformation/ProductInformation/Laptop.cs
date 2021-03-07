using System;
using System.Collections.Generic;
using System.Text;

namespace ProductInformation
{
    internal class Laptop : Product
    {
        private ushort memorySize;
        private double clockSpeed;
        private byte batteryLifeTime;

        internal ushort MemorySize
        {
            get { return this.memorySize; }
            set { this.memorySize = value; }

        }
        internal double ClockSpeed
        {
            get { return this.clockSpeed; }
            set { this.clockSpeed = value; }
        }

        internal byte BatteryLifeTime
        {
            get { return this.batteryLifeTime; }
            set { this.batteryLifeTime = value; }
        }

        internal Laptop(ushort id, double quantity, double price, DateOfProduction productionDate, string manufacturerName, ushort memorySize, double clockSpeed, byte batteryLifeTime) : base(id, quantity, price, productionDate, manufacturerName)
        {
            this.MemorySize = memorySize;
            this.ClockSpeed = clockSpeed;
            this.BatteryLifeTime = batteryLifeTime;
        }

        internal override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Laptop's Configuration");
            Console.WriteLine("Memory Size: {0} ", this.memorySize);
            Console.WriteLine("Clock Speed: {0} ", this.clockSpeed);
            Console.WriteLine("Battery Life Time: {0} ", this.batteryLifeTime);
        }
    }
}
