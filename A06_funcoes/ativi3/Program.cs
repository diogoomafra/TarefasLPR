using System;

namespace ativi3
{
    internal class Program
    {
        static string hero1 = " ", personagem1 = " ", personagem2 = " ", personagem3 = " ", personagem4 = " ", personagem5 = " ";
        static string hero2 = " ";
        static string hero3 = " ";
        static string hero4 = " ";
        static string hero5 = " ";


        static string powerhero1 = " ";
        static string powerhero2 = " ";
        static string powerhero3 = " ";
        static string powerhero4 = " ";
        static string powerhero5 = " ";

        static int pointhero1 = 0;
        static int pointhero2 = 0;
        static int pointhero3 = 0;
        static int pointhero4 = 0;
        static int pointhero5 = 0;

        static string eqNome1 = " ", eqNome2 = " ", eqNome3 = " ", eqPoder1 = " ", eqPoder2 = " ", eqPoder3 = " ";
        static int eqPont1, eqPont2, eqPont3;
        static void Main(string[] args)
        {
        
            menuPrincipal();
        
        }
        
        static void cadastrarHeroi(){
            //5 vezes

                Console.WriteLine("Insira o nome, poder e pontuação dos personagens.");

      

                Console.WriteLine("Nome do primeiro herói: ");
                hero1 = Console.ReadLine();    
                Console.WriteLine("Poder do primeiro herói: ");
                powerhero1 = Console.ReadLine();
                Console.WriteLine("Pontuação do primeiro herói: ");
                pointhero1 = int.Parse(Console.ReadLine());


                Console.WriteLine("Nome do segundo herói: ");
                hero2 = Console.ReadLine();
                Console.WriteLine("Poder do segundo herói: ");
                powerhero2 = Console.ReadLine();
                Console.WriteLine("Pontuação do segundo herói: ");
                pointhero2 = int.Parse(Console.ReadLine());


                Console.WriteLine("Nome do terceiro herói: ");
                hero3 = Console.ReadLine();
                Console.WriteLine("Poder do terceiro herói: ");
                powerhero3 = Console.ReadLine();
                Console.WriteLine("Pontuação do terceiro herói: ");
                pointhero3 = int.Parse(Console.ReadLine());


                Console.WriteLine("Nome do quarto herói: ");
                hero4 = Console.ReadLine();
                Console.WriteLine("Poder do quarto herói: ");
                powerhero4 = Console.ReadLine();
                Console.WriteLine("Pontuação do quarto herói: ");
                pointhero4 = int.Parse(Console.ReadLine());

                Console.WriteLine("Nome do quinto herói: ");
                hero5 = Console.ReadLine();
                Console.WriteLine("Poder do quinto herói: ");
                powerhero5 = Console.ReadLine();
                Console.WriteLine("Pontuação do quinto herói: ");
                pointhero5 = int.Parse(Console.ReadLine());


        }//funcao

        static void selecionarEquipe(){
            if (hero1 == " "){

                Console.WriteLine("Primeiramente iremos cadastrar os personagens.");
                cadastrarHeroi();

            }   else{

            Console.WriteLine("Opções para sua equipe: ");
            Console.WriteLine($"1 - Nome: {hero1}, poder: {powerhero1}, pontuação: {pointhero1}.");
            Console.WriteLine($"2 - Nome: {hero2}, poder: {powerhero2}, pontuação: {pointhero2}.");
            Console.WriteLine($"3 - Nome: {hero3}, poder: {powerhero3}, pontuação: {pointhero3}.");
            Console.WriteLine($"4 - Nome: {hero4}, poder: {powerhero4}, pontuação: {pointhero4}.");
            Console.WriteLine($"5 - Nome: {hero5}, poder: {powerhero5}, pontuação: {pointhero5}.");
 

            for (int i = 1 ; i <= 3; i ++){
                
                Console.WriteLine($"Escolha o personagem {i}: ");
                int escolha = int.Parse(Console.ReadLine());
                /*

                Ele mostra para escolhaer o primeiro personagem e a pessoa digita o número que quer deste personagem
                ai a gente vai dar um switch na variável i pra enviar de acordo com a escolha a decisão de personagem e atribuir os nomes
                */
                 switch (i)
            {
                case 1:
                    adicionarHero(escolha, ref eqNome1, ref eqPoder1, ref eqPont1);
                    break;
                case 2:
                    adicionarHero(escolha, ref eqNome2, ref eqPoder2, ref eqPont2);
                    break;
                case 3:
                    adicionarHero(escolha, ref eqNome3, ref eqPoder3, ref eqPont3);
                    break;
            }
        }
        }
            
     }//funcao
        static void adicionarHero(int escolha, ref string heroi, ref string poder, ref int pontos){

                switch (escolha){

                    case 1:
                    
                    heroi = hero1;
                    poder = powerhero1;
                    pontos = pointhero1;

                    break;

                    case 2:
                    
                    heroi = hero2;
                    poder = powerhero2;
                    pontos = pointhero2;

                    break;

                    case 3:
                    
                    heroi = hero3;
                    poder = powerhero3;
                    pontos = pointhero3;

                    break;

                    case 4:
                    
                    heroi = hero4;
                    poder = powerhero4;
                    pontos = pointhero4;

                    break;

                    case 5:
                    
                    heroi = hero5;
                    poder = powerhero5;
                    pontos = pointhero5;

                    break;


                    default:

                    Console.WriteLine("Herói inválido.");
                    break;

                    
                }

        } //funcao
        static int calcularPontuacaoTotal (){
            
            return eqPont1 + eqPont2 + eqPont3;

        } //funcao
        static void exibirEquipe(){
            if (hero1 == " " || eqNome1 == " "){
                
                Console.WriteLine("Primeiramente iremos cadastrar os personagens.");
                cadastrarHeroi();

            }else{

            Console.WriteLine($"Sua equipe: {eqNome1}, {eqNome2}, {eqNome3}.\nCom os poderes de {eqPoder1}, {eqPoder2} e de {eqPoder3}.\nA pontuação total da sua equipe é de {calcularPontuacaoTotal()}");
            //usando o retorno da função como variavel
            }

        } // funcao


        static void menuPrincipal(){
            int escolher = 0;
            do{
               
               
               Console.ForegroundColor = ConsoleColor.DarkRed;
               Console.WriteLine("+=+=+=+=+=+=+=+=+=MARVEL=+=+=+=+=+=+=+=+=+");
               Console.WriteLine("1 - Cadastrar personagens da Márvel\n2 - Selecionar minha equipe\n3 - Exibição da equipe\n4 - Sair");
               Console.WriteLine("=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+"); 
               Console.ResetColor();

               Console.Write("Escolha: ");
               escolher = int.Parse(Console.ReadLine());

                switch (escolher){

                    case 1:
                    
                    cadastrarHeroi();
                    break;

                    case 2: 
                    
                    selecionarEquipe();
                    break;
                    
                    case 3:

                    exibirEquipe();
                    break;

                    case 4:

                    Console.WriteLine("Saindo :)");
                    break;

                    default:
                    Console.WriteLine("Valor inválido!"); 
                    break;
                }
            
            }while(escolher != 4);
            
        }   
    
    }
}
/* 
Crie uma função chamada cadastrarHeroi que permita ao usuário
inserir o nome, poder e pontuação de um herói da Marvel. A função deve
solicitar essas informações ao usuário e armazená-las em variáveis. Não é
necessário armazenar os heróis em uma lista ou vetor. O programa deve
permitir o cadastro de até 5 heróis.
*/

/* 
Crie uma função chamada selecionarEquipe que permita ao usuário
selecionar heróis para formar sua equipe. A função deve exibir os heróis
cadastrados e permitir que o usuário selecione quais heróis deseja incluir
em sua equipe. O usuário deve ser capaz de selecionar três heróis para
sua equipe.
*/

/*

Crie uma função chamada calcularPontuacaoTotal que calcule a
pontuação total da equipe com base nos heróis selecionados. A
pontuação total da equipe deve ser a soma das pontuações individuais de
cada herói selecionado


*/

/*
Crie uma função chamada menuPrincipal que exiba um menu com as
opções disponíveis para o usuário (cadastro de heróis, seleção de equipe,
exibição da equipe e sair do programa). O usuário deve poder escolher
uma das opções do menu e o programa deve executar a funcionalidade
correspondente.
*/
