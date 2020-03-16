using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    [SerializeField] private AmmoType ammoType;
    [SerializeField] private int ammoAmount = 5;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            print("Pickup collected by Player");
            Destroy(gameObject);
            FindObjectOfType<Ammo>().IncreaseCurrentAmmo(ammoType, ammoAmount);
        }
    }
}
