using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsEverywhereTrigger : MonoBehaviour {


    public GameObject Door2Close;
    public GameObject Door2Open;

    public GameObject NewLights;
    public GameObject RoomFullofItems;
    public GameObject normalHK;
    public GameObject glitchHK;

    public GameObject toysSFX;
    public GameObject tvGLITCH;

    private bool hasEntered = false;

    void OnTriggerEnter(Collider c)
    {
        if (!hasEntered)
        {
            if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.THIRD_RUN)
            {
                NewLights.SetActive(true);
                Door2Close.SetActive(false);
                Door2Open.SetActive(true);
                RoomFullofItems.SetActive(true);
                normalHK.SetActive(false);
                glitchHK.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.THIRD_RUN)
        {
            toysSFX.SetActive(true);
            tvGLITCH.SetActive(false);
            hasEntered = true;
            this.GetComponent<LightsEverywhereTrigger>().enabled = false;
        }
    }
}
