using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glitch3 : MonoBehaviour {

    public GameObject FPS_Cam;
    public GameObject glitch3SFX;
    public GameObject ambienceSFX;
    public GameObject campfireSFX;
    public GameObject themeSong;

    private bool hasEntered = false;

    void OnTriggerEnter(Collider c)
    {
        if (!hasEntered)
        {
            if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.THIRD_RUN)
            {
                FPS_Cam.GetComponent<ShaderEffect_Tint>().enabled = true;
                FPS_Cam.GetComponent<ShaderEffect_BleedingColors1>().enabled = true;
                glitch3SFX.SetActive(true);
                ambienceSFX.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.THIRD_RUN)
        {
            FPS_Cam.GetComponent<ShaderEffect_Tint>().enabled = false;
            FPS_Cam.GetComponent<ShaderEffect_BleedingColors1>().enabled = false;
            glitch3SFX.SetActive(false);
            themeSong.SetActive(false);
            campfireSFX.SetActive(true);
            hasEntered = true;
            this.GetComponent<Glitch3>().enabled = false;
        }
    }
}
