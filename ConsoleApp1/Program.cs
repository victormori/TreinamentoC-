using System.Collections;

Random dado = new Random();

int rodada1 = dado.Next(1, 10);
int rodada2 = dado.Next(1, 10);
int rodada3 = dado.Next(1, 10);

int totalRodadas = rodada1 + rodada2 + rodada3;

if ((rodada1 == rodada2 ) || (rodada2 == rodada3) || (rodada1 == rodada3));
{
    Console.WriteLine("Voce ganhou um bonûs de 2 pontos");
    totalRodadas += 2;
}

if (totalRodadas == 15)
{
    Console.WriteLine($"Você ganhou uma viagem! - Você fez {totalRodadas} pontos ");
}
else if (totalRodadas == 20)
{
    Console.WriteLine($"Você ganhou 1.000.000 de reais!!! - Você fez {totalRodadas} pontos");
}
else if (totalRodadas == 12)
{
    Console.WriteLine($"Você ganhou um cachorro!!!! - Você fez {totalRodadas} pontos");
}
else
{
    Console.WriteLine($"Você não ganhou nada! - Você fez {totalRodadas} pontos ");
}
