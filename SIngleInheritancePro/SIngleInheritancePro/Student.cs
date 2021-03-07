using System;
using System.Collections.Generic;
using System.Text;

namespace SIngleInheritancePro
{
    internal class Student : Person
    {
        private double cgpa;
         internal double cgpa
        {
            get { return this.cgpa; }
            set { this.cgpa = value; }
        }
        internal Student(int id, string name, addressFormat homeAddress, string bloodGroup, double cgpa);
        //{ this.Id = id;
          //  this.Name = name;
           // this.HomeAddress = homeAddress;
            //this.BloodGroup = bloodGroup;
            //this.Cgpa = cgpa;
        //}
    }
}
