using System.Security.AccessControl;

double Pi = 3.14159;

double Raio = 0;
Console.WriteLine("Qual tamanho do Raio, em CM ");
Raio =  double.Parse(Console.ReadLine());

double Altura = 0;
Console.WriteLine("Qual a altura, em CM ");
Altura = double.Parse(Console.ReadLine());

double Volume = Pi * (Raio * Raio) * Altura;

Console.WriteLine("-----------");

Console.WriteLine("O Volume da Lata é de " + Volume + "cm cubicos");
