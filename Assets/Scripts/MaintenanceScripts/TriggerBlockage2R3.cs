using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBlockage2R3 : MonoBehaviour {

    public GameObject Blockage1;

    void OnTriggerEnter(Collider c)
    {
        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.THIRD_RUN)
        {
            Blockage1.SetActive(false);
        }
    }
}
