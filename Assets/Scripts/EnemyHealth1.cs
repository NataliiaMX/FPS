using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyHealth1 : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;
    bool isDead = false;
    public bool IsDead() { return isDead; }

    public void TakeDamage(float damage)
    {
        BroadcastMessage("OnDamageTaken");
        hitPoints -= damage;
        if (hitPoints <= 0)
        {
            if (isDead) return;
            isDead = true;
            GetComponent<Animator>().SetTrigger("Dead");
        }
    }

    public void DestroyObjectEvent ()
    {
        Destroy(gameObject);
    }
}
