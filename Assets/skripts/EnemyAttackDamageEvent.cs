using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackDamageEvent : MonoBehaviour
{
    public EnemyAI enemyAI;
    public void AttackDamageEvent()
    {
        enemyAI.AttackDamage();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
