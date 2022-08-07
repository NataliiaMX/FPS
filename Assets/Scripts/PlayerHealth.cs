using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float playerHP = 100;

    public void TakeDamage (float damagePoints)
    {
        playerHP -= damagePoints;

        if (playerHP <= 0)
        {
            GetComponent<DeathHandler>().HandleDeath();
        }
    }
}
