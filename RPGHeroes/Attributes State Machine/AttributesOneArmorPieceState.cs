using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Attributes_State_Machine
{
    public class AttributesOneArmorPieceState : AttributesBaseState
    {
        //CONSTRUCTOR
        public AttributesOneArmorPieceState(AttributesStatePattern stateMachine)
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