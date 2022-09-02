using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRespawn : MonoBehaviour

{
    [SerializeField] Canvas sealIsBrokenCanvas;
    float destroyTime  = 1.5f;
    bool respawnTrigger = false;
    private void Start() 
    {
        sealIsBrokenCanvas.enabled = false;
    }
    public bool GetRespawnTrigger ()
    {
        return respawnTrigger;
    }
    private void OnCollisionEnter(Collision other) 
    {
        respawnTrigger = true;
        sealIsBrokenCanvas.enabled = true;
        Invoke("DisableCanvas", destroyTime);
        gameObject.SetActive(false);
    }

    private void DisableCanvas ()
    {
       sealIsBrokenCanvas.enabled = false;
    }
}
