using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio1
{
    internal class EnemyTwo : Enemy
    {
        public int hp = 7;
        public int dmg = 3;
        public bool alive = true;

        public EnemyTwo(int hp, int dmg, bool a) : base(hp, dmg, a)
        {
            this.hp = hp;
            this.dmg = dmg;
            this.alive = a;
        }

        public override void GetDamage(Player p)
        {
            hp -= p.hp;
        }

        public override int Attack()
        {
            return dmg;
        }

        public override void IsDead()
        {
            if (hp <= 0)
            {
                alive = false;
            }
        }
    }
}
