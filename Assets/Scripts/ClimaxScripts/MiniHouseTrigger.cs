using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniHouseTrigger : MonoBehaviour
{
    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController controller;

    public GameObject MiniHouse;
    public GameObject SparkleSFX;
    public float animGameEndSpeedLength;
    
    void OnTriggerEnter(Collider c)
    {
        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.THIRD_RUN)
        {
            controller.m_WalkSpeed = 0f;
            MiniHouse.SetActive(true);
            SparkleSFX.SetActive(true);
            Invoke("gameEnd", animGameEndSpeedLength);
        }
    }

    void gameEnd (){
        Application.Quit();
    }
}
