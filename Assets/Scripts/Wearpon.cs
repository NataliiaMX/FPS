using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Wearpon : MonoBehaviour
{
    [SerializeField] Camera fpCamera;
    [SerializeField] ParticleSystem gunFireVFX;
    [SerializeField] GameObject hitVFX;
    [SerializeField] float range = 30f;
    [SerializeField] float damagePoints = 40f;
    [SerializeField] Ammo ammoSlot;
    [SerializeField] AmmoType ammoType;
    [SerializeField] TextMeshProUGUI ammoDisplay;
    bool canIShoot = true;
    float timeBetweenSHots = 0.1f;

    private void OnEnable() 
    {
        canIShoot = true;    
    }

    private void Start()
    {
        ammoSlot = FindObjectOfType<Ammo>();
        GetComponent<AudioSource>().enabled = false;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && canIShoot == true)
        {
           StartCoroutine("Shoot"); 
        }

        DisplayAmmo();
        
    }

    private void DisplayAmmo()
    {
        ammoDisplay.text = ammoSlot.GetCurrentAmmo(ammoType).ToString();
    }

    IEnumerator Shoot()
    {
        canIShoot = false;
        if (ammoSlot.GetCurrentAmmo(ammoType) > 0)
        {
            StartCoroutine("PlaySFX");
            ProcessRaycast();
            ammoSlot.ReduceCurrentAmmo(ammoType);
        }
        yield return new WaitForSeconds(timeBetweenSHots);
        canIShoot = true;
    }

    IEnumerator PlaySFX ()
    {
        GetComponent<AudioSource>().enabled = true;
        yield return new WaitForSeconds(timeBetweenSHots);
        GetComponent<AudioSource>().enabled = false;
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
