using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderTrigger : MonoBehaviour
{
    [SerializeField] GameObject magicLadder;
    [SerializeField] Quaternion quaternion;
    Vector3 magicLadderPosition;
    bool needsTrigger = true;
    private void Start()
    {
        magicLadderPosition = new Vector3(174.432098f,0,397.597504f);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (needsTrigger == true)
        {
          Instantiate(magicLadder, magicLadderPosition, quaternion);
          needsTrigger = false;
          Destroy(gameObject);
        }
    }
}
