using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float playerHP = 100;
    bool isDead = true;

    public void IncreaseHealth (float hpIncrement)
    {
        playerHP += hpIncrement;
    }

    public void TakeDamage (float damagePoints)
    {
        playerHP -= damagePoints;

        if (playerHP <= 0)
        {
            GetComponent<GameOverHandler>().HandleGameOver(isDead);
        }
    }
}
