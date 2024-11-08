// See https://aka.ms/new-console-template for more information

using Encapsulamento1;

People p = new People();


p.Nome = "Robson";
p.Idade = 22;
p.Tele = "(81) 98932-4351";
p.Endereço = "54517-110";
p.Email = "robson.@aluno.senai.br";


Console.WriteLine($"O nome dessa pessoa é: {p.Nome}");
Console.WriteLine($"Essa pessoa tem {p.Idade} anos");
Console.WriteLine($"O telefone dessa pessoa é: {p.Tele}");
Console.WriteLine($"O endereço dessa pessoa é: {p.Endereço}");
Console.WriteLine($"O Email dessa pessoa é: {p.Email}");

Console.ReadKey();