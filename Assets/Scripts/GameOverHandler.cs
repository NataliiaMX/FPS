using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverHandler : MonoBehaviour
{
    [SerializeField] Canvas youreDeadCanvas;
    [SerializeField] Canvas gameOverCanvas;
    [SerializeField] GameObject gun;
    private void Start() 
    {
        youreDeadCanvas.enabled = false;
        gameOverCanvas.enabled = false;
    }

    public void HandleGameOver (bool isDead)
    {
        if (isDead)
        {
            youreDeadCanvas.enabled = true;
        }
        else
        {
            gameOverCanvas.enabled = true;
        }
        Time.timeScale = 0; // "stops" time
        FindObjectOfType<WearponSwitcher>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        gun.SetActive(false);
    }
}
