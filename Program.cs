// See https://aka.ms/new-console-template for more information



Menu();

//EXEMPLO PARA USAR SUBSTRING 


/*System.Console.WriteLine("Teste!!");
Thread.Sleep(1000);
System.Console.WriteLine("Entre com o valor de contagem e por fim se queres minuto ou segundo: ");
System.Console.WriteLine("Exemplo ==> 10s ou 2m");
string option = Console.ReadLine().ToLower();
var time = option.Substring(0, option.Length - 1);
//var type = option.Substring(option.Length - 1);<--- indico apenas daonde quero que comece ou 
var type = option.Substring(option.Length - 1, 1);//<--- indico daonde quero que comece e também a quantidade de caracteres que quero que aparece

System.Console.WriteLine($" O tempo é: {time} ");
System.Console.WriteLine($"O tipo é: {type}");
*/




static void Start(int time)

{


    int currentTime = 0;
    while (currentTime != time)
    {
        Console.Clear();
        currentTime++;
        System.Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }

    Console.Clear();
    System.Console.WriteLine("Sopwatch finalizado!");
    Thread.Sleep(2500);
    Menu();


}



static void Menu()
{

    Console.Clear();
    System.Console.WriteLine("Entre com uma das opções abaixo: ");
    System.Console.WriteLine("S - Segundo");
    System.Console.WriteLine("M - Minuto");
    System.Console.WriteLine(" 0 - Sair");

    char option = char.Parse(Console.ReadLine().ToLower());



    switch (option)
    {

        case 's':
            System.Console.WriteLine("Quanto tempo deseja contar? ");
            int timeSecond = int.Parse(Console.ReadLine());
            Start(timeSecond);
            break;
        case 'm':
            System.Console.WriteLine("Quanto tempo deseja contar? ");
            int timeMinute = int.Parse(Console.ReadLine());
            Start(timeMinute * 60);
            break;
        case '0':
            Console.Clear();
            Thread.Sleep(1000);
            System.Console.WriteLine("Obrigado por usar nosso sistema!");
            Thread.Sleep(1000);
            Environment.Exit(0);
            break;
        default:
            System.Console.WriteLine("Entre com um valor Válido!");
            Thread.Sleep(1000);
            System.Console.WriteLine("Retornando ao Menu...");
            Thread.Sleep(1000);
            Menu();
            break;






    }




}