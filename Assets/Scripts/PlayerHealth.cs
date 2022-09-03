using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float playerHP = 100;
    [SerializeField] TextMeshProUGUI hpText;
   
    bool isDead = false;

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
        GetComponent<DisplayDamage>().ShowDamageImpcat();
        playerHP -= damagePoints;

        if (playerHP <= 0)
        {
            isDead = true;
            GetComponent<GameOverHandler>().HandleGameOver(isDead);
        }
    }
}
