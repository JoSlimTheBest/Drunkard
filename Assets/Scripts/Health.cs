using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHP = 100;
    public int currentHP = 100;
    public int maxMoral = 100;
    public int currentMoral = 100;
    public int maxMana = 100;
    public int currentMana = 100;

    public virtual void ChangeHealth(int value)
    {

        currentHP += value;
        if (currentHP > maxHP)
        {
            currentHP = maxHP;  
        }


        if(currentHP <= 0)
        {
            currentHP = 0;
            Die();
        }
    }

    public virtual void ChangeMoral(int value)
    {


        
        currentMoral += value;


        if (currentMoral > maxMoral)
        {
            currentMoral = maxMoral;
        }
        if (currentMoral <= 0) 
        {
            currentMoral = 0;
            MoralLose();
        }
    }

    public virtual void ChangeMana(int value)
    {
        currentMana += value;
    }


    public void Die()
    {

    }

    public void MoralLose()
    {

    }

}

