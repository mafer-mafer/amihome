using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextGameState : MonoBehaviour
{
    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController controller;

    public Glitch1Trigger Glitch1;
    public EyesTrigger ForestEyes;

    public GameObject Blockage3;

    public AudioSource theme_song;
    public float secondPitch = .9f;
    public float thirdPitch = .8f;

    public float walkspeed_inside;
    public float walkspeed_inside2;
    public float runspeed;
    public float runspeed2;
    public GameObject forestSFX;


    void Start()
    {
        theme_song = theme_song.GetComponent<AudioSource>();
    }

    void OnTriggerExit(Collider c)
    {
        Blockage3.SetActive(false);

        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.FIRST_RUN && Glitch1.SecondRunAble == true)
        {
            GameStateManager.CURRENTSTATE = GameStateManager.GameState.SECOND_RUN;
            theme_song.pitch = secondPitch;
            controller.m_WalkSpeed = walkspeed_inside;
            controller.m_RunSpeed = runspeed;
            forestSFX.SetActive(false);
        }
        else if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.SECOND_RUN && ForestEyes.ThirdRunAble == true)
        {
            GameStateManager.CURRENTSTATE = GameStateManager.GameState.THIRD_RUN;
            theme_song.pitch = thirdPitch;
            controller.m_WalkSpeed = walkspeed_inside2;
            controller.m_RunSpeed = runspeed2;
            forestSFX.SetActive(false);
        }
    }
}
