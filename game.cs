using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    public static void Main()
    {
        Console.Write("Digite Seu Nome: ");
        string n = Console.ReadLine();

        showClass();


        bool validateNumber = false;
        Character Hero = null;
        while (validateNumber == false)
        {
            Console.Write("Escolha (1-6): ");
            if (!int.TryParse(Console.ReadLine(), out int chooseClass)) continue;
            if (chooseClass == 1)
            {
                Hero = new Character(n, "Barbáro", 120, 10, 5 );
                validateNumber = true;
                Hero.Inventory.Add("Poção de Força");
                Hero.Inventory.Add("Poção de Força");
            }
            else if (chooseClass == 2)
            {
                Hero = new Character(n, "Arqueira", 100, 8, 10);
                validateNumber = true;
                Hero.Inventory.Add("Poção de Vida");
            }
            else if (chooseClass == 3)
            {
                Hero = new Character(n, "Fada", 130, 7, 5);
                validateNumber = true;
                Hero.Inventory.Add("Poção de Vida");
                Hero.Inventory.Add("Poção de Vida");
            }
            else if (chooseClass == 4)
            {
                Hero = new Character(n, "Mago", 80, 11, 3);
                validateNumber = true;
                Hero.Inventory.Add("Poção de Vida");
                Hero.Inventory.Add("Poção de Força");
            }
            else if (chooseClass == 5)
            {
                Hero = new Character(n, "Elfo", 90, 9, 3);
                validateNumber = true;
                Hero.Inventory.Add("Poção de Vida");
                Hero.Inventory.Add("Poção de Força");
            }
            else if (chooseClass == 6)
            {
                Hero = new Character(n, "Ladino", 100, 7, 15);
                validateNumber = true;
                Hero.Inventory.Add("Poção de Vida");
                Hero.Inventory.Add("Poção de Força");
            }
            else
            {
                Console.WriteLine("Número Inválido (Escolha um Número de 1 a 6)");
            }
        }

        MainIntro(Hero);

        bool inLobby = true;

        while (inLobby == true && Hero.health > 0)
        {
            ShowLobbyOptions();

            if (!int.TryParse(Console.ReadLine(), out int choose)) continue;

            if (choose == 1)
            {
                Enemy Wolf = new Enemy("Lobo Cinzento", 100, 7, 20, 25);
                Arena(Hero, Wolf);
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
                            Console.WriteLine("* POÇÂO DE VIDA RECEBIDA");
                            Hero.coin -= 10;
                        }
                        else
                        {
                            Console.WriteLine("Você não tem moedas o suficiente");
                        }
                    }
                    else if(choose2 == 2)
                    {
                        if (Hero.coin >= 50)
                        {   
                            Hero.Inventory.Add("Poção de Força");
                            Console.WriteLine("* POÇÂO DE FORÇA RECEBIDA\n"); 
                            Hero.coin -= 50;
                        }
                        else
                        {
                            Console.WriteLine("Você não tem moedas o suficiente");
                        }
                    }
                    else if(choose2 == 3)
                    {
                        Console.WriteLine("Você saiu da Loja");
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
        Console.WriteLine("Escolha Sua Classe: ");
        Console.WriteLine("1. Barbáro   (Vida: 120 | Força:10) | Itens: (2x Pocão de Força) | (5 Moedas) |");
        Console.WriteLine("2. Arqueira  (Vida: 100 | Força:8)  | Itens: (1x Poção de Vida)  | (10 Moedas)|");
        Console.WriteLine("3. Fada      (Vida: 130 | Força:7)  | Itens: (2x Poção de Vida)  | (5 Moedas) |");
        Console.WriteLine("4. Mago      (Vida: 80  | Força:11) | Itens: (1x Poção de Vida)  | (1x Pocão de Força) | (3 Moedas) |");
        Console.WriteLine("5. Elfo      (Vida: 90  | Força:9)  | Itens: (1x Poção de Vida)  | (1x Pocão de Força) | (3 Moedas) |");
        Console.WriteLine("6. Ladino    (Vida: 100 | Força:7)  | Itens: (1x Poção de Vida)  | (1x Pocão de Força) | (15 Moedas)|");
    }
    public static void ShowLobbyOptions()
    {
        Console.WriteLine(" Onde Você Deseja Ir?");
        Console.WriteLine(" 1. Grande Floresta (Batalhar)");
        Console.WriteLine(" 2. Loja");
        Console.WriteLine(" 3. Desistir da Aventura... (FIM DE JOGO)");
    }

    public static void Story()
    {
        Console.WriteLine(" Onde Você Deseja Ir?");
        Console.WriteLine(" 1. Ir pra Direita");
        Console.WriteLine(" 2. Ir pra Esquerda");
        Console.WriteLine(" 3. Continuar em Frente");
    }
    public static void ShowOptions()
    {
        Console.WriteLine("\n--- O QUE DESEJA FAZER? ---");
        Console.WriteLine("1. Atacar");
        Console.WriteLine("2. Abrir Mochila");
        Console.Write("Escolha: ");    }
    public static void ShowAttackOptions()
    {
        Console.WriteLine("------------------------------------- ESCOLHA UM ATAQUE ----------------------------------------");
        Console.WriteLine("| 1. Corte Rápido (1-11)      | Mult: 0.5x |"); 
        Console.WriteLine("| 2. Adaga de 2 Gumes (20-50) | Mult: 1.5x |");  
        Console.WriteLine("| 3. Orbe (15-45)             | Mult: 0.0x |");     
        Console.WriteLine("| 4. Arriscado (10-80)        | Mult: 2.5x |");
        Console.WriteLine("| 5. Voltar");
        Console.WriteLine("------------------------------------------------------------------------------------------------");
        Console.Write($"Qual Opção Deseja Usar, 1, 2, 3, 4 ou 5?: ");
    }


    public static void ShowStats(Character c, Enemy e)
    {
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine($"| {c.name.ToUpper()} HP: {c.health} | {e.name.ToUpper()} HP: {e.health} |");
        Console.WriteLine("---------------------------------------------");
    }

    public static void MainIntro(Character c)
    {
        Console.WriteLine($"\nO {c.type} chamado {c.name} irá sair em sua primeira aventura, Sua Força Atual é de {c.power}.\n");
        Console.WriteLine("MÃE: Espere!! Leve isso com você!\n");
        Console.WriteLine("* VOCÊ RECEBEU 10 Moedas");
        c.coin += 10;
        Console.WriteLine("MÃE: Por Favor meu filho se cuide...\n");
    }


    public static void BattleIntro(Enemy e)
    {
        Console.WriteLine($"Urgente!!, Um {e.name} foi avistado, Chegou a hora da BATALHA!");
    }

   public static void MessageGameOver(Character c)
    {
        Console.WriteLine($"Então o {c.name} Ficou com medo e resolveu desistir de sua aventura, e voltou para sua casa de volta para os braços de sua mãe. Os anos se passaram, ele foi ficando cada vez mais velho e por conta da sua fraqueza ele não conseguiu seguir com o seu sonho de ser um grande {c.type}, e morreu pateticamente de velhice.\n ");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("FIM DE JOGO");
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
            int lastAttackUsed = 1;
           
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
                        Console.WriteLine("Ataque Inválido. (Escolha de 1 a 4)");
                        continue;
                    }
                    else
                    {
                        Monster.ReceiveDamage(userAttack);
                        Console.WriteLine($"{Monster.name} sofreu {userAttack} de Dano!");
                        turnPlayerOff = true; // Encerra turno do jogador
                        lastAttackUsed = respUserAttack;
                    }
                }
                else if (respUser == 2) // MOCHILA
                {
                    bool usedItem = Hero.OpenBag();


                    if (usedItem == true)
                    {
                        turnPlayerOff = true;
                        lastAttackUsed = 1;
                    }
                    else
                    {
                        Console.WriteLine("Você fechou a Mochila");
                    }
                }
                else
                {
                    Console.WriteLine("Opção Inválida. (Escolha de 1 ou 2 )");
                }
            }


            // TURNO DO INIMIGO
            if (Monster.health > 0)
            {
               
                if (Monster.health <= 15)
                {
                    Console.WriteLine($"O {Monster.name} Está Sangrando Muito!!, Vida Restante: {Monster.health}");
                }
                else
                {
                    Console.WriteLine($"O {Monster.name} Ainda Está Muito Forte, Vida Restante: {Monster.health}");
                }

                int monsterAttack = Monster.Attack(lastAttackUsed, Given);
                Console.WriteLine($"O {Monster.name} Revidou e Te Causou {monsterAttack} de Dano, Sua Vida Restante: {Hero.health}");
                Hero.ReceiveDamage(monsterAttack);

                if (Hero.health <= 0)
                {
                    Console.WriteLine($"VOCÊ FOI MORTO PELO {Monster.name.ToUpper()}!");
                }
            }
        }


        if (Monster.health <= 0 && Hero.health > 0)
        {
            Console.WriteLine($"O {Monster.name} Foi Morto, Que Vitória Gloriosa!");
            Hero.coin += Monster.coin;
            Hero.GainXp(Monster.xpReward);
            Console.WriteLine($"Você encontoru {Monster.coin} moedas no corpo do {Monster.name}");
        }
    }

    public static void Shop(Character c)
    {
        Console.WriteLine("Você vai até o Mercador...\n");
        Console.WriteLine($"Moedas Restantes: {c.coin}");
        Console.WriteLine("-------------------------------------------------------------------------");
        Console.WriteLine("Mercador: Olá pequeno viajante, oque você deseja?\n");
        Console.WriteLine("1. Poção de Vida (Custo: 10 moedas)");
        Console.WriteLine("2. Poção de Força (Custo: 50 moedas)");
        Console.WriteLine("3. Sair");


    }
}  

public class Entity
{
    public string name;
    public int health;
    public int maxHealth;
    public int power;
    public int coin;

    public Entity(string n, int h, int p, int c)
    {
        name = n;
        health = h;
        maxHealth = h;
        power = p;
        coin = c;
    }
    public void ReceiveDamage(int damage)
    {
        health = health - damage;
        if (health < 0)
        {
            health = 0;
        }
    }
}
public class Character : Entity
{
    public string type;
    public int level = 1;
    public int xp = 0;
    public int xpToNextLevel = 50;

    public Character(string n, string t, int h, int p, int c) : base(n, h, p, c)
    {
        type = t;
    }

    public void GainXp(int amount)
    {

        xp += amount;

        Console.WriteLine($"Você ganhou {amount} de XP!");
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
        Console.WriteLine($"\n LEVEL UP! Você alcançou o Nível {level}! ");
        Console.ResetColor();
    }
    public int Attack(int option, Random Given)
    {
        int finalDamage = 0;


        if (option == 1)
        {
            finalDamage = (int)(power * 0.5) + Given.Next(1, 12);
        }
        else if (option == 2)
        {
            finalDamage = (int)(power * 1.5) + Given.Next(20, 51);
        }
        else if (option == 3)
        {
            finalDamage = power + Given.Next(15, 46);
        }
        else if (option == 4)
        {
            finalDamage = (int)(power * 2.5) + Given.Next(10, 81);
        }
        return finalDamage;
    }

    public List<string> Inventory = new List<string>();

    public bool OpenBag()
    {
        Console.WriteLine("\n--- MOCHILA ---");
        if (Inventory.Count == 0)
        {
            Console.WriteLine("(Vazia)");
            return false;
        }

        var groupedItems = Inventory.GroupBy(item => item).ToList();

        int option = 1;

        foreach (var group in groupedItems)
        {
            Console.WriteLine($"{option} . {group.Key} (x{group.Count()})");
            option++;
        }

        int optionClose = option;
        Console.WriteLine($"{optionClose} . Fechar");


        Console.Write("Escolha: ");


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
                    Console.WriteLine($"Você usou {chosenItem}, mas nada aconteceu.");
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
                int lifePotion = 20;
                int lastHealth = health;
                health  += lifePotion;


                if (health >maxHealth)
                {
                    health = maxHealth;  
                }


                int recovery = health - lastHealth;


                Console.ForegroundColor = ConsoleColor.Green;
                Inventory.Remove("Poção de Vida");
                Console.WriteLine($"Você bebeu uma Poção de Vida e recuperou {recovery} de vida!");
                Console.WriteLine($"Vida Restante: {health}!");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Você não tem Poção de Vida");
            }
        }
        else
        {
            Console.WriteLine("Você está com a vida CHEIA.");
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
            Console.WriteLine($"Você bebeu uma Poção de Força, e aumentou {strengthPotion} de pontos de Força!");
            Console.WriteLine($"Força Atual: {power}!");
            Console.ResetColor();
        }
    }
}


public class Enemy : Entity
{       

    public int xpReward;
    public Enemy(string n, int h, int p, int c, int x) : base(n, h, p ,c)
    {
        xpReward = x;
    }


    public int Attack(int playerAction, Random Given)
    {
        int finalDamage = 0;
        if (playerAction == 1) {
            finalDamage = power + Given.Next(1, 12);
            Console.WriteLine($"\n! O {name} te Ataca!");
        }
        else if (playerAction == 2)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n! O {name} foi provocado pelo seu golpe forte !");
            Console.ResetColor();
            finalDamage = (int)(power * 2.0) + Given.Next(25, 56);
        }
        else if (playerAction == 3)
        {
            Console.WriteLine($"\n! O {name} te Ataca Mostrando o seu poder!");
            finalDamage = power + Given.Next(15, 46);
        }
        else if (playerAction == 4)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n!!! O {name} ficou FURIOSO com seu ataque !!!");
            Console.ResetColor();
            finalDamage = (int)(power * 3.0) + Given.Next(10, 81);
        }
        return finalDamage;
    }
}

