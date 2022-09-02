using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float playerHP = 100;
    [SerializeField] TextMeshProUGUI hpText;
    bool isDead = true;

    private void Update() 
    {
        DisplayHP();
    }

    private void DisplayHP()
    {
        hpText.text = playerHP.ToString();
    }

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
