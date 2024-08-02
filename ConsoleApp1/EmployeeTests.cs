using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EmployeeTests
    {
        [Test]
        public void HourlyEmployee_ShouldUpdateWorkDaysAndVacation()
        {
            // Arrange
            string name = "John";
            int id = 1;
            uint noOfDays = 120;

            // Act 
            var hourlyEmployee = (HourlyEmployee)EmployeeFactory.CreateEmployee(EmployeeFactory.EmployeeType.Hourly, name, id);

            hourlyEmployee.Work(noOfDays);

            // Assert
            Assert.That(name == hourlyEmployee.Name);
            Assert.That(hourlyEmployee.DaysWorked > 0);
            Assert.That(hourlyEmployee.VacationBalance > 0);
        }

        [Test]
        public void HourlyEmployee_ShouldDeductVacation()
        {
            // Arrange
            string name = "John";
            int id = 1;
            uint noOfDays = 120;
            uint vacationDays = 1;

            // Act 
            var hourlyEmployee = (HourlyEmployee)EmployeeFactory.CreateEmployee(EmployeeFactory.EmployeeType.Hourly, name, id);

            hourlyEmployee.Work(noOfDays);
            uint initialVacationDays = hourlyEmployee.VacationBalance;

            hourlyEmployee.TakeVacation(vacationDays);

            // Assert
            Assert.That(name == hourlyEmployee.Name);
            Assert.That(hourlyEmployee.VacationBalance < initialVacationDays);
        }

        [Test]
        public void SalariedEmployee_ShouldUpdateWorkDaysAndVacation()
        {
            // Arrange
            string name = "John";
            int id = 1;
            uint noOfDays = 120;

            // Act 
            var salariedEmployee = (SalariedEmployee)EmployeeFactory.CreateEmployee(EmployeeFactory.EmployeeType.Salaried, name, id);

            salariedEmployee.Work(noOfDays);

            // Assert
            Assert.That(name == salariedEmployee.Name);
            Assert.That(salariedEmployee.DaysWorked > 0);
            Assert.That(salariedEmployee.VacationBalance > 0);
        }

        [Test]
        public void SalariedEmployee_ShouldDeductVacation()
        {
            // Arrange
            string name = "John";
            int id = 1;
            uint noOfDays = 120;
            uint vacationDays = 1;

            // Act 
            var salariedEmployee = (SalariedEmployee)EmployeeFactory.CreateEmployee(EmployeeFactory.EmployeeType.Salaried, name, id);

            salariedEmployee.Work(noOfDays);
            uint initialVacationDays = salariedEmployee.VacationBalance;

            salariedEmployee.TakeVacation(vacationDays);

            // Assert
            Assert.That(name == salariedEmployee.Name);
            Assert.That(salariedEmployee.VacationBalance < initialVacationDays);
        }

        [Test]
        public void Manager_ShouldUpdateWorkDaysAndVacation()
        {
            // Arrange
            string name = "John";
            int id = 1;
            uint noOfDays = 120;

            // Act 
            var manager = (Manager)EmployeeFactory.CreateEmployee(EmployeeFactory.EmployeeType.Manager, name, id);

            manager.Work(noOfDays);

            // Assert
            Assert.That(name == manager.Name);
            Assert.That(manager.DaysWorked > 0);
            Assert.That(manager.VacationBalance > 0);
        }

        [Test]
        public void Manager_ShouldDeductVacation()
        {
            // Arrange
            string name = "John";
            int id = 1;
            uint noOfDays = 120;
            uint vacationDays = 1;

            // Act 
            var manager = (Manager)EmployeeFactory.CreateEmployee(EmployeeFactory.EmployeeType.Manager, name, id);

            manager.Work(noOfDays);
            uint initialVacationDays = manager.VacationBalance;

            manager.TakeVacation(vacationDays);

            // Assert
            Assert.That(name == manager.Name);
            Assert.That(manager.VacationBalance < initialVacationDays);
        }
    }
}
