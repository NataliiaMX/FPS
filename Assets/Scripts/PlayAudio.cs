using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    [SerializeField] AudioClip firstTrack;
    [SerializeField] AudioClip secondTrack;
    AudioSource audioSource;

    private void Start() 
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine("ChangeAudio");
    }

    IEnumerator ChangeAudio ()
    {
        audioSource.clip = firstTrack;
        audioSource.Play();
        yield return new WaitForSeconds(firstTrack.length);
        audioSource.clip = secondTrack;
        audioSource.Play();
    }
}
