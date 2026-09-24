using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Promedio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player;
            List<Enemy> enemies = { EnemyOne e1, EnemyTwo e2, EnemyOne e3 };
            Boss boss;
            Game g = new Game();
            g.RunGame(player,enemies);
        }
    }
}
