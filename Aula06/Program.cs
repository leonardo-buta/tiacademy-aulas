// Vetor ou Array
// Lista, List, ArrayList, Coleções
using Aula06;

//List<int[]> listaNomes = new List<int[]>();

List<string> listaNomes = new List<string>();
listaNomes.Add("Leonardo");
listaNomes.Add("Eduardo");
listaNomes.Add("Eric");

Console.WriteLine(listaNomes[0]);

foreach(string nome in listaNomes)
{
    Console.WriteLine(nome);
}

Console.WriteLine("\n");

listaNomes.Remove("Leonardo");

foreach(string nome in listaNomes)
{
    Console.WriteLine(nome);
}





// int[] numerosInteiros = new int[3];
// string[] nomes = new string[10];
// Pessoa[] pessoas = new Pessoa[10];

// numerosInteiros[0] = 15;
// numerosInteiros[1] = 99;
// numerosInteiros[2] = 22;
// //numerosInteiros[3] = 21;

// Console.WriteLine($"Capacidade do Array: {numerosInteiros.Length}");

// foreach (int numero in numerosInteiros)
// {
//     Console.WriteLine($"Valor: {numero}");
// }


// for (int i = 0; i < numerosInteiros.Length; i++)
// {
//     Console.WriteLine($"Posição {i} - Valor: {numerosInteiros[i]}");
// }

//Console.WriteLine($"Posição 0 - Valor: {numerosInteiros[0]}");
// Console.WriteLine($"Posição 1 - Valor: {numerosInteiros[1]}");
// Console.WriteLine($"Posição 2 - Valor: {numerosInteiros[2]}");
