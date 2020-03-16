using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float hitPoints = 100f;

    public void TakeDamage(float dmgPoints)
    {
        hitPoints -= dmgPoints;

        if (hitPoints <= 0)
        {
           GetComponent<DeathHandler>().HandleDeath();
        }
    }
}
