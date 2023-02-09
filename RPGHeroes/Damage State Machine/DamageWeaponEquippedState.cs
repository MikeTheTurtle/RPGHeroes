using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Damage_State_Machine
{
    public class DamageWeaponEquippedState : DamageBaseState
    {
        //CONSTRUCTOR
        public DamageWeaponEquippedState(DamageStatePattern stateMachine)
        {
            base.p_equipment = stateMachine;
        }

        //SHARED FUNCTIONS
        public override void Enter()
        {

        }

        public override void Execute()
        {

        }

        public override void Exit()
        {

        }
    }
}