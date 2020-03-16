using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    PlayerHealth target;
    [SerializeField] private float damage = 40f;
    
    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
    }
    
    public void AttackHitEvent()
    {
        if (target)
        {
            target.TakeDamage(damage);
        }
    }
}
