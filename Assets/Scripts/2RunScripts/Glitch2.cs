using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glitch2 : MonoBehaviour {

    public GameObject FPS_Cam;

    public GameObject Door3Close;
    public GameObject Door3Open;

    public GameObject MomTiny;
    public GameObject Spotlight;
    public GameObject Spotlight2;
    public GameObject TopLight;

    public WallsLerp LerpTrigger;
    public GameObject lerpSFX;
    public GameObject glitch2SFX;

    private bool hasEntered = false;

    void OnTriggerEnter(Collider c)
    {
        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.SECOND_RUN)
        {
            if (!hasEntered)
            {
                FPS_Cam.GetComponent<ShaderEffect_CRT>().enabled = true;
                FPS_Cam.GetComponent<ShaderEffectScanner>().enabled = true;
                MomTiny.SetActive(true);
                Spotlight.SetActive(true);
                Spotlight2.SetActive(true);
                TopLight.SetActive(false);
                glitch2SFX.SetActive(true);
                Door3Close.SetActive(false);
                Door3Open.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.SECOND_RUN)
        {
            FPS_Cam.GetComponent<ShaderEffect_CRT>().enabled = false;
            FPS_Cam.GetComponent<ShaderEffectScanner>().enabled = false;
            LerpTrigger.ifCollided = false;
            LerpTrigger.Wall1.GetComponent<Renderer>().material.color = LerpTrigger.startColor1;
            LerpTrigger.Wall20.GetComponent<Renderer>().material.color = LerpTrigger.startColor2;
            LerpTrigger.Wall21.GetComponent<Renderer>().material.color = LerpTrigger.startColor2;
            LerpTrigger.Wall22.GetComponent<Renderer>().material.color = LerpTrigger.startColor2;
            LerpTrigger.Wall23.GetComponent<Renderer>().material.color = LerpTrigger.startColor2;
            LerpTrigger.Wall31.GetComponent<Renderer>().material.color = LerpTrigger.startColor3;
            LerpTrigger.Wall32.GetComponent<Renderer>().material.color = LerpTrigger.startColor3;
            LerpTrigger.Floor.GetComponent<Renderer>().material.color = LerpTrigger.startColor4;
            LerpTrigger.Ceiling.GetComponent<Renderer>().material.color = LerpTrigger.startColor5;
            hasEntered = true;
            glitch2SFX.SetActive(false);
            lerpSFX.SetActive(false);
        }
    }
}
