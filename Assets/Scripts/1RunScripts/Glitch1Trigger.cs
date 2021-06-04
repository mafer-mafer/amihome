using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glitch1Trigger : MonoBehaviour {

    public GameObject FPS_Cam;

    public GameObject DoorClose;
    public GameObject DoorOpen;

    public GameObject GlitchSFX;

    private bool hasEntered = false;

    public bool SecondRunAble;

    void Start()
    {
        DoorClose.SetActive(true);
        DoorOpen.SetActive(false);
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.FIRST_RUN)
        {
            if (!hasEntered)
            {
                FPS_Cam.GetComponent<ShaderEffect_BleedingColors>().enabled = true;
                FPS_Cam.GetComponent<ShaderEffect_CorruptedVram>().enabled = true;
                GlitchSFX.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.FIRST_RUN)
        {
            FPS_Cam.GetComponent<ShaderEffect_BleedingColors>().enabled = false;
            FPS_Cam.GetComponent<ShaderEffect_CorruptedVram>().enabled = false;
            GlitchSFX.SetActive(false);
            hasEntered = true;
            DoorClose.SetActive(false);
            DoorOpen.SetActive(true);
            SecondRunAble = true;
            this.GetComponent<Glitch1Trigger>().enabled = false;
        }
    }
}
