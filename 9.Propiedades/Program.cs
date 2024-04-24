using _9.Propiedades;

Persona persona1 = new Persona("Marcos Méndez", 18, "Jutiapa");

Console.WriteLine("Nombre de la persona 1: " + persona1.Nombre); 
persona1.Nombre = "María Gómez"; 

Console.WriteLine("Edad de la persona 1: " + persona1.Edad); 
persona1.Edad = 42; 

Console.WriteLine("Ciudad de la persona 1: " + persona1.Ciudad); 
persona1.Ciudad = "Antigua Guatemala"; 

persona1.ImprimirInformacion(); 

