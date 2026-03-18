//Projeto de cálculo e formatação simples: 

//5 notas da Sophia
int[] notasSophia = new int[] {93, 87, 98, 95, 100};
int somaSophia = notasSophia[0] + notasSophia[1] + notasSophia[2] + notasSophia[3] + notasSophia[4];
decimal mediaSophia = somaSophia / 5m;

//5 notas do nicolas
int[] notasNicolas = new int[] {80, 83, 82, 88, 85};
int somaNicolas = notasNicolas[0] + notasNicolas[1] + notasNicolas[2] + notasNicolas[3] + notasNicolas[4];
decimal mediaNicolas = somaNicolas / 5m;


// 5 notas da Zariah
int[] notasZariah = new int[] {84, 96, 73, 85, 79};
int somaZariah = notasZariah[0] + notasZariah[1]  + notasZariah[2] + notasZariah[3] + notasZariah[4];
decimal mediaZariah = somaZariah /5m;

//5 notas do Jeong
int[] notasJeong = new int[] {90, 92, 98, 100, 97};
int somaJeong = notasJeong[0] + notasJeong[1] + notasJeong[2] + notasJeong[3] + notasJeong[4];
decimal mediaJeong = somaJeong / 5m;

Console.WriteLine("Notas dos Alunos:\n");
Console.WriteLine(@"Sophia: 93, 87, 98, 95, 100
Nicolas: 80, 83, 82, 88, 85
Zahirah:   84, 96, 73, 85, 79
Jeong:  90, 92, 98, 100, 97");

Console.WriteLine($"\nEstudante:\tMédia \n Sophia\t\t{mediaSophia} \n Nicolas\t{mediaNicolas} \n Zahirah\t{mediaZariah} \n Jeong\t\t{mediaJeong}");
