using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDamage : MonoBehaviour
{


    public int damageHp;
  
    public int damageMoral;

    public int damageMp;



    public Health target;
    public void DamageNow()
    {
        target.ChangeHealth
    }
}
