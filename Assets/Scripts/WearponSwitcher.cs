using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WearponSwitcher : MonoBehaviour
{
    [SerializeField] int currentWearponIndex = 0;

    private void Start()
    {
        SetWearponActive();
    }

    private void Update() 
    {
        int previousWearpon = currentWearponIndex;

        ProcessKeyInput();    
        ProcessScrollWheelInput();

        if (previousWearpon != currentWearponIndex)
        {
            SetWearponActive();
        }
    }

    private void ProcessScrollWheelInput()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (currentWearponIndex >= transform.childCount - 1)
            {
                currentWearponIndex = 0;
            }
            else 
            {
                currentWearponIndex++;
            }
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (currentWearponIndex >= transform.childCount - 1)
            {
                currentWearponIndex = 0;
            }
            else 
            {
                currentWearponIndex++;
            }
        }
    }

    private void ProcessKeyInput()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentWearponIndex = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentWearponIndex = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentWearponIndex = 2;
        }
    }

    private void SetWearponActive()
    {
        int wearponIndex = 0;
        foreach (Transform wearpon in transform)
        {
            if (wearponIndex == currentWearponIndex)
            {
                wearpon.gameObject.SetActive(true);
            }
            else 
            {
                wearpon.gameObject.SetActive(false);
            }
            wearponIndex++;
        }
    }
}
