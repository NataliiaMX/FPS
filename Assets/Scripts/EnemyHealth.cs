using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;
    public void TakeDamage (float damagePoints)
    {
        // GetComponent<EnemyAI>().OnDamageTaken();
        BroadcastMessage("OnDamageTaken"); // Every script attached to the game object and all its children that has this method will be called.
        hitPoints -= damagePoints;
        Debug.Log(hitPoints);

        if (hitPoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
