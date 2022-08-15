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
    bool canIShoot = true;
    float timeBetweenSHots = 2f;

    private void OnEnable() 
    {
        canIShoot = true;    
    }

    private void Start()
    {
        ammoSlot = FindObjectOfType<Ammo>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && canIShoot == true)
        {
           StartCoroutine("Shoot"); 
        }
        
    }

    IEnumerator Shoot()
    {
        canIShoot = false;
        if (ammoSlot.GetCurrentAmmo() > 0)
        {
            ProcessRaycast();
            ammoSlot.ReduceCurrentAmmo();
        }
        yield return new WaitForSeconds(timeBetweenSHots);
        canIShoot = true;
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
