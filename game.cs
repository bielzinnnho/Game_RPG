using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\n===========================================");
        Console.WriteLine("        BEM-VINDO A JORNADA ÉPICA!         ");
        Console.WriteLine("===========================================\n");
        Console.ResetColor();
        Console.ReadLine();
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
                Hero.equipItem(new Item("Espada de Madeira", "Arma", 5, 0, "Comum", 0));
                Hero.equipItem(new Item("Chapéu Couro batido", "Capacete", 0, 1, "Comum", 0));
                Hero.equipItem(new Item("Luvas de Couro batido", "Manopla", 0, 1, "Comum", 0));
                Hero.equipItem(new Item("Peitoral de Couro batido", "Peitoral", 0, 1, "Comum", 0));
                Hero.equipItem(new Item("Calça de Couro batido", "Calça", 0, 1, "Comum", 0));
                Hero.equipItem(new Item("Botas de Couro batido", "Botas", 0, 1, "Comum", 0));
                Hero.Inventory.Add(new Item("Poção de Vida", "Consumível", 0, 0, "Comum", 30));
                Hero.Inventory.Add(new Item("Poção de Energia", "Consumível", 0, 0, "Comum", 40));
                validateNumber = true;

            }
            else if (chooseClass == 2)
            {
                Hero = new Character(name, "Arqueira", 100, 8, 20);
                Hero.equipItem(new Item("Arco de Madeira", "Arma", 5, 0, "Comum", 0));
                Hero.equipItem(new Item("Chapéu Couro batido", "Capacete", 0, 1, "Comum", 0));
                Hero.equipItem(new Item("Luvas de Couro batido", "Manopla", 0, 1, "Comum", 0));
                Hero.equipItem(new Item("Peitoral de Couro batido", "Peitoral", 0, 1, "Comum", 0));
                Hero.equipItem(new Item("Calça de Couro batido", "Calça", 0, 1, "Comum", 0));
                Hero.equipItem(new Item("Botas de Couro batido", "Botas", 0, 1, "Comum", 0));
                Hero.Inventory.Add(new Item("Poção de Vida", "Consumível", 0, 0, "Comum", 30));
                Hero.Inventory.Add(new Item("Poção de Vida", "Consumível", 0, 0, "Comum", 30));
                validateNumber = true;
            }
            else if (chooseClass == 3)
            {
                Hero = new Character(name, "Fada", 90, 9, 15);
                Hero.equipItem(new Item("Varinha de Aprendiz", "Arma", 5, 0, "Comum", 0));
                Hero.equipItem(new Item("Chapéu Couro batido", "Capacete", 0, 1, "Comum", 0));
                Hero.equipItem(new Item("Luvas de Couro batido", "Manopla", 0, 1, "Comum", 0));
                Hero.equipItem(new Item("Peitoral de Pano", "Peitoral", 0, 1, "Comum", 0));
                Hero.equipItem(new Item("Calça de Pano", "Calça", 0, 1, "Comum", 0));
                Hero.equipItem(new Item("Botas de Couro batido", "Botas", 0, 1, "Comum", 0));
                Hero.Inventory.Add(new Item("Poção de Vida", "Consumível", 0, 0, "Comum", 30));
                Hero.Inventory.Add(new Item("Poção de Vida", "Consumível", 0, 0, "Comum", 30));
                Hero.Inventory.Add(new Item("Poção de Vida", "Consumível", 0, 0, "Comum", 30));
                validateNumber = true;
            }
            else if (chooseClass == 4)
            {
                Hero = new Character(name, "Mago", 80, 11, 10);
                Hero.equipItem(new Item("Cajado de Madeira", "Arma", 5, 0, "Comum", 0));
                Hero.equipItem(new Item("Capuz de Couro batido", "Capacete", 0, 1, "Comum", 0));
                Hero.equipItem(new Item("Luvas de Couro batido", "Manopla", 0, 1, "Comum", 0));
                Hero.equipItem(new Item("Manto de Couro batido", "Peitoral", 0, 1, "Comum", 0));
                Hero.equipItem(new Item("Calça de Couro batido", "Calça", 0, 1, "Comum", 0));
                Hero.equipItem(new Item("Botas de Couro batido", "Botas", 0, 1, "Comum", 0));
                Hero.Inventory.Add(new Item("Poção de Vida", "Consumível", 0, 0, "Comum", 30));
                Hero.Inventory.Add(new Item("Poção de Energia", "Consumível", 0, 0, "Comum", 40));
                validateNumber = true;
            }
            else if (chooseClass == 5)
            {
                Hero = new Character(name, "Elfo", 90, 9, 10);
                Hero.equipItem(new Item("Lança de Madeira", "Arma", 5, 0, "Comum", 0));
                Hero.equipItem(new Item("Chapéu Couro batido", "Capacete", 0, 1, "Comum", 0));
                Hero.equipItem(new Item("Luvas de Couro batido", "Manopla", 0, 1, "Comum", 0));
                Hero.equipItem(new Item("Peitoral de Couro batido", "Peitoral", 0, 1, "Comum", 0));
                Hero.equipItem(new Item("Calça de Couro batido", "Calça", 0, 1, "Comum", 0));
                Hero.equipItem(new Item("Botas de Couro batido", "Botas", 0, 1, "Comum", 0));
                Hero.Inventory.Add(new Item("Poção de Vida", "Consumível", 0, 0, "Comum", 30));
                Hero.Inventory.Add(new Item("Poção de Energia", "Consumível", 0, 0, "Comum", 40));
                validateNumber = true;
            }
            else if (chooseClass == 6)
            {
                Hero = new Character(name, "Ladino", 85, 12, 40);
                Hero.equipItem(new Item("Faca Curta", "Arma", 5, 0, "Comum", 0));
                Hero.equipItem(new Item("Capuz de pano", "Capacete", 0, 1, "Comum", 0));
                Hero.equipItem(new Item("Luvas de Couro batido", "Manopla", 0, 1, "Comum", 0));
                Hero.equipItem(new Item("Manto de Couro batido", "Peitoral", 0, 1, "Comum", 0));
                Hero.equipItem(new Item("Calça de Couro batido", "Calça", 0, 1, "Comum", 0));
                Hero.equipItem(new Item("Botas de Couro batido", "Botas", 0, 1, "Comum", 0));
                Hero.Inventory.Add(new Item("Poção de Vida", "Consumível", 0, 0, "Comum", 30));
                validateNumber = true;
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
                        if (Hero.coin >= 25)
                        {  
                            Hero.Inventory.Add(new Item("Poção de Energia", "Consumível", 0, 0, "Comum", 40));
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n[+] POÇÃO DE ENERGIA RECEBIDA!");
                            Console.ResetColor();
                            Hero.coin -= 25;
                        }
                        else
                        {
                            Console.WriteLine("\n[!] Você não tem moedas o suficiente.");
                        }
                        Console.ReadLine();
                    }
                    else if(choose2 == 3)
                    {
                        if (Hero.coin >= 200)
                        {  
                            Hero.Inventory.Add(new Item("Poção de Força", "Consumível", 0, 0, "Comum", 3));
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n[+] POÇÃO DE FORÇA RECEBIDA!");
                            Console.ResetColor();
                            Hero.coin -= 200;
                        }
                        else
                        {
                            Console.WriteLine("\n[!] Você não tem moedas o suficiente.");
                        }
                        Console.ReadLine();
                    }
                    else if(choose2 == 4)
                    {
                        inShop = false;
                    }
                }
            }
            else if(choose == 3)
            {
                Console.Clear();
                ShowCharacterStatus(Hero);
                Console.ReadLine();
            }
            else if(choose == 4)
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
                    enemy = new Enemy("Lobo Cinzento", 100, 7, 10, 20, attacks, 0.08);
                }
                else if (monsterRandom == 2)
                {
                    string[] attacks = { "Corte Enferrujado", "Golpe Sujo", "Arremesso de Bomba", "Facada nas Costas" };
                    enemy = new Enemy("Goblin Saqueador", 80, 5, 8, 10, attacks, 0.08);
                }
                else if (monsterRandom == 3)
                {
                    string[] attacks = { "Soco Pesado", "Porretada Brutal", "Pisoteio Sísmico", "Esmagamento Titânico" };
                    enemy = new Enemy("Ogro Gigante", 150, 10, 15, 30, attacks, 0.08);
                }
                else if (monsterRandom == 4)
                {
                    string[] attacks = { "Investida Gelatinosa", "Chicote de Gosma", "Jato Corrosivo", "Explosão Ácida" };
                    enemy = new Enemy("Slime Gosmento", 60, 3, 5, 5, attacks, 0.08);
                }
                else if (monsterRandom == 5)
                {
                    string[] attacks = { "Orbe Sombrio", "Lança de Gelo", "Raio Necrótico", "Explosão de Almas" };
                    enemy = new Enemy("Esqueleto Feiticeiro", 90, 15, 25, 30, attacks, 0.08);
                }
                else if (monsterRandom == 6)
                {
                    string[] attacks = { "Picada Venenosa", "Salto Predatório", "Cuspir Teia", "Banquete Aracnídeo" };
                    enemy = new Enemy("Aranha das Sombras", 110, 12, 20, 25, attacks, 0.08);    
                }
                else if (monsterRandom == 7)
                {
                    string[] attacks = { "Soco Inglês", "Facada Traiçoeira", "Chute Baixo", "Corte de Adaga" };
                    enemy = new Enemy("Bandido da Estrada", 85, 6, 15, 15, attacks, 0.08);  
                }
                else if (monsterRandom == 8)
                {
                    string[] attacks = { "Focinhada", "Investida com Presas", "Pisoteio", "Carga Brutal" };
                    enemy = new Enemy("Javali Selvagem", 110, 6, 5, 18, attacks, 0.08);
                }
                else if (monsterRandom == 9)
                {
                    string[] attacks = { "Rasante", "Mordida Vampírica", "Bater de Asas", "Grito Supersônico" };
                    enemy = new Enemy("Morcego Cavernícola", 50, 5, 4, 10, attacks, 0.08);
                }
                else if (monsterRandom == 10)
                {
                    string[] attacks = { "Patada Pesada", "Mordida Feroz", "Abraço de Urso", "Fúria Selvagem" };
                    enemy = new Enemy("Urso Pardo Furioso", 130, 9, 8, 22, attacks, 0.08);
                }
                
                Console.Clear();
                Arena(Hero, enemy);
            }
            // 25% chance de acampamento
            else if (chanceRandom >= 61 && chanceRandom <= 85)
            {
                if (Hero.health < Hero.maxHealth && Hero.stamina < Hero.maxStamina)
                {
                    int campingHeal = 20;
                    int campingStamina = 20;
                    int lastHealth = Hero.health;
                    Hero.health += campingHeal;
                    int lastStamina = Hero.stamina;
                    Hero.stamina += campingStamina;
                    
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n==========================================");
                    Console.WriteLine("Você encontrou um acampamento escondido!");
                    Console.WriteLine("==========================================");
                    Console.ResetColor();
                    
                    if (Hero.health > Hero.maxHealth)
                    {
                        Hero.health = Hero.maxHealth;
                    }

                    if (Hero.stamina > Hero.maxStamina)
                    {
                        Hero.stamina = Hero.maxStamina;
                    }

                    int recoveryHeal = Hero.health - lastHealth;
                    int recoveryStamina = Hero.stamina - lastStamina;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\n(+) Você descansou e recuperou {recoveryHeal} de HP e {recoveryStamina} de Energia!");
                    Console.ResetColor();
                }
                else if (Hero.stamina < Hero.maxStamina)
                {
                    int campingStamina = 20;
                    int lastStamina = Hero.stamina;
                    Hero.stamina += campingStamina;
                    
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n==========================================");
                    Console.WriteLine("Você encontrou um acampamento escondido!");
                    Console.WriteLine("==========================================");
                    Console.ResetColor();

                    if (Hero.stamina > Hero.maxStamina)
                    {
                        Hero.stamina = Hero.maxStamina;
                    }

                    int recoveryStamina = Hero.stamina - lastStamina;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\n(+) Você descansou e recuperou {recoveryStamina} de Energia!");
                    Console.ResetColor();
                }
                else if (Hero.health < Hero.maxHealth)
                {
                    int campingHeal = 20;
                    int lastHealth = Hero.health;
                    Hero.health += campingHeal;
                    
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n==========================================");
                    Console.WriteLine("Você encontrou um acampamento escondido!");
                    Console.WriteLine("==========================================");
                    Console.ResetColor();
                    
                    if (Hero.health > Hero.maxHealth)
                    {
                        Hero.health = Hero.maxHealth;
                    }

                    int recoveryHeal = Hero.health - lastHealth;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\n(+) Você descansou e recuperou {recoveryHeal} de HP!");
                    Console.ResetColor();
                }
                else if (Hero.health == Hero.maxHealth && Hero.stamina == Hero.maxStamina)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n==========================================");
                    Console.WriteLine("Você encontrou um acampamento escondido!");
                    Console.WriteLine("==========================================");
                    Console.ResetColor();
                    Console.WriteLine("\nVocê já está com a vida e a energia cheia, mas tirou um bom cochilo.");
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
                            new Enemy("Slime Gosmento", 60, 3, 5, 5, slimeAtks, 0.4),
                            new Enemy("Slime Venenoso", 85, 6, 15, 15, slimeAtks, 0.4),
                            new Enemy("Slime Gosmento", 60, 3, 5, 5, slimeAtks, 0.4),
                            new Enemy("Slime Mutante", 80, 4, 10, 10, slimeAtks, 0.4),
                            new Enemy("Slime Gigante", 280, 13, 50, 80, bossAtks, 0.4)
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
                        string[] generalAtks = { "Lâmina Serrilhada", "Chuva de Flechas Negras", "Ordem de Massacre", "EXECUÇÃO SANGRENTA" };

                        Enemy[] inimigosPortalD = {
                            new Enemy("Goblin Saqueador", 80, 5, 8, 10, goblinAtks, 0.4),
                            new Enemy("General Goblin", 95, 7, 10, 15, generalAtks, 0.4),
                            new Enemy("Goblin Saqueador", 80, 5, 8, 10, goblinAtks, 0.4),
                            new Enemy("Goblin Guerreiro", 100, 6, 13, 15, goblinAtks, 0.4),
                            new Enemy("Rei Goblin", 300, 15, 100, 180, bossAtks, 0.4)
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
                        string[] shadowWolfAtks = { "Mordida na Jugular", "Bote das Sombras", "Garras do Eclipse", "ESTRANGULAR" };  
                        string[] wolfAtks = { "Mordida Rápida", "Garra Dilacerante", "Investida Selvagem", "FESTIVAL DA CARNIFICINA" };
                        string[] bossAtks = { "Mordida Selvagem", "Patada Esmagadora", "Eclipse Sangrento", "Carnificina Absoluta" };
                        
                        Enemy[] inimigosPortalC = {
                            new Enemy("Lobo Cinzento", 100, 7, 10, 20, wolfAtks, 0.4),
                            new Enemy("Lobo Cinzento", 100, 7, 10, 20, wolfAtks, 0.4),
                            new Enemy("Lobo das Sombras", 115, 8, 8, 20, shadowWolfAtks, 0.4),
                            new Enemy("Lobo Preto", 120, 8, 15, 25, wolfAtks, 0.4),
                            new Enemy("Lobo Branco(Alfa)", 320, 17, 200, 250, bossAtks, 0.4)
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
                            new Enemy("Esqueleto Feiticeiro", 90, 15, 25, 30, magicAtks, 0.4),
                            new Enemy("Aranha das Sombras", 110, 12, 20, 25, spiderAtks, 0.4),
                            new Enemy("Esqueleto Feiticeiro", 90, 15, 25, 30, magicAtks, 0.4),
                            new Enemy("Gárgula de Obsidiana", 250, 18, 50, 60, garguAtks, 0.4),
                            new Enemy("Lorde Vampiro", 550, 27, 300, 350, vampAtks, 0.4)
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
                        string[] bossAtks = { "Golpe Selvagem", "Corte Brutal", "Frenesi Sanguinário", "ESMAGAMENTO SÍSMICO" };

                        Enemy[] inimigosPortalA = {

                            new Enemy("Urso Pardo Esmagador", 350, 20, 80, 150, pardoAtks, 0.1),
                            new Enemy("Urso Polar Gélido", 480, 24, 120, 200, polarAtks, 0.1),
                            new Enemy("Panda Guardião Ancestral", 600, 28, 180, 280, pandaAtks, 0.1),
                            new Enemy("Urso Negro do Abismo", 750, 33, 250, 350, negroAtks, 0.1),
                            new Enemy("Urso Gigante Devorador", 1000, 42, 800, 1000, bossAtks, 0.1)
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


                            new Enemy("Ogro Gigante Primordial", 800, 30, 300, 500, ogreAtks, 0.1),
                            new Enemy("Ogro Titã de Duas Cabeças", 1000, 40, 450, 750, twoHeadedAtks, 0.1),
                            new Enemy("Ogro Executor Abissal", 1400, 48, 600, 1000, exeAtks, 0.1),
                            new Enemy("Rei Ogro Destruidor de Mundos", 1600, 55, 1000, 1500, bossOgreAtks, 0.1),
                            new Enemy("Deus Ogro das Cinzas", 2000, 70, 2000, 3000, dragonAtks, 0.1)
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
                        string[] bossOgreAtks = { "Golpe Vulcânico", "Chuva de Brasas", "Terremoto Carbonizado", "CREMAÇÃO DIVINA" };
                        string[] dragonAtks = { "Mordida Estilhaçante", "Golpe de Cauda Colossal", "Chuva de Meteoros", "SOPRO DO INFERNO" };
                        string[] knightAtks = { "Estocada Fria", "Corte Brutal", "Golpe de Escudo", "Dança das Lâminas Mortais" };
                        string[] vampAtks = { "Garra Sanguinária", "Corte Fantasma", "Enxame de Morcegos", "Frenesi Escarlate" };
                        string[] wolfAtks = { "Mordida Selvagem", "Patada Esmagadora", "Olhar do Alfa", "Carnificina Absoluta" };
                        string[] goblinAtks = { "Porretada Brutal", "Grito de Guerra", "Esmagamento Titânico", "Terremoto" };
                        string[] bossBearAtks = { "Golpe Selvagem", "Corte Brutal", "Frenesi Sanguinário", "ESMAGAMENTO SÍSMICO" };
                        string[] slimeAtks = { "Onda de Gosma", "Salto Esmagador", "Tsunami de Geleia", "Engolfamento Total" };
                        string[] godAtks = { "Toque do Vazio", "Dilacerar a Realidade", "Olhar da Morte", "APAGAR EXISTÊNCIA" };

                        Enemy[] inimigosPortalSS = {

                            new Enemy("Slime Gigante", 280, 13, 50, 80, slimeAtks, 0.1),
                            new Enemy("Rei Goblin", 300, 15, 100, 180, goblinAtks, 0.1),
                            new Enemy("Lobo Branco(Alfa)", 320, 17, 200, 250, wolfAtks, 0.1),
                            new Enemy("Lorde Vampiro", 550, 27, 300, 350, vampAtks, 0.1),
                            new Enemy("Cavaleiro Morto-Vivo", 800, 32, 500, 700, knightAtks, 0.1),
                            new Enemy("Urso Gigante Devorador", 1000, 42, 800, 1000, bossBearAtks, 0.1),
                            new Enemy("Deus Ogro das Cinzas", 2000, 70, 2000, 3000, bossOgreAtks, 0.1),
                            new Enemy("Dragão Infernal", 2500, 80, 3000, 4000, dragonAtks, 0.1),
                            new Enemy("Monarca da Destruição", 3000, 100, 5000, 10000, godAtks, 0.1)
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
        Console.WriteLine("1. Bárbaro   (Vida: 120 | Força: 10) | Itens: (1x Poção de Vida, 1x Poção de Energia)     | (5 Moedas)");
        Console.WriteLine("2. Arqueira  (Vida: 100 | Força: 8)  | Itens: (2x Poção de Vida)                          | (20 Moedas)");
        Console.WriteLine("3. Fada      (Vida: 90  | Força: 9)  | Itens: (3x Poção de Vida)                          | (15 Moedas)");
        Console.WriteLine("4. Mago      (Vida: 80  | Força: 11) | Itens: (1x Poção de Vida, 1x Poção de Energia)     | (10 Moedas)");
        Console.WriteLine("5. Elfo      (Vida: 90  | Força: 9)  | Itens: (1x Poção de Vida, 1x Poção de Energia)     | (10 Moedas)");
        Console.WriteLine("6. Ladino    (Vida: 85  | Força: 12) | Itens: (1x Poção de Vida)                          | (40 Moedas)");
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
        Console.WriteLine(" 3. Ver Status do Herói");
        Console.WriteLine(" 4. Desistir da Aventura... (FIM DE JOGO)");
        Console.WriteLine("==========================================");
        Console.Write("Escolha: ");
    }

    public static void ShowOptions()
    {
        Console.WriteLine("\n--- SEU TURNO ---");
        Console.WriteLine("1. Atacar");
        Console.WriteLine("2. Abrir Mochila");
        Console.WriteLine("3. Descansar(Recupera 25 de energia)");
        Console.Write("Escolha: ");    
    }
    
    public static void ShowAttackOptions(Character c)
    {
        Console.WriteLine("\n------------------------- SEUS ATAQUES --------------------------");
        // O ,-22 serve para alinhar o texto na tela como uma tabela
        Console.WriteLine($"| 1. {c.attackNames[0],-22} | Dano Leve    | Custo: 0  STAMINA |"); 
        Console.WriteLine($"| 2. {c.attackNames[1],-22} | Dano Médio   | Custo: 10 STAMINA |");  
        Console.WriteLine($"| 3. {c.attackNames[2],-22} | Dano Alto    | Custo: 20 STAMINA |");    
        Console.WriteLine($"| 4. {c.attackNames[3],-22} | Dano SUPREMO | Custo: 40 STAMINA |");
        Console.WriteLine("| 5. Voltar                                                    |");
        Console.WriteLine("-----------------------------------------------------------------");
        Console.Write("Qual Opção Deseja Usar?: ");
    }

   public static void ShowStats(Character c, Enemy e)
    {
        Console.WriteLine("\n=======================================================");
        
        // Perfumaria: Se a vida do herói estiver em 25% ou menos, a linha fica vermelha!
        if (c.health <= (c.maxHealth * 0.25))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($" [PERIGO] ");
        }

        Console.WriteLine($" {c.name.ToUpper()} (Nível {c.level}) | HP: {c.health}/{c.maxHealth} | STAMINA: {c.stamina}/{c.maxStamina} | XP: {c.xp}/{c.xpToNextLevel}");
        Console.ResetColor();

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

    public static void ShowCharacterStatus(Character c)
    {
        string weaponName = (c.equippedWeapon != null) ? c.equippedWeapon.name : "Mãos Vazias";
        string helmetName = (c.equippedHelmet != null) ? c.equippedHelmet.name : "Vazio";
        string gauntletName = (c.equippedGauntlet != null) ? c.equippedGauntlet.name : "Vazio";
        string chestName = (c.equippedChest != null) ? c.equippedChest.name : "Vazio";
        string legsName = (c.equippedLegs != null) ? c.equippedLegs.name : "Vazio";
        string bootsName = (c.equippedBoots != null) ? c.equippedBoots.name : "Vazio";

        Console.WriteLine($"=======================================");
        Console.WriteLine($"          FICHA DO PERSONAGEM        ");
        Console.WriteLine($"=======================================");
        Console.WriteLine($" Nome: {c.name}             Classe: {c.type}");
        Console.WriteLine($" Nível: {c.level}                XP: {c.xp}/{c.xpToNextLevel}");
        Console.WriteLine($" Vida: {c.health}/{c.maxHealth}         Energia: {c.stamina}/{c.maxStamina}");
        Console.WriteLine($" Moedas: {c.coin}");
        Console.WriteLine($"---------------------------------------");
        Console.WriteLine($" [ STATUS TOTAIS ]");
        Console.WriteLine($" Força Total: {c.power}     Defesa Total: {c.defense}");
        Console.WriteLine($"---------------------------------------");
        Console.WriteLine($" [ EQUIPAMENTOS ]");
        Console.WriteLine($" Arma: {weaponName}");
        Console.WriteLine($" Cabeça: {helmetName}");
        Console.WriteLine($" Peito: {chestName}");
        Console.WriteLine($" Mãos: {gauntletName}");
        Console.WriteLine($" Pernas: {legsName}");
        Console.WriteLine($" Pés: {bootsName}");
        Console.WriteLine($"=======================================");
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

        Monster.ScaleStats(Hero.level);

        Random Given = new Random();

        while (Monster.health > 0 && Hero.health > 0)
        {
            ShowStats(Hero, Monster);

            if (Hero.stamina > Hero.maxStamina)
            {
                Hero.stamina = Hero.maxStamina;
            }

            bool turnPlayerOff = false;
            int userAttack = 0;
            
            while(turnPlayerOff == false)
            {
                ShowOptions();

                if (!int.TryParse(Console.ReadLine(), out int respUser)) continue;
                
                if (respUser == 1) 
                {
                    ShowAttackOptions(Hero);
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
                    else if (userAttack == -1){
                        continue;
                    }
                    else {
                        Console.ReadLine(); 
                        Console.Clear(); 
                        Monster.ReceiveDamage(userAttack);
                        
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"\n>>> BOOM! O {Monster.name} sofreu {userAttack} de Dano!");
                        Console.ResetColor();
                        
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
                else if (respUser == 3) {
                    
                    Console.Clear();
                    int lastStamina = Hero.stamina;
                    Hero.stamina += 25;

                    int recovery = Hero.stamina - lastStamina;

                    if (Hero.stamina > Hero.maxStamina)
                    {
                        Hero.stamina = Hero.maxStamina;
                    }

                    Console.WriteLine($"Você respirou um pouco e recuperou {recovery} de Energia");
                    Console.WriteLine($"Sua energia atual é de {Hero.stamina}");

                    turnPlayerOff = true;
                }
                else
                {
                    Console.WriteLine("\n[!] Opção Inválida.");
                }
            }

            if (Monster.health > 0)
            {
                Hero.stamina += 5;
                Console.WriteLine("\n--- Turno do Inimigo ---");
                if (Monster.health <= 15)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"O {Monster.name} está sangrando muito!!");
                    Console.ResetColor();
                }

                int monsterAttack = Monster.Attack(Given);
                
                Hero.ReceiveDamage(monsterAttack);
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n<<< O {Monster.name} te causou {monsterAttack} de Dano! (Sua Vida: {Hero.health})");
                Console.ResetColor();

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
        Console.WriteLine("2. Poção de Energia (Custo: 25 moedas)");
        Console.WriteLine("3. Poção de Força (Custo: 200 moedas)");
        Console.WriteLine("4. Sair");
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
    public Item? equippedWeapon = null;   // Arma
    public Item? equippedHelmet = null;   // Capacete
    public Item? equippedChest = null;    // Peitoral
    public Item? equippedGauntlet = null; // Manopla
    public Item? equippedLegs = null;     // Calça
    public Item? equippedBoots = null;    // Bota
    public int stamina = 50;
    public int maxStamina = 50;
    public string[] attackNames = new string[4];

    public Character(string name, string type, int health, int power, int coin) : base(name, health, power, coin, 0)
    {
        this.type = type;
        
        // Dando identidade para cada classe!
        if (this.type == "Bárbaro")
        {
            this.attackNames = new string[] { "Soco Rápido", "Machadada Sanguinária", "Desmantelar", "EXECUÇÃO DO BERSERKER" };
        }
        else if (this.type == "Arqueira")
        {
            this.attackNames = new string[] { "Tiro Rápido", "Flecha Perfurante", "Chuva de Prata", "FLECHA DO DRAGÃO" };
        }
        else if (this.type == "Fada")
        {
            this.attackNames = new string[] { "Estaca de Gelo", "Raio de Luz", "Ventos Cortantes", "EXPLOSÃO ESTELAR" };
        }
        else if (this.type == "Mago")
        {
            this.attackNames = new string[] { "Raio Negro", "Raio Congelante", "Bola de Fogo", "METEORO DO APOCALIPSE" };
        }
        else if (this.type == "Elfo")
        {
            this.attackNames = new string[] { "Corte de Folha", "Tempestade de Vento", "Dança das Lâminas", "FÚRIA DA NATUREZA" };
        }
        else if (this.type == "Ladino")
        {  
            this.attackNames = new string[] { "Adaga Oculta", "Sede de Sangue", "Mutilar", "ASSASSINATO FANTASMA" };
        }
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
        
        // O Fôlego aumenta!
        maxStamina += 10;
        stamina = maxStamina;
        
        power += 2;

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\n===================================");
        Console.WriteLine($" 🌟 LEVEL UP! Você alcançou o Nível {level}! 🌟");
        Console.WriteLine($" -> Vida Máxima aumentada para {maxHealth}!");
        Console.WriteLine($" -> Energia Máxima aumentada para {maxStamina}!");
        Console.WriteLine($" -> Força aumentada para {power}!");
        Console.WriteLine($" -> Vida e Energia totalmente restauradas!");
        Console.WriteLine($"===================================");
        Console.ResetColor();
    }
    
    public int Attack(int option, Random Given)
    {
        int finalDamage = 0;
        int cost = 0;

        if (option == 1) cost = 0;
        else if (option == 2) cost = 10;
        else if (option == 3) cost = 20;
        else if (option == 4) cost = 40;
        else return 0;

        if (stamina < cost)
        {
            Console.Clear();
            Console.WriteLine($"\n[!] Você está exausto! (Sua Stamina: {stamina}). Escolha um ataque mais leve.");
            return -1;
        }

        stamina -= cost;


        if (option == 1) finalDamage = power + Given.Next(1, 4); 
        else if (option == 2) finalDamage = (int)(power * 1.5) + Given.Next(2, 6);
        else if (option == 3) finalDamage = (int)(power * 2.0) + Given.Next(3, 8);
        else if (option == 4) finalDamage = (int)(power * 2.5) + Given.Next(5, 12);

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\n>>> Você usou {attackNames[option - 1]}! (-{cost} Stamina)");
        Console.ResetColor();
        
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
                else if (chosenItem == "Poção de Energia")
                {
                    Restore();
                    return true;
                }    
                else if (chosenItem == "Poção de Força")
                {
                    PowerUp();
                    return true;
                }
                else
                {
                    
                    Item? misteryItem = Inventory.Find(i => i.name == chosenItem);
                    if (misteryItem != null)
                    {
                        equipItem(misteryItem);
                    }
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

            Item? potionFound = Inventory.Find(p => p.name == "Poção de Vida");
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
        Item? potionFound = Inventory.Find(p => p.name == "Poção de Força");
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

    public void Restore()
    {
        if (stamina < maxStamina)
        {
            Item? potionFound = Inventory.Find(p => p.name == "Poção de Energia");
            if (potionFound != null)
            {
                int staminaPotion = potionFound.effect;
                int lastStamina = stamina;
                stamina += staminaPotion;

                if (stamina > maxStamina) stamina = maxStamina;  

                int recovery = stamina - lastStamina;

                Console.ForegroundColor = ConsoleColor.Green;
                Inventory.Remove(potionFound);
                Console.WriteLine($"\n(+) Você bebeu uma Poção de Energia e recuperou {recovery} de Energia!");
                Console.ResetColor();
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n[!] Você não tem Poção de Energia");
                Console.ReadLine();
            }
        }
        else
        {
            Console.WriteLine("\n[!] Sua energia já está cheia.");
            Console.ReadLine();
        }
    }

    public void equipItem(Item newItem)
    {
        if (newItem.type == "Arma")
        {
            if (equippedWeapon != null)
            {                
                power -= equippedWeapon.bonusPower;
                Inventory.Add(equippedWeapon);
            }
            
            equippedWeapon = newItem;
            power += equippedWeapon.bonusPower;

            Console.WriteLine($"\n[+] {equippedWeapon.name} Foi Equipado!");
            Inventory.Remove(newItem);
        }
        else if (newItem.type == "Capacete")
        {
            if (equippedHelmet != null)
            {
                defense -= equippedHelmet.bonusDefense;
                Inventory.Add(equippedHelmet);
            }

            equippedHelmet = newItem;
            defense += equippedHelmet.bonusDefense;

            Console.WriteLine($"\n[+] {equippedHelmet.name} Foi Equipado!");
            Inventory.Remove(newItem);
        }
        else if (newItem.type == "Manopla")
        {
            if (equippedGauntlet != null)
            {
                defense -= equippedGauntlet.bonusDefense;
                Inventory.Add(equippedGauntlet);
            }

            equippedGauntlet = newItem;
            defense += equippedGauntlet.bonusDefense;

            Console.WriteLine($"\n[+] {equippedGauntlet.name} Foi Equipado!");
            Inventory.Remove(newItem);
        }
        else if (newItem.type == "Peitoral")
        {
            if (equippedChest != null)
            {
                defense -= equippedChest.bonusDefense;
                Inventory.Add(equippedChest);
            }

            equippedChest = newItem;
            defense += equippedChest.bonusDefense;

            Console.WriteLine($"\n[+] {equippedChest.name} Foi Equipado!");
            Inventory.Remove(newItem);
        }
        else if (newItem.type == "Calça")
        {
            if (equippedLegs != null)
            {
                defense -= equippedLegs.bonusDefense;
                Inventory.Add(equippedLegs);
            }

            equippedLegs = newItem;
            defense += equippedLegs.bonusDefense;

            Console.WriteLine($"\n[+] {equippedLegs.name} Foi Equipado!");
            Inventory.Remove(newItem);
        }
        else if (newItem.type == "Botas")
        {
            if (equippedBoots != null)
            {
                defense -= equippedBoots.bonusDefense;
                Inventory.Add(equippedBoots);
            }

            equippedBoots = newItem;
            defense += equippedBoots.bonusDefense;

            Console.WriteLine($"\n[+] {equippedBoots.name} Foi Equipado!");
            Inventory.Remove(newItem);
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
    public double scaleRate;
    // public Item? loot;
    // public int dropChance;

    public Enemy(string name, int health, int power, int coin, int xpReward, string[] attacks, double scaleRate ) : base(name, health, power, coin, 0)
    {
        this.xpReward = xpReward;
        this.attacks = attacks;
        this.scaleRate = scaleRate;
    }

    public int Attack(Random Given)
    {
        int chooseMonster = Given.Next(0, 4);
        int finalDamage = 0;
        
        if (chooseMonster == 0)
        {
            Console.WriteLine($"\n! O {name} usou {attacks[0]}!");
            finalDamage = power + Given.Next(1, 4);
        }
        else if (chooseMonster == 1)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n! O {name} usou {attacks[1]}!");
            Console.ResetColor();
            finalDamage = (int)(power * 1.3) + Given.Next(2, 5);
        }
        else if (chooseMonster == 2)
        {
            Console.WriteLine($"\n! O {name} usou {attacks[2]}!");
            finalDamage = (int)(power * 1.6) + Given.Next(3, 6);
        }
        else if (chooseMonster == 3)
        {
            System.Threading.Thread.Sleep(800); 

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            
            Console.WriteLine($"\n ☠️ !!! O {name.ToUpper()} USOU {attacks[3].ToUpper()} !!! ☠️ ");
            
            Console.ResetColor(); 
            System.Threading.Thread.Sleep(400);
            finalDamage = (int)(power * 2.0) + Given.Next(4, 8);
        }
        
        return finalDamage;
    }
    public void ScaleStats(int heroLevel)
    {
        if (heroLevel > 1)
        {
            double multiplier = 1.0 + ((heroLevel - 1) * scaleRate);

            this.maxHealth = (int) (this.maxHealth * multiplier);
            this.health = this.maxHealth;
            this.power = (int) (this.power * multiplier);

            double lootMultiplier = 1.0 + ((heroLevel - 1) * 0.10);
            this.xpReward = (int) (this.xpReward * lootMultiplier);
            this.coin = (int) (this.coin * lootMultiplier);
        }
    }
}