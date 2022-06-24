using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentManagerScript : MonoBehaviour
{
    public static bool BlockAncEnabled = true, LockAncEnabled = true, RedAncEnabled = true, GreenAncEnabled = false;
    public static bool BlockLateEnabled = true, LockLateEnabled = true, RedLateEnabled = true, GreenLateEnabled = false;
    public static bool BlockModEnabled = true, LockModEnabled = true, RedModEnabled = true, GreenModEnabled = false;
    public GameObject BlockAnc, LockAnc, RedAnc, GreenAnc;
    public GameObject BlockLate, LockLate, RedLate, GreenLate;
    public GameObject BlockMod, LockMod, RedMod, GreenMod;

    private void Awake()
    {
        BlockAnc.SetActive(BlockAncEnabled);
        LockAnc.SetActive(LockAncEnabled);
        RedAnc.SetActive(RedAncEnabled);
        GreenAnc.SetActive(GreenAncEnabled);

        BlockLate.SetActive(BlockLateEnabled);
        LockLate.SetActive(LockLateEnabled);
        RedLate.SetActive(RedLateEnabled);
        GreenLate.SetActive(GreenLateEnabled);

        BlockMod.SetActive(BlockModEnabled);
        LockMod.SetActive(LockModEnabled);
        RedMod.SetActive(RedModEnabled);
        GreenMod.SetActive(GreenModEnabled);
    }
}
