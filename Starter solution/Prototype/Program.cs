using Prototype;

Console.Title = "Prototype";

var manager = new Manager("Cindy");
// Casting back to Manager class is required as manager.Clone() will return a Person object
var managerClone = (Manager)manager.Clone();
Console.WriteLine($"Manager was cloned: {managerClone.Name}");

// Both the following lines should return the same result
//var employee = new Employee("Kevin", manager);
var employee = new Employee("Kevin", managerClone);
var employeeClone = (Employee)employee.Clone();
Console.WriteLine($"Employee was cloned: {employee.Name}," +
	$" with manager {employeeClone.Manager.Name}");

// Change the manager name
managerClone.Name = "Karen";
Console.WriteLine($"Employee was cloned: {employeeClone.Name}," +
	$" with manager {employeeClone.Manager.Name}");


Console.ReadKey();