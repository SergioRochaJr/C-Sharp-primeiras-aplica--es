//Screen Sound
string mensagemDeBoasVindas = " Boas-vindas ao Mozila WaterDAWG!";
// List<string> listaDeBandas = new List<string>();
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Bump of Chicken", new List<int> {10,9,9,8});
bandasRegistradas.Add("Mamonas Assassinas", new List<int>());


void ExibirLogo()
{
  Console.WriteLine(@"
  
███╗░░░███╗░█████╗░███████╗██╗██╗░░░░░░█████╗░
████╗░████║██╔══██╗╚════██║██║██║░░░░░██╔══██╗
██╔████╔██║██║░░██║░░███╔═╝██║██║░░░░░███████║
██║╚██╔╝██║██║░░██║██╔══╝░░██║██║░░░░░██╔══██║
██║░╚═╝░██║╚█████╔╝███████╗██║███████╗██║░░██║
╚═╝░░░░░╚═╝░╚════╝░╚══════╝╚═╝╚══════╝╚═╝░░╚═╝

░██╗░░░░░░░██╗░█████╗░████████╗███████╗██████╗░██████╗░░█████╗░░██╗░░░░░░░██╗░██████╗░
░██║░░██╗░░██║██╔══██╗╚══██╔══╝██╔════╝██╔══██╗██╔══██╗██╔══██╗░██║░░██╗░░██║██╔════╝░
░╚██╗████╗██╔╝███████║░░░██║░░░█████╗░░██████╔╝██║░░██║███████║░╚██╗████╗██╔╝██║░░██╗░
░░████╔═████║░██╔══██║░░░██║░░░██╔══╝░░██╔══██╗██║░░██║██╔══██║░░████╔═████║░██║░░╚██╗
░░╚██╔╝░╚██╔╝░██║░░██║░░░██║░░░███████╗██║░░██║██████╔╝██║░░██║░░╚██╔╝░╚██╔╝░╚██████╔╝
░░░╚═╝░░░╚═╝░░╚═╝░░╚═╝░░░╚═╝░░░╚══════╝╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝░░░╚═╝░░░╚═╝░░░╚═════╝░
  ");
  Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
  ExibirLogo();
  Console.WriteLine("\nDigite 1 para registrar uma banda");
  Console.WriteLine("Digite 2 para mostrar todas as bandas");
  Console.WriteLine("Digite 3 para avaliar uma banda");
  Console.WriteLine("Digite 4 para exibir a media de uma banda");
  Console.WriteLine("Digite -1 para sair");

  Console.Write("\nDigite a sua opção: ");
  string opcaoEscolhida = Console.ReadLine()!;
  int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
  switch (opcaoEscolhidaNumerica)
  {
    case 1: RegistrarBanda();
      break;
    case 2: ExibirBandas();
      break;
    case 3: AvaliarUmaBanda();
      break;
    case 4: Console.WriteLine("Você escolheu a opção "+opcaoEscolhida);
      break;
    case -1: Console.WriteLine("buh-bye my funny little fella");
      break;
    default: Console.WriteLine("Opção inválida!");
    break;
  }
}

void RegistrarBanda()
{
  Console.Clear();
  ExibirTituloDaOpcao("Registro de bandas");
  Console.Write("Digite o nome da banda que deseja registrar: ");
  string nomeDaBanda = Console.ReadLine()!;
  bandasRegistradas.Add(nomeDaBanda, new List<int>());
  Console.WriteLine($"A banda { nomeDaBanda } foi registrada com sucesso!");
  Thread.Sleep(2000);
  Console.Clear();
  ExibirOpcoesDoMenu();
}

void ExibirBandas()
{
  Console.Clear();
  ExibirTituloDaOpcao("Bandas registradas");
  // for (int i = 0;i<listaDeBandas.Count;i++)
  // {
  //   Console.WriteLine ($"Banda: {listaDeBandas[i]}");
  // }

  foreach(string banda in bandasRegistradas.Keys)
  {
    Console.WriteLine ($"Banda: {banda}");
  }
  Console.WriteLine("Digite qualquer tecla para voltar ao menu anterior");
  Console.ReadKey();
  ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
  int quantidadeDeLetras = titulo.Length;
  string asteriscos = string.Empty.PadLeft(quantidadeDeLetras,'*');
  Console.WriteLine(asteriscos);
  Console.WriteLine(titulo);
  Console.WriteLine(asteriscos+"\n");
}

void AvaliarUmaBanda()
{
  Console.Clear();
  ExibirTituloDaOpcao("Avalie uma banda!");
  Console.WriteLine("Digite o nome da banda que deseja avaliar: ");
  string nomeDaBanda = Console.ReadLine()!;
  if (bandasRegistradas.ContainsKey(nomeDaBanda))
  {
    Console.Write($"Qual nota a banda {nomeDaBanda} merece: ");
    int nota = int.Parse(Console.ReadLine()!);
    bandasRegistradas[nomeDaBanda].Add(nota);
    Console.WriteLine($"\nVocê atribuiu a nota {nota} para a banda {nomeDaBanda}.");
    Thread.Sleep(5000);
    Console.Clear();
    ExibirOpcoesDoMenu();
  }
  else
  {
    Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada em nossos sistemas");
  Console.WriteLine("Digite uma tecla para voltar ao menu");
  Console.ReadKey();
  ExibirOpcoesDoMenu();
  }
}

//ExibirOpcoesDoMenu();


// desafio 1
// string curso = "Progamação em C#";
// Console.WriteLine(curso);
// string nome = "Ferdinand";
// string sobrenome = "Braum";
// string nomeCompleto = nome+" "+sobrenome;
// Console.WriteLine(nomeCompleto);

//desafio 2

// void ChecaMedia() {
// int notaMedia = 4;
// if (notaMedia >= 5){
//   Console.WriteLine("Aprovado");
// } else{
//   Console.WriteLine("Reprovado");
// }
// }

// desafio 3

// void Calculadora(){  
//   string A = Console.ReadLine()!;
//   float X = float.Parse(A);
//   string B = Console.ReadLine()!;
//   float Y = float.Parse(B);
//   Console.WriteLine("Escolhe ae");
//   string opcao = Console.ReadLine();
//   int opcaoNumero = int.Parse(opcao);
//   switch(opcaoNumero)
//   {
//     case 1: Somar();
//     break;
//     case 2: Subtrair();
//     break;
//     case 3: Multiplicar();
//     break;
//     case 4: Dividir();
//     break;
//   }

// void Somar(){
//   Console.WriteLine(X+Y);
// }
// void Subtrair(){
//   Console.WriteLine(X-Y);
// }
// void Multiplicar(){
//   Console.WriteLine(X*Y);
// }
// void Dividir(){
//   Console.WriteLine(X/Y);
// }
// }
// Calculadora();

// desafio 4

// Dictionary<string, string> questionario = new Dictionary<string, string>{
// {"Qual a capital de Portugal?", "Lisboa"},
// {"Mil pássaros, em japonês.", "Chidori"},
// {"Último nome do autor desse código.", "Junior"},
// {"Qual peça do xadrez votou 13 na eleição?", "Cavalo"}
// };

// void showDaEspiga()
// {
//   int pontuacao = 0;
//   Console.WriteLine("Bem-vindo ao Show da Espiga! Responda as perguntas corretamente e ganhe absolutamente nada!");
//   foreach( var pergunta in questionario)
//   {
//   Console.WriteLine(pergunta.Key);
//   string resposta = Console.ReadLine();
//   if (resposta.ToLower() == pergunta.Value.ToLower()){
//     pontuacao ++;
//   }
//   }
//   Console.WriteLine($"Sua pontuação foi: {pontuacao}");
// }

// showDaEspiga();

// desafio 5

// Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
//     { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
//     { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
//     { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
//     { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
//     { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
// };

// void CalculaMedia(){
//   foreach (var carro in vendasCarros){
//     double totalDeCarros = carro.Value.Average();
//     Console.WriteLine($"Média de vendas do veículo {carro.Key} é {totalDeCarros}");
//   }
// }

// CalculaMedia();

