using ConsoleApp1;

Employee hourlyEmployee = (HourlyEmployee)EmployeeFactory.CreateEmployee(EmployeeFactory.EmployeeType.Hourly, "John", 1);
Employee salariedEmployee = (SalariedEmployee)EmployeeFactory.CreateEmployee(EmployeeFactory.EmployeeType.Salaried, "Bob", 2);
Employee manager = (Manager)EmployeeFactory.CreateEmployee(EmployeeFactory.EmployeeType.Manager, "Charlie", 3);

// Assuming specific properties for demonstration purposes
hourlyEmployee.Work(120);
hourlyEmployee.TakeVacation(2);

Console.WriteLine(hourlyEmployee.VacationBalance);

salariedEmployee.Work(120);
salariedEmployee.TakeVacation(2);

Console.WriteLine(((SalariedEmployee)salariedEmployee).VacationBalance);

manager.Work(120);
manager.TakeVacation(3);

Console.WriteLine(manager.VacationBalance);
