using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalHomeTrigger : MonoBehaviour
{
    bool isDead = false;
    private void OnTriggerEnter(Collider other) 
    {
        GetComponent<GameOverHandler>().HandleGameOver(isDead);
    }
}
