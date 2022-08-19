using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRespawn : MonoBehaviour
{
    bool respawnTrigger = false;
    public bool GetRespawnTrigger ()
    {
        return respawnTrigger;
    }

    private void Start() {
        Debug.Log(respawnTrigger);
    }
    private void OnCollisionEnter(Collision other) 
    {
        respawnTrigger = true;
        Debug.Log(respawnTrigger);
        Destroy(gameObject);
    }
}
