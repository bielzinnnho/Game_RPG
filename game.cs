using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("\n===========================================");
        Console.WriteLine("        BEM-VINDO A JORNADA ÉPICA!         ");
        Console.WriteLine("===========================================\n");
        
        Console.Write("Digite Seu Nome: ");
        string name = Console.ReadLine() ?? "Herói";

        showClass();

        bool validateNumber = false;
        Character? Hero = null;
        
        while (validateNumber == false)
        {
            Console.Write("\nEscolha (1-6): ");
            if (!int.TryParse(Console.ReadLine(), out int chooseClass)) continue;
            
            if (chooseClass == 1)
            {
                Hero = new Character(name, "Bárbaro", 120, 10, 5);
                validateNumber = true;
                Hero.Inventory.Add(new Item("Poção de Força", "Consumível", 0, 0, "Comum", 3));
                Hero.Inventory.Add(new Item("Poção de Força", "Consumível", 0, 0, "Comum", 3));
            }
            else if (chooseClass == 2)
            {
                Hero = new Character(name, "Arqueira", 100, 8, 10);
                validateNumber = true;
                Hero.Inventory.Add(new Item("Poção de Vida", "Consumível", 0, 0, "Comum", 30));
            }
            else if (chooseClass == 3)
            {
                Hero = new Character(name, "Fada", 130, 7, 5);
                validateNumber = true;
                Hero.Inventory.Add(new Item("Poção de Vida", "Consumível", 0, 0, "Comum", 30));
                Hero.Inventory.Add(new Item("Poção de Vida", "Consumível", 0, 0, "Comum", 30));
            }
            else if (chooseClass == 4)
            {
                Hero = new Character(name, "Mago", 80, 11, 5);
                validateNumber = true;
                Hero.Inventory.Add(new Item("Poção de Vida", "Consumível", 0, 0, "Comum", 30));
                Hero.Inventory.Add(new Item("Poção de Força", "Consumível", 0, 0, "Comum", 3));
            }
            else if (chooseClass == 5)
            {
                Hero = new Character(name, "Elfo", 90, 9, 8);
                validateNumber = true;
                Hero.Inventory.Add(new Item("Poção de Vida", "Consumível", 0, 0, "Comum", 30));
                Hero.Inventory.Add(new Item("Poção de Força", "Consumível", 0, 0, "Comum", 3));
            }
            else if (chooseClass == 6)
            {
                Hero = new Character(name, "Ladino", 100, 7, 15);
                validateNumber = true;
                Hero.Inventory.Add(new Item("Poção de Vida", "Consumível", 0, 0, "Comum", 30));
                Hero.Inventory.Add(new Item("Poção de Força", "Consumível", 0, 0, "Comum", 3));
            }
            else
            {
                Console.WriteLine("\n[!] Número Inválido. Escolha um Número de 1 a 6.");
            }
        }

        Console.Clear();
        MainIntro(Hero!);

        bool inLobby = true;

        while (inLobby == true && Hero!.health > 0)
        {
            Console.Clear();
            ShowLobbyOptions();
            
            if (!int.TryParse(Console.ReadLine(), out int choose)) continue;
            
            if (choose == 1)
            {  
                Console.Clear();
                exploration(Hero);
            }
            else if(choose == 2)
            {
                bool inShop = true;
                while (inShop == true)
                {
                    Console.Clear();
                    Shop(Hero);
                    if (!int.TryParse(Console.ReadLine(), out int choose2)) continue;

                    if (choose2 == 1)
                    {
                        if (Hero.coin >= 10)
                        {
                            Hero.Inventory.Add(new Item("Poção de Vida", "Consumível", 0, 0, "Comum", 30));
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n[+] POÇÃO DE VIDA RECEBIDA!");
                            Console.ResetColor();
                            Hero.coin -= 10;
                        }
                        else
                        {
                            Console.WriteLine("\n[!] Você não tem moedas o suficiente.");
                        }
                        Console.ReadLine();
                    }
                    else if(choose2 == 2)
                    {
                        if (Hero.coin >= 50)
                        {  
                            Hero.Inventory.Add(new Item("Poção de Força", "Consumível", 0, 0, "Comum", 3));
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n[+] POÇÃO DE FORÇA RECEBIDA!");
                            Console.ResetColor();
                            Hero.coin -= 50;
                        }
                        else
                        {
                            Console.WriteLine("\n[!] Você não tem moedas o suficiente.");
                        }
                        Console.ReadLine();
                    }
                    else if(choose2 == 3)
                    {
                        inShop = false;
                    }
                }
            }
            else if(choose == 3)
            {
                Console.Clear();
                MessageGameOver(Hero);
                inLobby = false;
            }
        }
    }

    public static void exploration(Character Hero)
    {
        bool explore = true;
        Random chance = new Random();

        while (explore == true && Hero.health > 0)
        {
            Console.Clear();
            Console.WriteLine("\n==========================================");
            Console.WriteLine("          EXPLORANDO A FLORESTA...        ");
            Console.WriteLine("==========================================");
            System.Threading.Thread.Sleep(1000);

            int chanceRandom = chance.Next(1, 101);
            
            // 60% chance de monstro comum
            if (chanceRandom >= 1 && chanceRandom <= 60)
            {
                int monsterRandom = chance.Next(1, 11);
                Enemy enemy = null!;
                
                if (monsterRandom == 1)
                {  
                    string[] attacks = { "Mordida Rápida", "Garra Dilacerante", "Investida Selvagem", "Frenesi do Alfa" };
                    enemy = new Enemy("Lobo Cinzento", 100, 7, 10, 20, attacks);
                }
                else if (monsterRandom == 2)
                {
                    string[] attacks = { "Corte Enferrujado", "Golpe Sujo", "Arremesso de Bomba", "Facada nas Costas" };
                    enemy = new Enemy("Goblin Saqueador", 80, 5, 8, 10, attacks);
                }
                else if (monsterRandom == 3)
                {
                    string[] attacks = { "Soco Pesado", "Porretada Brutal", "Pisoteio Sísmico", "Esmagamento Titânico" };
                    enemy = new Enemy("Ogro Gigante", 150, 10, 15, 30, attacks);
                }
                else if (monsterRandom == 4)
                {
                    string[] attacks = { "Investida Gelatinosa", "Chicote de Gosma", "Jato Corrosivo", "Explosão Ácida" };
                    enemy = new Enemy("Slime Gosmento", 60, 3, 5, 5, attacks);
                }
                else if (monsterRandom == 5)
                {
                    string[] attacks = { "Orbe Sombrio", "Lança de Gelo", "Raio Necrótico", "Explosão de Almas" };
                    enemy = new Enemy("Esqueleto Feiticeiro", 90, 15, 25, 30, attacks);
                }
                else if (monsterRandom == 6)
                {
                    string[] attacks = { "Picada Venenosa", "Salto Predatório", "Cuspir Teia", "Banquete Aracnídeo" };
                    enemy = new Enemy("Aranha das Sombras", 110, 12, 20, 25, attacks);    
                }
                else if (monsterRandom == 7)
                {
                    string[] attacks = { "Soco Inglês", "Facada Traiçoeira", "Chute Baixo", "Corte de Adaga" };
                    enemy = new Enemy("Bandido da Estrada", 85, 6, 15, 15, attacks);  
                }
                else if (monsterRandom == 8)
                {
                    string[] attacks = { "Focinhada", "Investida com Presas", "Pisoteio", "Carga Brutal" };
                    enemy = new Enemy("Javali Selvagem", 110, 6, 5, 18, attacks);
                }
                else if (monsterRandom == 9)
                {
                    string[] attacks = { "Rasante", "Mordida Vampírica", "Bater de Asas", "Grito Supersônico" };
                    enemy = new Enemy("Morcego Cavernícola", 50, 5, 4, 10, attacks);
                }
                else if (monsterRandom == 10)
                {
                    string[] attacks = { "Patada Pesada", "Mordida Feroz", "Abraço de Urso", "Fúria Selvagem" };
                    enemy = new Enemy("Urso Pardo Furioso", 130, 9, 8, 22, attacks);
                }
                
                Console.Clear();
                Arena(Hero, enemy);
            }
            // 25% chance de acampamento
            else if (chanceRandom >= 61 && chanceRandom <= 85)
            {
                if (Hero.health < Hero.maxHealth)
                {
                    int camping = 20;
                    int lastHealth = Hero.health;
                    Hero.health += camping;
                    
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n==========================================");
                    Console.WriteLine("Você encontrou um acampamento escondido!");
                    Console.WriteLine("==========================================");
                    Console.ResetColor();
                    
                    if (Hero.health > Hero.maxHealth)
                    {
                        Hero.health = Hero.maxHealth;
                    }

                    int recovery = Hero.health - lastHealth;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\n(+) Você descansou e recuperou {recovery} de HP!");
                    Console.ResetColor();
                }
                else if (Hero.health == Hero.maxHealth)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n==========================================");
                    Console.WriteLine("Você encontrou um acampamento escondido!");
                    Console.WriteLine("==========================================");
                    Console.ResetColor();
                    Console.WriteLine("\nVocê já está com a vida cheia, mas tirou um bom cochilo.");
                }
            }
            // 15% chance de Portal Dimensional
            else if (chanceRandom >= 86 && chanceRandom <= 100)
            {
                int portalRandom = chance.Next(1, 1001);

                // PORTAL RANK E (40% de chance)
                if (portalRandom >= 1 && portalRandom <= 400 )
                {
                    if (PortalEncounter("E", "cinza", ConsoleColor.DarkGray))
                    {  
                        string[] banditAtks = { "Soco Inglês", "Facada Traiçoeira", "Chute Baixo", "Corte de Adaga" };
                        string[] slimeAtks = { "Investida Gelatinosa", "Chicote de Gosma", "Jato Corrosivo", "Explosão Ácida" };
                        string[] bossAtks = { "Onda de Gosma", "Salto Esmagador", "Tsunami de Geleia", "Engolfamento Total" };
                        
                        Enemy[] inimigosPortalE = {
                            new Enemy("Slime Gosmento", 60, 3, 5, 5, slimeAtks),
                            new Enemy("Bandido Sorrateiro", 85, 6, 15, 15, banditAtks),
                            new Enemy("Slime Gosmento", 60, 3, 5, 5, slimeAtks),
                            new Enemy("Slime Mutante", 80, 4, 10, 10, slimeAtks),
                            new Enemy("Slime Gigante", 280, 13, 50, 80, bossAtks)
                        };

                        RunPortal(Hero, "E", inimigosPortalE);
                        
                        // Depois do portal, seja fugindo ou vencendo, forçamos a volta pra cidade
                        explore = false;
                        continue; // Pula as perguntas de baixo e volta pro Main Loop
                    }
                    else
                    {
                        explore = false;
                        continue;
                    }
                }
                // Exemplo de PORTAL RANK D (30% de chance)
                else if (portalRandom >= 401 && portalRandom <= 700)
                {
                    if (PortalEncounter("D", "verde", ConsoleColor.DarkGreen))
                    {
                        string[] goblinAtks = { "Corte Enferrujado", "Golpe Sujo", "Arremesso de Bomba", "Facada nas Costas" };
                        string[] bossAtks = { "Porretada Brutal", "Grito de Guerra", "Esmagamento Titânico", "Terremoto" };
                        string[] batAtks = { "Rasante", "Mordida Vampírica", "Bater de Asas", "Grito Supersônico" };
                        
                        Enemy[] inimigosPortalD = {
                            new Enemy("Goblin Saqueador", 80, 5, 8, 10, goblinAtks),
                            new Enemy("Morcego Cavernícola", 50, 5, 4, 10, batAtks),
                            new Enemy("Goblin Saqueador", 80, 5, 8, 10, goblinAtks),
                            new Enemy("Goblin Guerreiro", 100, 6, 13, 15, goblinAtks),
                            new Enemy("Rei Goblin", 300, 15, 100, 180, bossAtks)
                        };

                        RunPortal(Hero, "D", inimigosPortalD);
                        explore = false;
                        continue;
                    }
                    else
                    {
                        explore = false;
                        continue;
                    }
                }
                else if (portalRandom >= 701 && portalRandom <= 850)
                {
                    if (PortalEncounter("C", "amarelo", ConsoleColor.DarkYellow))
                    {
                        string[] boarAtks = { "Focinhada", "Investida com Presas", "Pisoteio", "Carga Brutal" };
                        string[] wolfAtks = { "Mordida Rápida", "Garra Dilacerante", "Investida Selvagem", "Frenesi do Alfa" };
                        string[] bossAtks = { "Mordida Selvagem", "Patada Esmagadora", "Olhar do Alfa", "Carnificina Absoluta" };
                        
                        Enemy[] inimigosPortalC = {
                            new Enemy("Lobo Cinzento", 100, 7, 10, 20, wolfAtks),
                            new Enemy("Javali Selvagem", 110, 6, 5, 18, boarAtks),
                            new Enemy("Lobo Cinzento", 100, 7, 10, 20, wolfAtks),
                            new Enemy("Lobo Preto", 120, 8, 15, 25, wolfAtks),
                            new Enemy("Lobo Branco(Alfa)", 320, 17, 200, 250, bossAtks)
                        };

                        RunPortal(Hero, "C", inimigosPortalC);
                        explore = false;
                        continue;
                    }
                    else
                    {
                        explore = false;
                        continue;
                    }
                }
                else if (portalRandom >= 851 && portalRandom <= 940)
                {
                    if (PortalEncounter("B", "azul", ConsoleColor.DarkBlue))
                    {
                        string[] garguAtks = { "Soco de Pedra", "Mergulho de Concreto", "Grito de Eco", "Terremoto Devastador" };
                        string[] vampAtks = { "Garra Sanguinária", "Corte Fantasma", "Enxame de Morcegos", "Frenesi Escarlate" };
                        string[] magicAtks = { "Orbe Sombrio", "Lança de Gelo", "Raio Necrótico", "Explosão de Almas" };
                        string[] spiderAtks = { "Picada Venenosa", "Salto Predatório", "Cuspir Teia", "Banquete Aracnídeo" };

                        Enemy[] inimigosPortalB = {
                            new Enemy("Esqueleto Feiticeiro", 90, 15, 25, 30, magicAtks),
                            new Enemy("Aranha das Sombras", 110, 12, 20, 25, spiderAtks),
                            new Enemy("Esqueleto Feiticeiro", 90, 15, 25, 30, magicAtks),
                            new Enemy("Gárgula de Obsidiana", 250, 18, 50, 60, garguAtks),
                            new Enemy("Lorde Vampiro", 550, 27, 300, 350, vampAtks)
                        };

                        RunPortal(Hero, "B", inimigosPortalB);
                        explore = false;
                        continue;
                    }
                    else
                    {
                        explore = false;
                        continue;
                    }
                }
                else if (portalRandom >= 941 && portalRandom <= 985)
                {
                    if (PortalEncounter("A", "vermelho", ConsoleColor.DarkRed))
                    {
                        
                        string[] pardoAtks = { "Patada Pesada", "Mordida Feroz", "Abraço de Urso", "Fúria Selvagem" };
                        string[] polarAtks = { "Garra Gélida", "Quebra-Gelo", "Investida da Nevasca", "Rugido de Inverno" };
                        string[] pandaAtks = { "Soco de Bambu", "Impacto Pesado", "Rolamento Destrutivo", "Ira do Guardião" };
                        string[] negroAtks = { "Patada Sombria", "Mordida do Vazio", "Ataque Sorrateiro", "Frenesi Obscuro" };
                        string[] knightAtks = { "Estocada Fria", "Corte Brutal", "Golpe de Escudo", "Dança das Lâminas Mortais" };

                        Enemy[] inimigosPortalA = {

                            new Enemy("Urso Pardo Esmagador", 350, 20, 80, 150, pardoAtks),
                            new Enemy("Urso Polar Gélido", 480, 24, 120, 200, polarAtks),
                            new Enemy("Panda Guardião Ancestral", 600, 28, 180, 280, pandaAtks),
                            new Enemy("Urso Negro do Abismo", 750, 33, 250, 350, negroAtks),
                            new Enemy("Cavaleiro Morto-Vivo", 1000, 42, 800, 1000, knightAtks)
                        };

                        RunPortal(Hero, "A", inimigosPortalA);
                        explore = false;
                        continue;
                    }
                    else
                    {
                        explore = false;
                        continue;
                    }
                }
                else if (portalRandom >= 986 && portalRandom <= 999)
                {
                    if (PortalEncounter("S", "Roxo", ConsoleColor.DarkMagenta))
                    {

                        string[] ogreAtks = { "Soco Pesado", "Porretada Brutal", "Pisoteio Sísmico", "Esmagamento Titânico" };
                        string[] exeAtks = { "Machadada Brutal", "Grito do Abismo", "Fissura Terrestre", "Guilhotina Dimensional" };
                        string[] twoHeadedAtks = { "Golpe Duplo", "Cabeçada Confusa", "Grito Ensurdecedor", "Porretada Cruzada" };
                        string[] bossOgreAtks = { "Tremor Terrestre", "Grito de Guerra", "Porrete de Aço Esmagador", "Ira do Rei Colossal" };
                        string[] dragonAtks = { "Mordida Estilhaçante", "Golpe de Cauda Colossal", "Chuva de Meteoros", "SOPRO DO INFERNO" };

                        Enemy[] inimigosPortalS = {


                            new Enemy("Ogro Gigante Primordial", 800, 30, 300, 500, ogreAtks),
                            new Enemy("Ogro Titã de Duas Cabeças", 1000, 40, 450, 750, twoHeadedAtks),
                            new Enemy("Ogro Executor Abissal", 1400, 48, 600, 1000, exeAtks),
                            new Enemy("Rei Ogro Destruidor de Mundos", 1600, 55, 1000, 1500, bossOgreAtks),
                            new Enemy("Dragão Infernal", 2000, 70, 2000, 3000, dragonAtks)
                        };

                        RunPortal(Hero, "S", inimigosPortalS);
                        explore = false;
                        continue;
                    }
                    else
                    {
                        explore = false;
                        continue;
                    }
                }
                else if (portalRandom == 1000)
                {
                    if (PortalEncounter("SS", "Preto", ConsoleColor.Black))
                    {

                        string[] bossOgreAtks = { "Tremor Terrestre", "Grito de Guerra", "Porrete de Aço Esmagador", "Ira do Rei Colossal" };
                        string[] dragonAtks = { "Mordida Estilhaçante", "Golpe de Cauda Colossal", "Chuva de Meteoros", "SOPRO DO INFERNO" };
                        string[] knightAtks = { "Estocada Fria", "Corte Brutal", "Golpe de Escudo", "Dança das Lâminas Mortais" };
                        string[] vampAtks = { "Garra Sanguinária", "Corte Fantasma", "Enxame de Morcegos", "Frenesi Escarlate" };
                        string[] wolfAtks = { "Mordida Selvagem", "Patada Esmagadora", "Olhar do Alfa", "Carnificina Absoluta" };
                        string[] goblinAtks = { "Porretada Brutal", "Grito de Guerra", "Esmagamento Titânico", "Terremoto" };
                        string[] slimeAtks = { "Onda de Gosma", "Salto Esmagador", "Tsunami de Geleia", "Engolfamento Total" };
                        string[] godAtks = { "Toque do Vazio", "Dilacerar a Realidade", "Olhar da Morte", "APAGAR EXISTÊNCIA" };

                        Enemy[] inimigosPortalSS = {

                            new Enemy("Slime Gigante", 280, 13, 50, 80, slimeAtks),
                            new Enemy("Rei Goblin", 300, 15, 100, 180, goblinAtks),
                            new Enemy("Lobo Branco(Alfa)", 320, 17, 200, 250, wolfAtks),
                            new Enemy("Lorde Vampiro", 550, 27, 300, 350, vampAtks),
                            new Enemy("Cavaleiro Morto-Vivo", 1000, 42, 800, 1000, knightAtks),
                            new Enemy("Rei Ogro Destruidor de Mundos", 1600, 55, 1000, 1500, bossOgreAtks),
                            new Enemy("Dragão Infernal", 2000, 70, 2000, 3000, dragonAtks),
                            new Enemy("Monarca da Destruição", 3000, 100, 5000, 10000, godAtks)
                        };

                        RunPortal(Hero, "SS", inimigosPortalSS);
                        explore = false;
                        continue;
                    }
                    else
                    {
                        explore = false;
                        continue;
                    }
                }
            }
                        
            
            if (Hero.health > 0)
            {
                Console.WriteLine("\n----------------------------------");
                Console.WriteLine("O que deseja fazer agora?");
                Console.WriteLine("1. Continuar Explorando");
                Console.WriteLine("2. Voltar para a Praça Central");
                Console.Write("Escolha: ");
                
                string? choice = Console.ReadLine();
                if (choice == "2")
                {
                    explore = false;
                    Console.WriteLine("\nVocê decide voltar em segurança para a cidade.");
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }
    } 

    // ---- NOVA FUNÇÃO DE ENCONTRO DE PORTAL AQUI ----
    public static bool PortalEncounter(string rank, string colorText, ConsoleColor portalColor)
    {
        Console.Clear();
        Console.ForegroundColor = portalColor; 
        Console.WriteLine("\n[!!!] O CÉU FICA ESCURO. O AR FICA PESADO.");
        System.Threading.Thread.Sleep(1500);
        Console.WriteLine($"UMA FENDA DIMENSIONAL {colorText.ToUpper()} SE ABRE NA SUA FRENTE!");
        System.Threading.Thread.Sleep(1500);
        
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\n=======================================================");
        Console.WriteLine($"          >>> PORTAL RANK {rank} ENCONTRADO <<<             ");
        Console.WriteLine("=======================================================");
        Console.ResetColor();
        
        Console.WriteLine("\nO que você faz?");
        Console.WriteLine("1. Entrar no Portal (Aviso: Várias batalhas seguidas!)");
        Console.WriteLine("2. Fugir e voltar para a cidade");
        
        while (true) 
        {
            Console.Write("\nEscolha: ");
            if (!int.TryParse(Console.ReadLine(), out int choice)) continue;

            if (choice == 1)
            {
                Console.Clear();
                return true; 
            }
            else if (choice == 2)
            {
                Console.WriteLine("\nVocê sentiu um calafrio na espinha, decidiu fugir do portal e voltar para a segurança da vila.");
                Console.ReadLine();
                return false; 
            }
            else
            {
                Console.WriteLine("\n[!] Número Inválido. Escolha o Número 1 ou 2.");
            }
        }
    }

    public static void RunPortal(Character Hero, string rankName, Enemy[] monsters)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\nVocê respira fundo e atravessa o PORTAL RANK {rankName}...");
        Console.ResetColor();
        Console.ReadLine();

        for (int i = 0; i < monsters.Length; i++)
        {
            if (Hero.health <= 0) break; 

            Console.Clear();
            
            if (i == monsters.Length - 1) 
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n=======================================================");
                Console.WriteLine(" [ALERTA] A SALA DO CHEFE FOI ALCANÇADA! O CHÃO TREME!");
                Console.WriteLine("=======================================================");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\n--- SALA {i + 1} DO PORTAL ---");
            }

            Arena(Hero, monsters[i]);
        }

        if (Hero.health > 0)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n=======================================================");
            Console.WriteLine($"    O PORTAL RANK {rankName} FOI FECHADO COM SUCESSO! VITÓRIA!  ");
            Console.WriteLine("=======================================================");
            Console.ResetColor();
            Console.ReadLine();
        }
    }

    public static void showClass()
    {
        Console.WriteLine("\n--- CLASSES DISPONÍVEIS ---");
        Console.WriteLine("1. Bárbaro   (Vida: 120 | Força: 10) | Itens: (2x Poção de Força)                         | (5 Moedas)");
        Console.WriteLine("2. Arqueira  (Vida: 100 | Força: 8)  | Itens: (1x Poção de Vida)                          | (10 Moedas)");
        Console.WriteLine("3. Fada      (Vida: 130 | Força: 7)  | Itens: (2x Poção de Vida)                          | (5 Moedas)");
        Console.WriteLine("4. Mago      (Vida: 80  | Força: 11) | Itens: (1x Poção de Vida, 1x Poção de Força)       | (5 Moedas)");
        Console.WriteLine("5. Elfo      (Vida: 90  | Força: 9)  | Itens: (1x Poção de Vida, 1x Poção de Força)       | (8 Moedas)");
        Console.WriteLine("6. Ladino    (Vida: 100 | Força: 7)  | Itens: (1x Poção de Vida, 1x Poção de Força)       | (15 Moedas)");
        Console.WriteLine("---------------------------");
    }
    
    public static void ShowLobbyOptions()
    {
        Console.WriteLine("\n==========================================");
        Console.WriteLine("             PRAÇA CENTRAL                ");
        Console.WriteLine("==========================================");
        Console.WriteLine(" Onde Você Deseja Ir?");
        Console.WriteLine(" 1. Grande Floresta (Explorar)");
        Console.WriteLine(" 2. Loja da Vila");
        Console.WriteLine(" 3. Desistir da Aventura... (FIM DE JOGO)");
        Console.WriteLine("==========================================");
        Console.Write("Escolha: ");
    }

    public static void ShowOptions()
    {
        Console.WriteLine("\n--- SEU TURNO ---");
        Console.WriteLine("1. Atacar");
        Console.WriteLine("2. Abrir Mochila");
        Console.Write("Escolha: ");    
    }
    
    public static void ShowAttackOptions()
    {
        Console.WriteLine("\n------------------------- SEUS ATAQUES --------------------------");
        Console.WriteLine("| 1. Ataque Rápido   (1-12)  | Dano Baixo, Seguro (Mult: 0.5x)  |"); 
        Console.WriteLine("| 2. Golpe Pesado    (20-51) | Dano Alto          (Mult: 1.5x)  |");  
        Console.WriteLine("| 3. Golpe Certeiro  (15-46) | Dano Fixo, Preciso (Mult: 1.0x)  |");    
        Console.WriteLine("| 4. FÚRIA TOTAL     (10-81) | Dano Massivo       (Mult: 2.5x)  |");
        Console.WriteLine("| 5. Voltar                                                     |");
        Console.WriteLine("-----------------------------------------------------------------");
        Console.Write("Qual Opção Deseja Usar?: ");
    }

    public static void ShowStats(Character c, Enemy e)
    {
        Console.WriteLine("\n=======================================================");
        Console.WriteLine($" {c.name.ToUpper()} (Nível {c.level}) | HP: {c.health}/{c.maxHealth} | XP: {c.xp}/{c.xpToNextLevel}");
        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine($" INIMIGO: {e.name.ToUpper()} | HP: {e.health}/{e.maxHealth}");
        Console.WriteLine("=======================================================");
    }

    public static void MainIntro(Character c)
    {
        Console.WriteLine($"\n=======================================================");
        Console.WriteLine($" O {c.type} chamado {c.name} irá sair em sua primeira aventura.");
        Console.WriteLine($" Força Inicial: {c.power}");
        Console.WriteLine($"\n MÃE: Espere!! Leve isso com você!");
        Console.WriteLine($" * VOCÊ RECEBEU {c.coin} Moedas!");
        Console.WriteLine($" MÃE: Por favor meu filho, se cuide...");
        Console.WriteLine($"=======================================================\n");
        Console.WriteLine("Pressione ENTER para continuar...");
        Console.ReadLine();
    }

    public static void BattleIntro(Enemy e)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\n>>> URGENTE! Um {e.name} apareceu! <<<");
        Console.ResetColor();
        Console.WriteLine("Chegou a hora da BATALHA!");
    }

    public static void MessageGameOver(Character c)
    {
        Console.WriteLine($"\nEntão o {c.name} ficou com medo e resolveu desistir de sua aventura.");
        Console.WriteLine($"Voltou para casa, para os braços de sua mãe.");
        Console.WriteLine($"Os anos se passaram, e sem seguir seu sonho de ser um grande {c.type},");
        Console.WriteLine($"ele viveu uma vida patética e morreu de velhice.\n");
        
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("=====================");
        Console.WriteLine("     FIM DE JOGO     ");
        Console.WriteLine("=====================\n");
        Console.ResetColor();
    }

    public static void Arena(Character Hero, Enemy Monster)
    {
        BattleIntro(Monster);
        Random Given = new Random();

        while (Monster.health > 0 && Hero.health > 0)
        {
            ShowStats(Hero, Monster);

            bool turnPlayerOff = false;
            int userAttack = 0;
            
            while(turnPlayerOff == false)
            {
                ShowOptions();

                if (!int.TryParse(Console.ReadLine(), out int respUser)) continue;
                
                if (respUser == 1) 
                {
                    ShowAttackOptions();
                    if (!int.TryParse(Console.ReadLine(), out int respUserAttack)) continue;
                    
                    if(respUserAttack == 5)
                    {
                        Console.Clear();
                        ShowStats(Hero, Monster); 
                        continue; 
                    }

                    userAttack = Hero.Attack(respUserAttack, Given);
                    
                    if (userAttack == 0)
                    {
                        Console.WriteLine("\n[!] Ataque Inválido.");
                        continue;
                    }
                    else
                    {
                        Console.Clear(); 
                        Monster.ReceiveDamage(userAttack);
                        Console.WriteLine($"\n>>> BOOM! O {Monster.name} sofreu {userAttack} de Dano!");
                        turnPlayerOff = true; 
                    }
                }
                else if (respUser == 2) 
                {
                    bool usedItem = Hero.OpenBag();

                    if (usedItem == true)
                    {
                        Console.Clear(); 
                        turnPlayerOff = true;
                    }
                    else
                    {
                        Console.Clear();
                        ShowStats(Hero, Monster);
                    }
                }
                else
                {
                    Console.WriteLine("\n[!] Opção Inválida.");
                }
            }

            if (Monster.health > 0)
            {
                Console.WriteLine("\n--- Turno do Inimigo ---");
                if (Monster.health <= 15)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"O {Monster.name} está sangrando muito!!");
                    Console.ResetColor();
                }

                int monsterAttack = Monster.Attack(Given);
                
                Hero.ReceiveDamage(monsterAttack);
                Console.WriteLine($"<<< O {Monster.name} te causou {monsterAttack} de Dano! (Sua Vida: {Hero.health})");
                
                Console.WriteLine("\nPressione ENTER para o próximo turno...");
                Console.ReadLine();
                Console.Clear(); 

                if (Hero.health <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"\n================================================");
                    Console.WriteLine($"      VOCÊ FOI MORTO PELO {Monster.name.ToUpper()}!");
                    Console.WriteLine($"================================================\n");
                    Console.ResetColor();
                    Console.ReadLine();
                }
            }
        }

        if (Monster.health <= 0 && Hero.health > 0)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n=========================================");
            Console.WriteLine($" O {Monster.name.ToUpper()} FOI MORTO! VITÓRIA!");
            Console.WriteLine($"=========================================");
            Console.ResetColor();

            Hero.coin += Monster.coin;
            Console.WriteLine($"\n+ Você encontrou {Monster.coin} moedas no corpo do monstro!");
            
            Hero.GainXp(Monster.xpReward);

            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadLine();
        }
    }

    public static void Shop(Character c)
    {
        Console.WriteLine("\n==================================");
        Console.WriteLine("          LOJA DA VILA            ");
        Console.WriteLine("==================================");
        Console.WriteLine("Mercador: Olá viajante, o que você deseja?\n");  
        Console.WriteLine($"Suas Moedas: {c.coin}");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("1. Poção de Vida  (Custo: 10 moedas)");
        Console.WriteLine("2. Poção de Força (Custo: 50 moedas)");
        Console.WriteLine("3. Sair");
        Console.WriteLine("----------------------------------");
        Console.Write("Escolha: ");
    }
}  

public class Entity
{
    public string name;
    public int health;
    public int maxHealth;
    public int power;
    public int coin;
    public int defense = 0;

    public Entity(string name, int health, int power, int coin, int defense)
    {
        this.name = name;
        this.health = health;
        this.maxHealth = health;
        this.power = power;
        this.coin = coin;
        this.defense = defense;
    }
    public void ReceiveDamage(int damage)
    {
        int defenseActive = defense / 2;
        int damageMin = (int)(damage * 0.20);

        if (damageMin < 1) damageMin = 1;

        if (damage <= defenseActive)
        {    
            health -= damageMin;
        }
        else
        {  
            int damageCalc = damage - defenseActive;  

            if (damageCalc < damageMin) damageCalc = damageMin;
            health -= damageCalc;
        }
        
        if (health < 0) health = 0;
    }
}

public class Character : Entity
{
    public string type;
    public int level = 1;
    public int xp = 0;
    public int xpToNextLevel = 50;
    public Item equippedWeapon = null;   // Arma
    public Item equippedHelmet = null;   // Capacete
    public Item equippedChest = null;    // Peitoral
    public Item equippedGauntlet = null; // Manopla
    public Item equippedLegs = null;     // Calça
    public Item equippedBoots = null;    // Bota

    public Character(string name, string type, int health, int power, int coin) : base(name, health, power, coin, 0)
    {
        this.type = type;
    }

    public void GainXp(int amount)
    {
        xp += amount;
        Console.WriteLine($"+ Você ganhou {amount} de XP!");
        while (xp >= xpToNextLevel)
        {
            LevelUp();
        }
    }

    public void LevelUp()
    {
        xp -= xpToNextLevel;
        level++;
        xpToNextLevel += 50;

        maxHealth += 10;
        health = maxHealth;
        power += 2;

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\n===================================");
        Console.WriteLine($" 🌟 LEVEL UP! Você alcançou o Nível {level}! 🌟");
        Console.WriteLine($" -> Vida Máxima aumentada para {maxHealth}!");
        Console.WriteLine($" -> Força aumentada para {power}!");
        Console.WriteLine($" -> Vida totalmente restaurada!");
        Console.WriteLine($"===================================");
        Console.ResetColor();
    }
    
    public int Attack(int option, Random Given)
    {
        int finalDamage = 0;

        if (option == 1) finalDamage = (int)(power * 0.5) + Given.Next(1, 12);
        else if (option == 2) finalDamage = (int)(power * 1.5) + Given.Next(20, 51);
        else if (option == 3) finalDamage = power + Given.Next(15, 46);
        else if (option == 4) finalDamage = (int)(power * 2.5) + Given.Next(10, 81);
        
        return finalDamage;
    }

    public List<Item> Inventory = new List<Item>();

    public bool OpenBag()
    {
        Console.WriteLine("\n============= MOCHILA =============");
        if (Inventory.Count == 0)
        {
            Console.WriteLine(" (Vazia)");
            Console.WriteLine("===================================");
            Console.ReadLine();
            return false;
        }

        var groupedItems = Inventory.GroupBy(item => item.name).ToList();
        int option = 1;

        foreach (var group in groupedItems)
        {
            Console.WriteLine($" {option}. {group.Key} (x{group.Count()})");
            option++;
        }

        int optionClose = option;
        Console.WriteLine($" {optionClose}. Fechar");
        Console.WriteLine("===================================");
        Console.Write("Escolher item: ");

        if (int.TryParse(Console.ReadLine(), out int choose))
        {
            if (choose == optionClose) return false;

            int index = choose - 1;

            if (index >= 0 && index < groupedItems.Count)
            {
                string chosenItem = groupedItems[index].Key;

                if (chosenItem == "Poção de Vida")
                {
                    Heal();
                    return true;
                }    
                else if(chosenItem == "Poção de Força")
                {
                    PowerUp();
                    return true;
                }
                else
                {
                    
                     Item misteryItem = Inventory.Find(i => i.name == chosenItem);
                    Console.WriteLine($"\nVocê usou {chosenItem}, mas nada aconteceu.");
                    Inventory.Remove(misteryItem);
                    Console.ReadLine();
                    return true;
                }
            }
        }  
        return false;
    }

    public void Heal()
    {  
        if (health < maxHealth)
        {

            Item potionFound = Inventory.Find(p => p.name == "Poção de Vida");
            if (potionFound != null)
            {
                int lifePotion = potionFound.effect;
                int lastHealth = health;
                health += lifePotion;

                if (health > maxHealth) health = maxHealth;  

                int recovery = health - lastHealth;

                Console.ForegroundColor = ConsoleColor.Green;
                Inventory.Remove(potionFound);
                Console.WriteLine($"\n(+) Você bebeu uma Poção de Vida e recuperou {recovery} de HP!");
                Console.ResetColor();
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n[!] Você não tem Poção de Vida");
                Console.ReadLine();
            }
        }
        else
        {
            Console.WriteLine("\n[!] Sua vida já está cheia.");
            Console.ReadLine();
        }
    }
    
    public void PowerUp()
    {
        Item potionFound = Inventory.Find(p => p.name == "Poção de Força");
        if (potionFound != null)
        {
            int strengthPotion = potionFound.effect;
            power += strengthPotion;
            
            Console.ForegroundColor = ConsoleColor.Green;
            Inventory.Remove(potionFound);
            Console.WriteLine($"\n(💪) Você bebeu uma Poção de Força, e aumentou {strengthPotion} pontos de Força! (Atual: {power})");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}

public class Item
{
    public string name;
    public string type;
    public int bonusPower;
    public int bonusDefense;
    public string rarity;
    public int effect;
    

    public Item(string name, string type, int bonusPower, int bonusDefense, string rarity, int effect)
    {
        this.name = name;
        this.type = type;
        this.bonusPower = bonusPower;
        this.bonusDefense = bonusDefense;
        this.rarity = rarity;
        this.effect = effect;
    }
}

public class Enemy : Entity
{      
    public int xpReward;
    public string[] attacks;

    public Enemy(string name, int health, int power, int coin, int xpReward, string[] attacks) : base(name, health, power, coin, 0)
    {
        this.xpReward = xpReward;
        this.attacks = attacks;
    }

    public int Attack(Random Given)
    {
        int chooseMonster = Given.Next(0, 4);
        int finalDamage = 0;
        
        if (chooseMonster == 0)
        {
            Console.WriteLine($"\n! O {name} usou {attacks[0]}!");
            finalDamage = power + Given.Next(1, 12);
        }
        else if (chooseMonster == 1)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n! O {name} usou {attacks[1]}!");
            Console.ResetColor();
            finalDamage = (int)(power * 2.0) + Given.Next(25, 56);
        }
        else if (chooseMonster == 2)
        {
            Console.WriteLine($"\n! O {name} usou {attacks[2]}!");
            finalDamage = power + Given.Next(15, 46);
        }
        else if (chooseMonster == 3)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n!!! O {name} usou {attacks[3]} !!!");
            Console.ResetColor();
            finalDamage = (int)(power * 3.0) + Given.Next(10, 81);
        }
        
        return finalDamage;
    }
}