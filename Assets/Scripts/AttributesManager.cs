using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributesManager : MonoBehaviour
{

    // Creating values that enemies/players will have.
    public int health;
    public int attack;
    public int defence;

    public void TakeDamage(int amount)
    {
        // If defence is lower then the attack, take damage
        if (defence < amount)
        {
            health = health - (amount - defence);
           // amount -= defence;
        }

        else
        {
            // If the defence is greater than the damage taken
            amount = 0;
        }
    }

    // Checks of target has an AttributesManager, if yes, deal damage
    public void DealDamage(GameObject target)
    {
        var atm = target.GetComponent<AttributesManager>();
        if (atm != null)
        {
            atm.TakeDamage(attack);
        }
    }


    // If something has 0 health, destory it. 
    private void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}