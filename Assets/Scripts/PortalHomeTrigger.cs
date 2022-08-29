using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalHomeTrigger : MonoBehaviour
{
    bool isDead = false;
    private void OnTriggerEnter(Collider other) 
    {
        Debug.Log("game over");
        GetComponent<GameOverHandler>().HandleGameOver(isDead);
    }
}
