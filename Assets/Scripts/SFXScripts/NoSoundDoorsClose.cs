using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoSoundDoorsClose : MonoBehaviour {

    public GameObject sound_sfx;
    public GameObject Door3Close;
    public GameObject Door3Open;
    private bool hasEntered = false;

    void OnTriggerEnter(Collider c)
    {
        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.THIRD_RUN)
        {
            if (!hasEntered)
            {
                sound_sfx.SetActive(false);
            }
        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.THIRD_RUN)
        {
            hasEntered = true;
            this.GetComponent<NoSoundDoorsClose>().enabled = false;
        }
    }
}
