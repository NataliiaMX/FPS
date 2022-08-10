using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wearpon : MonoBehaviour
{
    [SerializeField] Camera fpCamera;
    [SerializeField] ParticleSystem gunFireVFX;
    [SerializeField] GameObject hitVFX;
    [SerializeField] float range = 30f;
    [SerializeField] float damagePoints = 40f;
    [SerializeField] Ammo ammoSlot;

    private void Start()
    {
        ammoSlot = FindObjectOfType<Ammo>();
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        if (ammoSlot.GetCurrentAmmo() > 0)
        {
            ProcessRaycast();
            ammoSlot.ReduceCurrentAmmo();
        }
        else
        {
            Debug.Log("out of ammo");
            return;
        }
    }

    private void ProcessRaycast()
    {

        RaycastHit hit;
        if (Physics.Raycast(fpCamera.transform.position, fpCamera.transform.forward, out hit, range))
        {
            gunFireVFX.Play();
            CreateHitImpact(hit);
            EnemyHealth1 target = hit.transform.GetComponent<EnemyHealth1>();
            target?.TakeDamage(damagePoints); //if target !=null
        }
        else
        {
            return;
        }
    }

    private void CreateHitImpact(RaycastHit hit)
    {
        GameObject impact = Instantiate(hitVFX, hit.point, Quaternion.LookRotation(hit.normal));
        Destroy(impact, .1f);
    }
}
