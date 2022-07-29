using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wearpon : MonoBehaviour
{
    [SerializeField] Camera fpCamera;
    [SerializeField] float range = 30f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        RaycastHit hit;
        Physics.Raycast(fpCamera.transform.position, fpCamera.transform.forward, out hit, range);
        Debug.Log(hit.transform.name);
    }
}
