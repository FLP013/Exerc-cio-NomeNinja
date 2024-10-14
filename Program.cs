string Nome, NomeNinja;

Console.Clear();

Console.WriteLine("--- NOME NINJA ---");

Console.Write("Digite o seu nome: ");
Nome = Console.ReadLine()!;

NomeNinja = Nome
.Replace("a", "KA")
.Replace("b", "ZU")
.Replace("c", "MI")
.Replace("d", "TE")
.Replace("e", "KU")
.Replace("f", "LU")
.Replace("g", "JI")
.Replace("h", "RI")
.Replace("i", "KI")
.Replace("j", "ZUS")
.Replace("k", "ME")
.Replace("l", "TA")
.Replace("m", "RIN")
.Replace("n", "TO")
.Replace("o", "MO")
.Replace("p", "NO")
.Replace("q", "KE")
.Replace("r", "SHI")
.Replace("s", "ARI")
.Replace("t", "CHI")
.Replace("u", "DO")
.Replace("v", "RU")
.Replace("w", "MEI")
.Replace("x", "NA")
.Replace("y", "FU")
.Replace("z", "ZI");

Console.WriteLine($"Seu nome ninja é {NomeNinja}");
