using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using RPGHeroes.Damage_State_Machine;

public class DamageStatePattern
{
    private DamageBaseState _currentState;

    //Armor States
    public DamageNoEquipmentState damageNoEquipmentState;
    public DamageWeaponEquippedState damageWeaponEquippedState;
    public DamageWeaponAndArmorEquippedState damageWeaponAndArmorEquippedState;
    public DamageReplacedWeaponState damageReplacedWeaponState;

    //Standard Values
    public double one;
    public double two;
    public double three;
    public double four;

    public void InitializeStates()
    {
        damageNoEquipmentState = new DamageNoEquipmentState(this);
        damageWeaponEquippedState = new DamageWeaponEquippedState(this);
        damageWeaponAndArmorEquippedState = new DamageWeaponAndArmorEquippedState(this);
        damageReplacedWeaponState = new DamageReplacedWeaponState(this);
    }

    public void ChangeState(DamageBaseState nextState)
    {
        if (_currentState != null)
        {
            _currentState.Exit();
        }

        _currentState = nextState;

        _currentState.Enter();
    }
}