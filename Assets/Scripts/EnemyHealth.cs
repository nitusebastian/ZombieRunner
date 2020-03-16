using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private float hitPoints = 100f;

    private bool isDead = false;

    public bool IsDead()
    {
        return isDead;
    }

    public void TakeDamage(float dmgPoints)
    {
        BroadcastMessage("OnDamageTaken");
        hitPoints -= dmgPoints;

        if (hitPoints <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        if (isDead) return;
        
        isDead = true;
        GetComponent<Animator>().SetTrigger("die");
        GetComponent<EnemyAI>().enabled = false;
        GetComponent<EnemyAI>().GetNavMeshAgent().enabled = false;
    }
}
