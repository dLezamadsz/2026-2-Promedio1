using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio1
{
    internal class Enemy
    {
        public int hp;
        public int dmg;
        public bool alive = true;

        public Enemy(int hp, int dmg, bool a)
        {
            this.hp = hp;
            this.dmg = dmg;
            this.alive = a;
        }

        public virtual void GetDamage(Player p);
        public virtual int Attack();
        public virtual bool IsDead();
    }
}
