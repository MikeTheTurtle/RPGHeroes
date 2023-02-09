using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using RPGHeroes.Attributes_State_Machine;

public class AttributesStatePattern
{
    private AttributesBaseState _currentState;

    //Armor States
    public AttributesNoEquipmentState attributesNoEquipmentState;
    public AttributesOneArmorPieceState attributesOneArmorPieceState;
    public AttributesTwoArmorPiecesState attributesTwoArmorPiecesState;
    public AttributesReplacedArmorState attributesReplacedArmorState;

    //Standard Values
    public double one;
    public double two;
    public double three;
    public double four;

    public void InitializeStates()
    {
        attributesNoEquipmentState = new AttributesNoEquipmentState(this);
        attributesOneArmorPieceState = new AttributesOneArmorPieceState(this);
        attributesTwoArmorPiecesState = new AttributesTwoArmorPiecesState(this);
        attributesReplacedArmorState = new AttributesReplacedArmorState(this);
    }

    public void ChangeState(AttributesBaseState nextState)
    {
        if (_currentState != null)
        {
            _currentState.Exit();
        }

        _currentState = nextState;

        _currentState.Enter();
    }
}