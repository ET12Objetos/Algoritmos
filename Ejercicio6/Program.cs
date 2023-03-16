Console.Write("Ingrese valor booleano: ");
bool valor1 = bool.Parse(Console.ReadLine());
Console.Write("Ingrese valor booleano: ");
bool valor2 = Convert.ToBoolean(Console.ReadLine());

//Con el operador ! se niega un valor booleano
bool negacion1 = !valor1;
bool negacion2 = !valor2;

Console.WriteLine($"Valor1: {valor1}");
Console.WriteLine($"Negacion Valor1: {negacion1}");
Console.WriteLine($"Valor2: {valor2}");
Console.WriteLine($"Negacion Valor2: {negacion2}");

// Operador && se llama AND o conjuncion
bool conjuncion = valor1 && valor2;
Console.WriteLine($"Conjuncion: {conjuncion}");

// Operador || se llama OR o disyuncion
bool disyuncion = valor1 || valor2;
Console.WriteLine($"Disyuncion: {disyuncion}");

