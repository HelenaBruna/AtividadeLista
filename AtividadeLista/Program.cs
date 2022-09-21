using AtividadeLista.classes;
using System;

namespace AtividadeLista
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = -1;
            int dia = 0;
            int mes = 0;
            int ano = 0;
            string nome = "";
            string email = "";
            string telefone = "";
            Contato contato = new Contato();
            Contatos agenda = new Contatos();
            Data data = new Data();

            do
            {
                Console.WriteLine("0 - Sair");
                Console.WriteLine("1 - Adicionar contato");
                Console.WriteLine("2 - Pesquisar contato");
                Console.WriteLine("3 - Alterar contato");
                Console.WriteLine("4 - Remover contato");
                Console.WriteLine("5 - Listar contatos");

                Console.Write("Digite sua opção: ");
                opcao = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Saindo");

                        break;
                    case 1:
                        Console.Write("Digite o nome do Contato: ");
                        nome = Console.ReadLine();

                        Console.Write("Digite o email do Contato: ");
                        email = Console.ReadLine();

                        Console.Write("Digite o telefone do Contato: ");
                        telefone = Console.ReadLine();


                        Console.Write("Digite o dia de nascimento do contato: ");
                        dia = int.Parse(Console.ReadLine());

                        Console.Write("Digite o mês de nascimento do contato: ");
                        mes = int.Parse(Console.ReadLine());

                        Console.Write("Digite o ano de nascimento do contato: ");
                        ano = int.Parse(Console.ReadLine());


                        data.SetData(dia, mes, ano);

                        contato = new Contato(email, nome, telefone, data);

                        if (agenda.Adicionar(contato))
                        {
                            Console.WriteLine("Contato adicionado!");
                        }
                        else
                        {
                            Console.WriteLine("Contato não adicionado!");
                        }

                        break;
                    case 2:
                        Console.WriteLine("Digite o nome do contato: ");
                        contato.Nome = Console.ReadLine();

                        contato = agenda.Pesquisar(contato);

                        if (contato != null)
                        { 
                            Console.WriteLine(contato.ToString());
                        }
                        else
                        { 
                            Console.WriteLine("Contato não localizado!");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Digite o nome do contato: ");
                        contato.Nome = Console.ReadLine();

                        contato = agenda.Pesquisar(contato);

                        if (contato != null)
                        {
                            Console.Write("Digite o novo nome do Contato: ");
                            contato.Nome = Console.ReadLine();

                            Console.Write("Digite o novo email do Contato: ");
                            contato.Email = Console.ReadLine();

                            Console.Write("Digite o novo telefone do Contato: ");
                            contato.Telefone = Console.ReadLine();

                            Console.WriteLine(agenda.Alterar(contato) ? "Contato alterado!" : "Contato não alterado!");
                        }
                        else
                        { 
                            Console.WriteLine("Contato não localizado!");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Digite o nome do contato: ");
                        contato.Nome = Console.ReadLine();

                        contato = agenda.Pesquisar(contato);

                        if (contato != null)
                        {
                            agenda.Remover(contato);

                            Console.WriteLine("Contato removido!");
                        }
                        else
                        { 
                            Console.WriteLine("Contato não localizado!");
                        }
                        break;

                    case 5:
                        foreach (Contato c in agenda.Agenda)
                        {
                            Console.WriteLine(c.ToString());
                        }

                        break;

                    default:
                        {
                            Console.WriteLine("Opção Inválida\n Digite uma opção valida");
                        }
                        break;
                }

                Console.ReadKey();
                Console.Clear();


            } while (opcao != 0);
        }
    }
}
