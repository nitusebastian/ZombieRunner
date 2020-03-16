using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    [SerializeField] private Canvas gameOverCanvas;

    private void Start()
    {
        gameOverCanvas.enabled = false;
    }

    
    public void HandleDeath()
    {
        gameOverCanvas.enabled = true;
        // stop time
        Time.timeScale = 0;

        DisablePlayerComponents();

        //enable cursos
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    private void DisablePlayerComponents()
    {
        GetComponentInChildren<WeaponSwitcher>().enabled = false;
        DisableWeapons();
    }

    private void DisableWeapons()
    {
        Weapon[] weapons = GetComponentsInChildren<Weapon>();
        foreach (Weapon weapon in weapons)
        {
            weapon.enabled = false;
        }
    }
}
