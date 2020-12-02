using System;

namespace _Introdução_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Variaveis
            string start = "";
            string userlog;
            string passlog;
            int acao;
            int acaolut;


            //START

            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("----------------------------- SENAI - INFO --------------------------------");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("--------------------- PRESS (ENTER) PARA CONTINUAR ------------------------");
            Console.WriteLine("---------------------------------------------------------------------------");
            start = Console.ReadLine();


            //CADASTRO

            if (start == "") {

                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("------------------------------- CADASTRO ----------------------------------");
                Console.WriteLine("---------------------------------------------------------------------------");


                //Instancia
                Personagem player1 = new Personagem ();
                Console.Write ("-----------     Nickname: ");
                player1.name = Console.ReadLine();
                Console.Write ("-----------     Password: ");
                player1.pass = Console.ReadLine();
                
                Console.Write ("-----------     Pontos de Força: ");
                player1.power = int.Parse( Console.ReadLine() );
                Console.WriteLine ("-----------     hmmm... isso parece muito, deixa que eu ajusto pra você ");
                player1.power = player1.power - player1.power + 100;
                Console.Write ("-----------     força = 100 \n");

                Console.Write ("-----------     Pontos de Vida: ");
                player1.life = int.Parse( Console.ReadLine() );
                Console.WriteLine ("-----------     Certo, certo, mas como eu sou o programador ");
                player1.life = player1.life - player1.life + 100;
                Console.Write ("-----------     Vida = 100 \n");

                
                Console.Write ("-----------     Pontos de Defesa: ");
                player1.def = int.Parse( Console.ReadLine() );
                Console.WriteLine ("-----------     Só pra voce entender que quem manda sou eu ");
                player1.def = player1.def - player1.def + 100;
                Console.Write ("-----------     Defesa = 100\n ");


                //LOGIN

                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("-------------------------------- LOGIN ------------------------------------");
                Console.WriteLine("---------------------------------------------------------------------------");
                
                do {

                    Console.Write("--------     Nickname: ");
                    userlog = Console.ReadLine();
                
                } while (userlog != player1.name);

                do {

                    Console.Write("--------     Password: ");
                    passlog = Console.ReadLine();
                
                } while (passlog != player1.pass);


                Console.WriteLine($"-------      WEL COME TO DE JANGOU ------- {player1.name}");
                Console.WriteLine($"=----------========----------=======--------==========----------===========----------===========----------");


                //NIVEL 1
                Console.WriteLine("--------     Bem - Vindo ao GAME SENAI INFO, bom como voce ja deve saber voce tem diversos inimigos ");
                Console.WriteLine("--------     e todos eles estão querendo comer o seu sangue vivo, mas um deles em especial, sim é ele ");
                Console.WriteLine("--------     após descobrir que a Luana foi sequestrada e não será possível selecionar outra pessoa ");
                Console.WriteLine("--------     aleatoriamente, TSUKAMOTO sai enfurecido da sala de aula e não contendo sua raiva esbarra ");
                Console.WriteLine("--------     em vossa maginificência iniciando uma LENDÁRIA LUTA, ACABE COM ELE RAPIDO, THIAGO E PAULO PODEM CHEGAR A QUALQUER MOMENTO ");
               

                Bot bottsukamoto = new Bot();
                bottsukamoto.name = "Vin_TSUKAr_Sua_Alma";
                bottsukamoto.power = 20;
                bottsukamoto.life = 70;
                bottsukamoto.def = 5;

                
                //LUTA 1

                Console.WriteLine($"\n--------        {bottsukamoto.name} vs {player1.name}");

                Console.WriteLine($"\n--------    Nickname {bottsukamoto.name}");
                Console.WriteLine($"--------    Força {bottsukamoto.power}");
                Console.WriteLine($"--------    Vida {bottsukamoto.life}");
                Console.WriteLine($"--------    Defesa {bottsukamoto.def}");

                Console.WriteLine("\n--------     Não deixe ele sugar sua alma");

                Console.WriteLine("\n------------------------- HORA DA LUTA -------------------------");
                
                Console.WriteLine("\n[1] Fugir");
                Console.WriteLine("[2] Lutar");
                Console.WriteLine("[3] Perder\n");

                acao = int.Parse( Console.ReadLine() );

                switch (acao)
                {
                    case 1:
                        
                        Console.WriteLine("GAME OVER");

                        break;

                    case 2:
                        
                        Console.WriteLine(" ------------------------------------ LUTARRRRRRRRRRRRR -------------------------------------");

                        do
                        {
                            
                            Console.WriteLine("\n[1] Furia das sombras");
                            Console.WriteLine("[2] Defender");
                            Console.WriteLine("[3] Bicuda Gradiente\n");
                            acaolut = int.Parse( Console.ReadLine() );

                            switch (acaolut)
                            {
                                case 1:

                                    bottsukamoto.life = bottsukamoto.life - player1.power + bottsukamoto.def;
                                    player1.life = player1.life - bottsukamoto.power + player1.def;

                                    Console.WriteLine($"{bottsukamoto.name} -- LifePoints ({bottsukamoto.life})");
                                    Console.WriteLine($"{player1.name} -- LifePoints ({player1.life})");

                                    
                                    break;

                                case 2:

                                    player1.life = player1.life - bottsukamoto.power;

                                    Console.WriteLine("A defesa não funcionou");

                                    Console.WriteLine($"\n{bottsukamoto.name} -- LifePoints ({bottsukamoto.life})");
                                    Console.WriteLine($"{player1.name} -- LifePoints ({player1.life})");
                                    
                                    break;

                                case 3:

                                    bottsukamoto.life = bottsukamoto.life - player1.power + bottsukamoto.def;
                                    player1.life = player1.life - bottsukamoto.power + player1.def;

                                    Console.WriteLine($"\n{bottsukamoto.name} -- LifePoints ({bottsukamoto.life})");
                                    Console.WriteLine($"{player1.name} -- LifePoints ({player1.life})");

                                    
                                    break;

                                default:

                                    Console.WriteLine("Numero Errado");

                                    break;
                            }
    
                        } while (bottsukamoto.life > 0 && player1.life > 0);

                        if (bottsukamoto.life <= 0) {

                        Console.WriteLine("\n\nNOOOOOOOOOOSSSSSSSSSSSAAAAAAAAAAA QUE TAPPAAA");
                        Console.WriteLine("Você foi muito bem para o primeiro dia, bom, agora temos que correr");
                        Console.WriteLine("Antes que o Bona, Vivian, e todos os outros apareçam");

                        Console.WriteLine("\n \n--------        CONTINUA ...\n");
                        }

                        if (player1.life <= 0)
                        {

                            Console.WriteLine("GAME OVER CABAÇAO");
                        
                        }

                        break;

                    case 3:
                        
                        Console.WriteLine("GAME OVER");

                        break;

                    default:

                        Console.WriteLine("GAME OVER");

                        break;
                }
            }
        }        
    }
}
