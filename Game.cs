using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio1
{
    internal class Game
    {
        public Player player;
        public List<Enemy> enemies = {EnemyOne e1, EnemyTwo e2, EnemyOne e3};
        public Boss boss;
        public int run = 1;

        public void RunGame(Player player, List<Enemy> enemies)
        {
            while(run == 1)
            {
                Console.WriteLine("Elige un enemigo para atacar");
                for (int i = 0; i < enemies.Count; i++)
                {
                    Console.WriteLine($"({i}) Enemigo {i + 1}");
                }
                int x = int.Parse(Console.ReadLine());
                if (x < 0 || x > enemies.Count)
                {
                    Console.WriteLine("No puede iniciar el combate.");
                }
                else
                {
                    Combat(player, enemies[x]);
                    if (enemies[x].IsDead() == true)
                    {
                        enemies.Remove(enemies[x]);
                    }
                }

                if (enemies.Count == 0)
                {
                    Combat(player, boss);
                }
                if (boss.IsDead() == true)
                {
                    Console.WriteLine("VICTORIA!!");
                }
            }
        }

        public void Combat(Player player, Enemy enemy)
        {
            while (enemy.alive==true && player.alive==true)
            {
                enemy.GetDamage(player);
                player.GetDamage(enemy);
                if(player.alive == false)
                {
                    run = 0;
                }
            }
        }
    }
}
