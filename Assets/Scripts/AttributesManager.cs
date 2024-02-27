using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributesManager : MonoBehaviour
{
    public int health;
    public int attack;
    public int defence;

    public void TakeDamage(int amount)
    {
        if (defence < amount)
        {
            health = health - (amount - defence);
            amount -= defence;
        }

        else
        {
            // If the defence is greater than the damage taken
            amount = 0;
        }
    }

    public void DealDamage(GameObject target)
    {
        var atm = target.GetComponent<AttributesManager>();
        if (atm != null)
        {
            atm.TakeDamage(attack);
        }
    }
}