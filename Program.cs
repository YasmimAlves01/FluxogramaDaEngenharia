string escolha;

Console.WriteLine("Fluxo de engenharia");

Console.WriteLine("Esta se movendo? sim ou não");
escolha = Console.ReadLine()!.ToUpper();

if (escolha == "SIM"){
    Console.WriteLine("Deveria? sim ou não");
    escolha = Console.ReadLine()!.ToUpper();

    if(escolha == "SIM")
    {
        Console.WriteLine("Otimo");
    }
    else{
        Console.WriteLine("Use fita");
    }

}
else {
    Console.WriteLine("Deveria? sim ou não");
    escolha = Console.ReadLine()!.ToUpper();
    if(escolha == "NAO")
    {
        Console.WriteLine("otimo");
    }
    else
    {
        Console.WriteLine("Use WD-40");
    }

}


