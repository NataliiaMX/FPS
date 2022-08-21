using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHPIncreaser : MonoBehaviour
{
    [SerializeField] PlayerHealth playerHealth;
    float healthIncrement = 3f;

    private void OnCollisionEnter(Collision other) 
    {
        playerHealth.IncreaseHealth(healthIncrement);
        Destroy(gameObject);
    }
}
