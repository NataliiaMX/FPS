using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    [SerializeField] AmmoSlot[] ammoSlot;
    [System.Serializable]
    private class AmmoSlot
    {
        public AmmoType ammoType;
        public int ammoAmount;
    }
    public int GetCurrentAmmo ()
    {
        return 100;
    }

    public void ReduceCurrentAmmo()
    {
        int i = 100;
        i--;
    }
}
