using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderTrigger : MonoBehaviour
{
   [SerializeField] GameObject magicLadder;
   [SerializeField] Quaternion quaternion;
   Vector3 magicLadderPosition;
   bool isTriggered = false;
   private void Start() 
   {
        magicLadderPosition = new Vector3(0f, 0f, 0f);
   }

   private  void OnCollisionEnter(Collision other)
   {
        isTriggered = true;
        Instantiate(magicLadder, magicLadderPosition, quaternion); 
        Debug.Log(isTriggered);
   }
}
