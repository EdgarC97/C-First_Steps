//Taller practico
//Escribe un programa que imprima "¡Hola, mundo!" en la consola.
// Console.WriteLine ("Hello world!");

//Declara un int y un string, asignarles valores e imprímelos.
// int edad = 27;
// string name = "Edgar";
// Console.WriteLine($"My name is: {name} and my age is: {edad}");

//Convierte un string a mayúsculas y a minúsculas.
// string toMayus = name.ToUpper();
// string toMinus = name.ToLower();
// Console.WriteLine($"A mayusculas: {toMayus} , a Minusculas: {toMinus}");

//Declara dos int, realizar suma, resta, multiplicación y división, y muestra los resultados.
// int x = 50;
// int y = 20;

// int sum = x + y;
// int rest = x-y;
// int multiplication = x*y;
// int division = x/y;
// Console.WriteLine($"La suma es: {sum}, La resta es: {rest}, La multiplicacion es: {multiplication}, La Division es: {division}");

//Declara dos int, realiza comparaciones de igualdad, desigualdad, mayor que y menor que, y muestra los resultados.
// int x = 40;
// int y = 20;
// bool equal = x == y;
// bool desEqual = x != y;
// bool major = x > y;
// bool minor = x < y;

// Console.WriteLine(@$"Son iguales los numeros?: {equal}
// Son diferentes los numeros?: {desEqual}
// El primer numero es mayor al segundo?: {major}
// El primer numero es menor que el segundo?: {minor}");

//Busca una palabra específica en un string y reemplazarla por otra.
// string specificWord = "Anita lava la tina";
// string searchWord = specificWord.Replace("Anita", "Pepito");
// Console.WriteLine(searchWord);

//Pide al usuario su nombre y edad, luego imprime un mensaje con esta información.
// Console.WriteLine("Por favor ingresa tu nombre:");
// string? userName = Console.ReadLine();
// Console.WriteLine("Por favor ingresa tu edad:");
// string? userAge = Console.ReadLine();
// Console.WriteLine(@$"Tu Nombre es: {userName}
// Tu Edad es: {userAge}");

//Declara un int y escribe un programa que indique si es mayor, menor o igual a 10
// int baseNumber = 10;
// Console.WriteLine("Por favor ingresa numero:");
// int testNumber = Convert.ToInt32(Console.ReadLine());
// if(testNumber == baseNumber)
// {
//     Console.WriteLine("Tu numero es igual a 10");
// }
// else if (testNumber > baseNumber)
// {
//     Console.WriteLine("Tu numero es mayor a 10");
// }
// else if (testNumber < baseNumber)
// {
//     Console.WriteLine("Tu numero es menor a 10");
// }
// else
// {
//     Console.WriteLine("Escribe un numero por favor");
// }

//Declara dos variables double, realiza suma, resta, multiplicación y división, y muestra los resultados.
// double x = 18.9;
// double y = 31.1;

// double sum = x + y;
// double rest = Math.Round(x-y,2);
// double multiplication = x*y;
// double division = Math.Round(x/y,2);
// Console.WriteLine($"La suma es: {sum}, La resta es: {rest}, La multiplicacion es: {multiplication}, La Division es: {division}");

//Declarar dos variables string, concatenarlas y mostrar el resultado.
// string text1 = "PEPE";
// string text2 = "MOJICA";
// Console.WriteLine($"String 1= {text1} String 2 =: {text2}");

//Declara una variable int, conviértela a double y muestra ambos valores.
// int numberTest = 50;
// double convertNumber = Convert.ToDouble(numberTest);
// Console.WriteLine($"Double convertido = {convertNumber}");
// Console.WriteLine($"Double convertido = {convertNumber.GetType()}");

// Escribe un programa que pida al usuario un número y muestre si es positivo, negativo o cero.
// int baseNumber = 0;
// Console.WriteLine("Por favor ingresa numero:");
// int testNumber = Convert.ToInt32(Console.ReadLine());
// if(testNumber == baseNumber)
// {
//     Console.WriteLine("Tu numero es 0");
// }
// else if (testNumber > baseNumber)
// {
//     Console.WriteLine("Tu numero es positivo");
// }
// else if (testNumber < baseNumber)
// {
//     Console.WriteLine("Tu numero es negativo");
// }
// else
// {
//     Console.WriteLine("Escribe un numero por favor");
// }

// Usa un bucle for para imprimir los números del 1 al 10.
// for (int i = 0; i < 11; i++)
// {
//     Console.WriteLine(i);
// }

//Elimina los espacios en blanco al inicio y al final de un string, y formatea el string para que empiece con mayúscula y el resto en minúsculas.
// string text1 = " Juanito alimaña sin mucha maña llega al mostrador ";
// string textWithOutSpaces = text1.Trim();
// Console.WriteLine(textWithOutSpaces);

//Escribe un programa que pida al usuario un número y muestre su tabla de multiplicar del 1 al 10.
// Console.WriteLine("Escribe un numero: ");

// int userNumber;
// // Verificar que el valor introducido es un número entero
// while (!int.TryParse(Console.ReadLine(), out userNumber))
// {
//     Console.WriteLine("Por favor, introduce un número válido: ");
// }

// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine($"{userNumber} x {i} = {userNumber * i}");
// }

//Concatena dos strings y muestra la longitud de cada uno.
// string text1 = "Hola";
// string text2 = "PEPE";

// // Mostrar los textos y sus longitudes directamente
// Console.WriteLine($"El texto 1 es: {text1} y su longitud es: {text1.Length}");
// Console.WriteLine($"El texto 2 es: {text2} y su longitud es: {text2.Length}");


//Extrae una subcadena de un string y muestra la subcadena y su longitud.
// string text1 = "Hola";

// Console.WriteLine(@$"Extraemos desde la segunda letra: {text1.Substring(1)} 
// La longitud del texto es: {text1.Length}");