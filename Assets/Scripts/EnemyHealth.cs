using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;
    public void TakeDamage (float damagePoints)
    {
        hitPoints -= damagePoints;
        Debug.Log(hitPoints);

        if (hitPoints <= 0)
        {
            Destroy(gameObject);
            hitPoints = 100;
        }
    }
}
