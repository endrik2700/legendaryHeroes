using System;
using System.Linq;


namespace LegendaryHeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Arnold Scwarzeneger");
            Player player2 = new Player("Chuck Norris");

            for (int i =0; i<3;i++)
            {
                Random queNr = new Random();
               string nr = queNr.Next(1, 2).ToString();
                int startingNr = int.Parse(nr);

                if (startingNr ==1)
                {
                   int damageDealt =player1.MakeDamage();
                    player2.TakeDamage(damageDealt);
                }

                else if (startingNr == 2)
                {
                    int damageDealt = player2.MakeDamage();
                    player1.TakeDamage(damageDealt);
                } 
                else
                {
                    Console.WriteLine("Something is wrong");
                }
           

            }
            if (player1.healthPoints > player2.healthPoints)
            {
                Console.WriteLine($"{player1.name} IS THE WINNER");
            }
            else if (player1.healthPoints < player2.healthPoints)
            {

                Console.WriteLine($"{player2.name} IS THE WINNER");
            }
            else if (player1.healthPoints == player2.healthPoints)
            {

                Console.WriteLine("It's a tie");
            }
            else
            {
                Console.WriteLine("There is something wrong");
            }
            Console.ReadLine();
        }
    }
   public  class Player
    {
        public string name { get; set; }
        public  int healthPoints { get; set; }

        public Player (string _name)
        {
            name = _name;
            Random generateHP = new Random ();
            healthPoints = generateHP.Next(100,150);
        }

       

        public Int32 MakeDamage()
        {
            int damage;
            Random damageGenerator = new Random();
            damage = damageGenerator.Next(10,50);
            return damage;
        }

        public void TakeDamage (int dmg)
        {
            healthPoints = healthPoints - dmg;
            if (healthPoints <0)
            {
                healthPoints = 0;
            }
        }

    }
}
