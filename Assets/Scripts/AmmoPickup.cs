using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Ammo ammo;
    [SerializeField] AmmoType ammoType;
    [SerializeField] int ammoIncrease = 5;

    private void Start() 
    {
        ammo = FindObjectOfType<Ammo>();    
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.transform == player)
        {
            ammo.IncreaseAmmo(ammoType, ammoIncrease);
            Destroy(gameObject);
        }
    }
}

