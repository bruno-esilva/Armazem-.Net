namespace Armazem;

//public class Produto
//{
//    public Product() { }

//    public int Id { get; set; }
//    public string Nome { get; set; }
//    public int Qtd { get; set; }

//    public Produto(int id, string nome, int qtd)
//    {
//        this.Id = id;
//        this.Nome = nome;
//        this.Qtd = qtd;
//    }
//}
class Program
{
    //static List<Product> produtos;
    public static void Main(string[] args)
    {
        //produtos = new List<Product>();
        List<int> id = new List<int>();
        List<string> nome = new List<string>();
        List<int> qtd = new List<int>();
        int cadastros = 0;
        int opcao = 0;
        int i = 0;
        while (opcao != 4)
        {
            Console.Clear();
            Console.WriteLine("=============== Bem Vindo ao Sistema de Armazém ===============\n");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Cadastrar Produto");
            Console.WriteLine("2 - Listar Produtos");
            Console.WriteLine("3 - Quantidade de Produtos em Estoque");
            Console.WriteLine("4 - Sair");
            opcao = Convert.ToInt16(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    id.Add(id.Count + 1);
                    Console.Clear();
                    Console.WriteLine(" ========== Cadastro de Produtos ==========\n");
                    Console.WriteLine("Insira o nome do Produto:");
                    nome.Add(Console.ReadLine());
                    Console.WriteLine("Insira a quantidade do Produto:");
                    qtd.Add(Convert.ToInt16(Console.ReadLine()));
                    Console.Clear();
                    Console.WriteLine("Produto cadastrado com sucesso!");
                    cadastros++;
                    Console.ReadLine();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("========== Produtos Cadastrados ==========\n");
                    if (cadastros > 0)
                    {
                        while (i <= cadastros)
                        {
                            Console.WriteLine($"ID: {id[i]},Produto: {nome[i]}, Quantidade: {qtd[i]}");
                            i++;
                        };
                    } else { Console.WriteLine("Não existem produtos cadastrados."); };
                    Console.ReadLine();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("========== Estoque ==========\n");
                    if (cadastros > 0)
                    {
                        Console.WriteLine($"Você tem {cadastros} produtos cadastrados");
                        int produtosSomados = 0;
                        while(i <= cadastros){
                            produtosSomados = produtosSomados + qtd[i];
                            i++;
                        };
                        Console.WriteLine($"Você tem {produtosSomados} itens em estoque");
                    } else {
                        Console.WriteLine("Não existem produtos cadastrados!");
                            };
                    Console.ReadLine();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Até logo!");
                    break;
            }

        }
    }

}



