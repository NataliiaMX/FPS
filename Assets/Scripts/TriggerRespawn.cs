using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRespawn : MonoBehaviour

{
    [SerializeField] Canvas sealIsBrokenCanvas;
    bool respawnTrigger = false;
    float destroyTime  = 1.5f;
    
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
