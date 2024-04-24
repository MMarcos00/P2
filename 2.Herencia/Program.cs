
using _2.Herencia;

Empleado empleadoGenerico = new Empleado("Marcos Méndez", 2000); 
Gerente gerente = new Gerente("Fernanda Solloy", 3000, 500); 
Vendedor vendedor = new Vendedor("Juan Perez", 1500, 1000); 

Console.WriteLine($"Nombre del empleado genérico: {empleadoGenerico.Nombre}");
Console.WriteLine($"Salario neto del empleado genérico: {empleadoGenerico.CalcularSalarioNeto()}");

Console.WriteLine($"Nombre del gerente: {gerente.Nombre}");
Console.WriteLine($"Salario neto del gerente: {gerente.CalcularSalarioNeto()}");

Console.WriteLine($"Nombre del vendedor: {vendedor.Nombre}");
Console.WriteLine($"Salario neto del vendedor: {vendedor.CalcularSalarioNeto()}");
