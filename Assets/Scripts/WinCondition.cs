using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    [SerializeField] GameObject[] pool;
    public GameObject[] Pool { get { return pool; } }


    private void Update() 
    {
        CheckIfWon();
    }

    private bool CheckIfPoolHasElements ()
    {
        if (pool.Length == 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    private void CheckIfWon ()
    {
        if (CheckIfPoolHasElements() == true)
        {
            return;
        }
        else 
        {
            Debug.Log("Win");
        }
    }

}
