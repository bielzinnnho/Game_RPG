using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
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
                Hero.Inventory.Add("Poção de Força");
                Hero.Inventory.Add("Poção de Força");
            }
            else if (chooseClass == 2)
            {
                Hero = new Character(name, "Arqueira", 100, 8, 10);
                validateNumber = true;
                Hero.Inventory.Add("Poção de Vida");
            }
            else if (chooseClass == 3)
            {
                Hero = new Character(name, "Fada", 130, 7, 5);
                validateNumber = true;
                Hero.Inventory.Add("Poção de Vida");
                Hero.Inventory.Add("Poção de Vida");
            }
            else if (chooseClass == 4)
            {
                Hero = new Character(name, "Mago", 80, 11, 3);
                validateNumber = true;
                Hero.Inventory.Add("Poção de Vida");
                Hero.Inventory.Add("Poção de Força");
            }
            else if (chooseClass == 5)
            {
                Hero = new Character(name, "Elfo", 90, 9, 3);
                validateNumber = true;
                Hero.Inventory.Add("Poção de Vida");
                Hero.Inventory.Add("Poção de Força");
            }
            else if (chooseClass == 6)
            {
                Hero = new Character(name, "Ladino", 100, 7, 15);
                validateNumber = true;
                Hero.Inventory.Add("Poção de Vida");
                Hero.Inventory.Add("Poção de Força");
            }
            else
            {
                Console.WriteLine("\n[!] Número Inválido. Escolha um Número de 1 a 6.");
            }
        }

        MainIntro(Hero!);

        bool inLobby = true;

        while (inLobby == true && Hero!.health > 0)
        {
            ShowLobbyOptions();

            if (!int.TryParse(Console.ReadLine(), out int choose)) continue;

            if (choose == 1)
            {   
                Random monsters = new Random();
                int monsterRandom = monsters.Next(1, 5);

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
                
                Arena(Hero, enemy);
            }
            else if(choose == 2)
            {
                bool inShop = true;
                while (inShop == true)
                {
                    Shop(Hero);
                    if (!int.TryParse(Console.ReadLine(), out int choose2)) continue;

                    if (choose2 == 1)
                    {
                        if (Hero.coin >= 10)
                        {
                            Hero.Inventory.Add("Poção de Vida");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n[+] POÇÃO DE VIDA RECEBIDA!");
                            Console.ResetColor();
                            Hero.coin -= 10;
                        }
                        else
                        {
                            Console.WriteLine("\n[!] Você não tem moedas o suficiente.");
                        }
                    }
                    else if(choose2 == 2)
                    {
                        if (Hero.coin >= 50)
                        {   
                            Hero.Inventory.Add("Poção de Força");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n[+] POÇÃO DE FORÇA RECEBIDA!"); 
                            Console.ResetColor();
                            Hero.coin -= 50;
                        }
                        else
                        {
                            Console.WriteLine("\n[!] Você não tem moedas o suficiente.");
                        }
                    }
                    else if(choose2 == 3)
                    {
                        Console.WriteLine("\nSaindo da loja e voltando para a praça...\n");
                        inShop = false;
                    }
                } 
            }
            else if(choose == 3)
            {
                MessageGameOver(Hero);
                inLobby = false;
            }
        }
    }

    public static void showClass()
    {
        Console.WriteLine("\n--- CLASSES DISPONÍVEIS ---");
        Console.WriteLine("1. Bárbaro   (Vida: 120 | Força: 10) | Itens: (2x Poção de Força)         | (5 Moedas)");
        Console.WriteLine("2. Arqueira  (Vida: 100 | Força: 8)  | Itens: (1x Poção de Vida)          | (10 Moedas)");
        Console.WriteLine("3. Fada      (Vida: 130 | Força: 7)  | Itens: (2x Poção de Vida)          | (5 Moedas)");
        Console.WriteLine("4. Mago      (Vida: 80  | Força: 11) | Itens: (1x Poção de Vida, 1x Poção de Força)       | (3 Moedas)");
        Console.WriteLine("5. Elfo      (Vida: 90  | Força: 9)  | Itens: (1x Poção de Vida, 1x Poção de Força)       | (3 Moedas)");
        Console.WriteLine("6. Ladino    (Vida: 100 | Força: 7)  | Itens: (1x Poção de Vida, 1x Poção de Força)       | (15 Moedas)");
        Console.WriteLine("---------------------------");
    }
    
    public static void ShowLobbyOptions()
    {
        Console.WriteLine("\n==========================================");
        Console.WriteLine("             PRAÇA CENTRAL                ");
        Console.WriteLine("==========================================");
        Console.WriteLine(" Onde Você Deseja Ir?");
        Console.WriteLine(" 1. Grande Floresta (Batalhar)");
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
        Console.WriteLine($" Força: {c.power}");
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
        Console.WriteLine($"Ele viu as pessoas que ele mais amava morrerem e com muito sofrimento,");
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
                
                if (respUser == 1) // ATACAR
                {
                    ShowAttackOptions();
                    if (!int.TryParse(Console.ReadLine(), out int respUserAttack)) continue;
                    
                    if(respUserAttack == 5) continue; // Voltar

                    userAttack = Hero.Attack(respUserAttack, Given);
                    
                    if (userAttack == 0)
                    {
                        Console.WriteLine("\n[!] Ataque Inválido.");
                        continue;
                    }
                    else
                    {
                        Monster.ReceiveDamage(userAttack);
                        Console.WriteLine($"\n>>> BOOM! O {Monster.name} sofreu {userAttack} de Dano!");
                        turnPlayerOff = true; 
                    }
                }
                else if (respUser == 2) // MOCHILA
                {
                    bool usedItem = Hero.OpenBag();

                    if (usedItem == true)
                    {
                        turnPlayerOff = true;
                    }
                    else
                    {
                        Console.WriteLine("\nVocê fechou a Mochila.");
                    }
                }
                else
                {
                    Console.WriteLine("\n[!] Opção Inválida.");
                }
            }

            // TURNO DO INIMIGO
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

                if (Hero.health <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"\n================================================");
                    Console.WriteLine($"      VOCÊ FOI MORTO PELO {Monster.name.ToUpper()}!");
                    Console.WriteLine($"================================================\n");
                    Console.ResetColor();
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

            Console.WriteLine("\nPressione ENTER para voltar à praça...");
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

    public Entity(string name, int health, int power, int coin)
    {
        this.name = name;
        this.health = health;
        this.maxHealth = health;
        this.power = power;
        this.coin = coin;
    }
    public void ReceiveDamage(int damage)
    {
        health -= damage;
        if (health < 0) health = 0;
    }
}

public class Character : Entity
{
    public string type;
    public int level = 1;
    public int xp = 0;
    public int xpToNextLevel = 50;

    public Character(string name, string type, int health, int power, int coin) : base(name, health, power, coin)
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
        xpToNextLevel += 20;

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

    public List<string> Inventory = new List<string>();

    public bool OpenBag()
    {
        Console.WriteLine("\n============= MOCHILA =============");
        if (Inventory.Count == 0)
        {
            Console.WriteLine(" (Vazia)");
            Console.WriteLine("===================================");
            return false;
        }

        var groupedItems = Inventory.GroupBy(item => item).ToList();
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
                    Console.WriteLine($"\nVocê usou {chosenItem}, mas nada aconteceu.");
                    Inventory.Remove(chosenItem);
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
            if (Inventory.Contains("Poção de Vida"))
            {
                int lifePotion = 30; 
                int lastHealth = health;
                health += lifePotion;

                if (health > maxHealth) health = maxHealth;  

                int recovery = health - lastHealth;

                Console.ForegroundColor = ConsoleColor.Green;
                Inventory.Remove("Poção de Vida");
                Console.WriteLine($"\n(+) Você bebeu uma Poção de Vida e recuperou {recovery} de HP!");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("\n[!] Você não tem Poção de Vida");
            }
        }
        else
        {
            Console.WriteLine("\n[!] Sua vida já está cheia.");
        }
    }
    
    public void PowerUp() 
    {
        if (Inventory.Contains("Poção de Força")) 
        {
            int strengthPotion = 3;
            power += strengthPotion;
            
            Console.ForegroundColor = ConsoleColor.Green;
            Inventory.Remove("Poção de Força");
            Console.WriteLine($"\n(💪) Você bebeu uma Poção de Força, e aumentou {strengthPotion} pontos de Força! (Atual: {power})");
            Console.ResetColor();
        }
    }
}

public class Enemy : Entity
{       
    public int xpReward;
    public string[] attacks;

    public Enemy(string name, int health, int power, int coin, int xpReward, string[] attacks) : base(name, health, power, coin)
    {
        this.xpReward = xpReward;
        this.attacks = attacks;
    }

    public int Attack(Random Given)
    {
        // Arrays começam em 0, então sorteamos de 0 a 3
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