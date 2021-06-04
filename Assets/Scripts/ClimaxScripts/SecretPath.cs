using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretPath : MonoBehaviour {

    public GameObject turnOFF;
    public GameObject turnON;

    private bool hasEntered = false;

    void OnTriggerEnter(Collider c)
    {
        if (!hasEntered)
        {
            if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.THIRD_RUN)
            {
                turnOFF.SetActive(false);
                turnON.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.THIRD_RUN)
        {
            hasEntered = true;
        }
    }
}
