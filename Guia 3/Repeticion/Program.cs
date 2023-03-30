//Ciclos de iteracion, repeticion

//ciclo repeticion finito
int j;
for (j = 0; j < 100; j++)
{
    System.Console.WriteLine(j);
}

//i++
//++i
//i = i + 1
for (int i = 0; i < 100; i++)
{
    System.Console.WriteLine(i);
}

for (int k = 0; k < 100; k = k + 4)
{
    System.Console.WriteLine(k);
}

for (int h = 1000; h > 10; h = h - 100)
{
    System.Console.WriteLine(k);
}

for (; ; )
{

}

//ciclo while (mientras)
int numero = 30;

while (numero > 0)
{
    System.Console.WriteLine(numero);
    numero = numero - 10;
    //numero -=10;
}

//ingrese un numero entero hasta que se ingrese el numero
System.Console.WriteLine("Ingrese un numero:");
int num = Convert.ToInt32(Console.ReadLine());

while (num != 0 && num != 5) //! =
{
    System.Console.WriteLine("Ingrese un numero:");
    num = Convert.ToInt32(Console.ReadLine());
}

//do-while
do
{
    System.Console.WriteLine("Ingrese un numero:");
    num = Convert.ToInt32(Console.ReadLine());
} while (num > 0);