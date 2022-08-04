// See https://aka.ms/new-console-template for more information

Menu();

static void Menu(){
Console.Clear();
    Console.WriteLine("S = segundos");
    Console.WriteLine("M = minutos");
    Console.WriteLine("0 = Sair");

    string respostaUser = Console.ReadLine().ToUpper();

    switch(respostaUser){
        case "S": Start(1);break;
        case "M": Start(60);break;
        case "0": 
            Console.Clear();
            Console.WriteLine("Obrigado por usar nosso sistema");
            Thread.Sleep(2000);
            Console.Clear();
            System.Environment.Exit(0) 
        
        ;break;


        default: 
            Console.WriteLine("Error, tente novamente");
            Thread.Sleep(2000);
            Console.Clear();
            Menu();
        break;
    }
}

static void Start(int seconds){
    
    Console.WriteLine("Qual tempo?");
    float time = float.Parse(Console.ReadLine());
    

    for( float i= 0; i <= (time*seconds); i++ ){
        Console.Clear();
        Console.WriteLine(i);
        Thread.Sleep(1000);
    };

    Console.Clear();
    Console.WriteLine("Contagem finalizada.");
    Thread.Sleep(3000);
    Console.Clear();
    Menu();


}