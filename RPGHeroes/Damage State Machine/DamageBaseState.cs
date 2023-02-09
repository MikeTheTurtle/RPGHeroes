using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Damage_State_Machine
{
    public abstract class DamageBaseState
    {
        protected DamageStatePattern p_equipment;

        public virtual void Initialize()
        {

        }

        public virtual void Enter()
        {

        }

        public virtual void Execute()
        {

        }

        public virtual void Exit()
        {

        }
    }
}