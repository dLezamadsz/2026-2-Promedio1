using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio1
{
    internal class Player
    {
        public int hp = 30;
        public int dmg = 5;
        public bool alive = true;

        public Player(int hp, int dmg, bool a)
        {
            this.hp = hp;
            this.dmg = dmg;
            this.alive = a;
        }

        public void GetDamage(Enemy e)
        {
            hp -= e.dmg;
        }

        public int Attack()
        {
            return dmg;
        }

        public void IsDead()
        {
            if(hp <= 0)
            {
                alive = false;
            }
        }
    }
}
