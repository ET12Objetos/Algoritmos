//Ejercicio 1

// Dados dos valores numéricos enteros a y b ingresados por pantalla,
// calcular e informar la suma: a + b, la diferencia: a - b, 
// y el producto: a * b entre dichos valores.

Console.WriteLine("Ingrese un numero:");
int numero1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese un numero:");
int numero2 = Convert.ToInt32(Console.ReadLine());

int suma = numero1 + numero2;

Console.WriteLine($"La suma es: {suma}");

Console.WriteLine($"La diferencia es: {numero1 - numero2}");

Console.WriteLine($"El producto es: {numero1 * numero2}");