using System;

namespace ProductInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Product saltedFish = new CannedFood(1, 20.5, 200.99, new productionDate(06, "March", 2021), Ahmed, new Expire(20, "May", 2021),);
            saltedFish.ShowInfo();
        }
    }
}
