//declarar una funcion
//clasico
int SumarClasico(int a, int b)
{
    //return numero1 + numero2;
    int suma = a + b;

    return suma;
}

//nuevo
int SumarNuevo(int numero1, int numero2) => numero1 + numero2;

//numero++;

void Informar(int nro)
{
    Console.WriteLine($"El numero ingresado es: {nro}");
}

//=====================================================

//programa principal
Console.WriteLine("Ingrese un numero:");
int numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese un numero:");
int numero2 = Convert.ToInt32(Console.ReadLine());

int resultado = SumarClasico(numero1, numero2);

Informar(resultado);
