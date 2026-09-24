using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio1
{
    internal class Boss : Enemy
    {
        public int hp = 15;
        public int dmg = 6;
        public bool alive = true;

        public Boss(int hp, int dmg, bool a) : base(hp, dmg, a)
        {
            this.hp = hp;
            this.dmg = dmg;
            this.alive = a;
        }

        public override void GetDamage(Player p)
        {
            hp -= p.dmg;
        }

        public override int Attack()
        {
            return dmg;
        }

        public override bool IsDead()
        {
            if (hp <= 0)
            {
                alive = false;
            }
            return alive;
        }
    }
}
