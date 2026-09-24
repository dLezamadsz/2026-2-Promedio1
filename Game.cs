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

        public void RunGame(Player player, List<Enemy> enemies)
        {
            Console.WriteLine("Elige un enemigo para atacar");
            for(int i = 0; i < enemies.Count; i++)
            {
                Console.WriteLine($"({i}) Enemigo {i+1}");
            }
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                default: break;
                case 0: break;
                case 1: break;
                case 2: break;
            }

            if(enemies.Count == 0)
            {

            }
        }

        public void Combat(Player player, Enemy enemy)
        {
            enemy.GetDamage(player);
            player.GetDamage(enemy);
        }
    }
}
