using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_RedCube : MonoBehaviour {

    public GameObject FPS_Cam;
    public GameObject Door;
    public Animator doorOpening;

    private bool hasEntered = false;

    void Start()
    {
        doorOpening = Door.GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider c) {
        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.FIRST_RUN){
            if (!hasEntered)
            {
                FPS_Cam.GetComponent<ShaderEffect_BleedingColors>().enabled = true;
                Debug.Log(GameStateManager.CURRENTSTATE + " COLLISION RED");
            }
        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.FIRST_RUN) {
            FPS_Cam.GetComponent<ShaderEffect_BleedingColors>().enabled = false;
            hasEntered = true;
            doorOpening.enabled = true;
            this.GetComponent<Collision_RedCube>().enabled = false;
        }
    }
}


