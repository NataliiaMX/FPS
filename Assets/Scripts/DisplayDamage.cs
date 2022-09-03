using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayDamage : MonoBehaviour
{
    [SerializeField] GameObject postProcessingRed;
    float impactTime = 1f;

    private void Start() 
    {
        postProcessingRed.SetActive(false);
    }

    public void ShowDamageImpcat ()
    {
        StartCoroutine(ShowRedEffect());
    }

    IEnumerator ShowRedEffect ()
    {
        postProcessingRed.SetActive(true);
        yield return new WaitForSeconds(impactTime);
        postProcessingRed.SetActive(false);
    }
}
