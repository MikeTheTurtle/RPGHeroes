using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Damage_State_Machine
{
    public class DamageWeaponAndArmorEquippedState : DamageBaseState
    {
        //CONSTRUCTOR
        public DamageWeaponAndArmorEquippedState(DamageStatePattern stateMachine)
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