using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class run2sfx : MonoBehaviour {

    public GameObject sound_sfx;
    private bool hasEntered = false;

    void OnTriggerEnter(Collider c)
    {
        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.SECOND_RUN)
        {
            if (!hasEntered)
            {
                sound_sfx.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.SECOND_RUN)
        {
            hasEntered = true;
            this.GetComponent<run2sfx>().enabled = false;
        }
    }
}
