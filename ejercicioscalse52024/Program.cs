using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar la carga de valores positivos hasta que se ingrese un cero
        Console.WriteLine("Ingrese números positivos (ingrese 0 para terminar):");
        double numero;
        double numeroMayor = double.MinValue;
        double numeroMenor = double.MaxValue;

        while (true)
        {
            numero = Convert.ToDouble(Console.ReadLine());

            if (numero == 0)
                break;
            else if (numero < 0)
                Console.WriteLine("Por favor, ingrese un número positivo.");
            else
            {
                if (numero > numeroMayor)
                    numeroMayor = numero;
                if (numero < numeroMenor)
                    numeroMenor = numero;
            }
        }

        // Mostrar el número mayor y el menor
        if (numeroMayor != double.MinValue && numeroMenor != double.MaxValue)
        {
            Console.WriteLine("El número mayor ingresado es: " + numeroMayor);
            Console.WriteLine("El número menor ingresado es: " + numeroMenor);
        }
        else
        {
            Console.WriteLine("No se ingresaron números positivos.");
        }

        {
            // Adivinar el numero que estoy pensando

            // Paso 1: Pedir a la persona que anote un número
            Console.WriteLine("Por favor, anota un número cualquiera:");
            int numero1 = int.Parse(Console.ReadLine());

            // Paso 2: Multiplicar el número por 2
            int resultado = numero1 * 2;

            // Paso 3: Sumarle 8 al resultado
            resultado += 8;

            // Paso 4: Multiplicar el resultado por 5
            resultado *= 5;

            // Paso 5: Pedir el resultado final a la persona
            Console.WriteLine("Por favor, ingresa el resultado final:");
            int resultadoFinal = int.Parse(Console.ReadLine());

            // Paso 6: Anular la última cifra
            resultado /= 10;

            // Paso 7: Restarle 4 al resultado
            resultado -= 4;

            // Paso 8: Mostrar el número que pensó la persona
            if (resultado == numero)
            {
                Console.WriteLine("¡El número que pensaste es correcto!");
            }
            else
            {
                Console.WriteLine("Hubo un error en el cálculo. El número que pensaste no coincide.");
            }
        }

        {
            //Contador de palabras
            Console.Write("Ingrese una frase: ");
            string frase = Console.ReadLine();

            int contadorPalabras = 0;
            int contadorVocales = 0;
            bool estaEnPalabra = false;

            for (int i = 0; i < frase.Length; i++)
            {
                char caracter = frase[i];

                if (char.IsLetter(caracter))
                {
                    if (!estaEnPalabra)
                    {
                        contadorPalabras++;
                        estaEnPalabra = true;
                    }

                    if (EsVocal(caracter))
                    {
                        contadorVocales++;
                    }
                }
                else
                {
                    estaEnPalabra = false;
                }
            }

            Console.WriteLine($"La cantidad de palabras es: {contadorPalabras}");
            Console.WriteLine($"La cantidad de vocales es: {contadorVocales}");
        }

        static bool EsVocal(char caracter)
        {
            char caracterMinuscula = char.ToLower(caracter);
            return caracterMinuscula == 'a' || caracterMinuscula == 'e' || caracterMinuscula == 'i' || caracterMinuscula == 'o' || caracterMinuscula == 'u';
        }
        // Solicitar al usuario ingresar una palabra
        Console.WriteLine("Ingrese una palabra:");
        string palabra = Console.ReadLine();

        // Variable para almacenar la palabra al revés
        string palabraAlReves = "";

        // Utilizar un bucle for para invertir la palabra
        for (int i = palabra.Length - 1; i >= 0; i--)
        {
            palabraAlReves += palabra[i];
        }

        // Verificar si la palabra original es igual a la palabra invertida
        if (palabra.Equals(palabraAlReves, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("La palabra '" + palabra + "' es un palíndromo.");
        }
        else
        {
            Console.WriteLine("La palabra '" + palabra + "' no es un palíndromo.");
        }

        Console.ReadLine(); // Esto es para mantener la consola abierta hasta que el usuario presione una tecla
    }

}



    



