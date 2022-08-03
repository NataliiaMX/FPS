using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    [SerializeField] Canvas gameOverCanvas;
    [SerializeField] GameObject gun;
    private void Start() 
    {
        gameOverCanvas.enabled = false;
    }

    public void HandleDeath ()
    {
        gameOverCanvas.enabled = true;
        Time.timeScale = 0; // "stops" time
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        gun.SetActive(false);
    }
}
