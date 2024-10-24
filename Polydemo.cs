using System;
using System.Collection.Generic;

namespace Polymorphism {
    public class worker
    ///<summary>
    ///Determines the weekly salary of a worker based on their weekly hours and wage.
    ///</summary>
    ///<param name="weeklyHours"> The number of hours worked per week.</param>
    ///<param name="wage">The hourly wage of the worker.</param>
    {
        public virtual void DetermineWeeklySalary(int weeklyHours, int wage)
        {
            Console.WriteLine("Type of worker must be Contractor or Employee.");
        }
    }

    //Employee inherits from base & overrides salalry calculation
    public class Employee : worker
    {
        public override void DetermineWeeklySalary(int weeklyHours, int wage)
        {
            base.DetermineWeeklySalary(weeklyHours, wage);
        }
    }
 }
