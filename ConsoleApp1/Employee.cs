using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public abstract uint VacationDaysPerYear { get; }
        private uint MaxNoOfWorkDays = 260;

        internal protected uint VacationBalance { get; private set; } = 0;
        internal protected uint DaysWorked { get; private set; } = 0;

        public void Work(uint days)
        {
            if (days <= MaxNoOfWorkDays)
            {
                DaysWorked += days;
                var fractionNo = ((double)VacationDaysPerYear / (double)MaxNoOfWorkDays) * days;

                VacationBalance = Convert.ToUInt32(Math.Floor(fractionNo));
            }
            else
            {
                throw new ArgumentException("Invalid day entry.");
            }
        }

        public void TakeVacation(uint days)
        {
            if (VacationBalance >= days)
                VacationBalance -= days;
            else
                throw new ArgumentException("Vacation balance is not sufficient.");
        }
    }

    public class HourlyEmployee : Employee
    {
        public override uint VacationDaysPerYear { get { return 10; } }
    }

    public class SalariedEmployee : Employee
    {
        public override uint VacationDaysPerYear { get { return 15; } }
    }

    public class Manager : SalariedEmployee
    {
        public override uint VacationDaysPerYear { get { return 30; } }
    }

    public static class EmployeeFactory
    {
        public enum EmployeeType
        {
            Hourly,
            Salaried,
            Manager
        }

        public static Employee CreateEmployee(EmployeeType type, string name, int id)
        {
            switch (type)
            {
                case EmployeeType.Hourly:
                    return new HourlyEmployee { Name = name, Id = id };
                case EmployeeType.Salaried:
                    return new SalariedEmployee { Name = name, Id = id };
                case EmployeeType.Manager:
                    return new Manager { Name = name, Id = id };
                default:
                    throw new ArgumentException("Invalid employee type");
            }
        }
    }
}
