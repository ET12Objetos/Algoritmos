//declara una variable entera con nombre 'numero'
int numero;

Console.Write("Ingrese un numero: ");
//se lee por pantalla/consola un valor entero
numero = Convert.ToInt32(Console.ReadLine());

//informar por pantalla el valor ingresado por el usuario
Console.WriteLine($"Ud. ha ingresado {numero}");

//declaramos una variable de tipo string
string mensaje;

Console.WriteLine("Ingrese un mensaje:");

//leemos una cadena de caracteres de la consola
mensaje = Console.ReadLine();

//informar el valor de la variable 'mensaje' por consola
Console.WriteLine($"El mensaje ingresado es: {mensaje}");

