using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorsHouseClose1 : MonoBehaviour {

    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController controller;
    public float walkspeed1;

    public GameObject Door1Open;
    public GameObject Door1Close;
    public GameObject Door2Open;
    public GameObject Door2Close;
    public GameObject Door3Open;
    public GameObject Door3Close;
    public GameObject Door4Open;
    public GameObject Door4Close;

    public GameObject Spotlight;
    public GameObject BunnyOnSwings;
    public GameObject TinyMom;

    public GameObject Blockage1;
    public GameObject ForestSFX;
    public float runspeed;

    void OnTriggerEnter(Collider c)
    {
        if (c.CompareTag("Player"))
        {
            Door1Close.SetActive(true);
            Door2Close.SetActive(true);
            Door3Close.SetActive(true);
            Door4Close.SetActive(true);
            Door1Open.SetActive(false);
            Door2Open.SetActive(false);
            Door3Open.SetActive(false);
            Door4Open.SetActive(false);
            Blockage1.SetActive(true);
            ForestSFX.SetActive(true);

            controller.m_WalkSpeed = walkspeed1;
            controller.m_RunSpeed = runspeed;

            if (GameStateManager.CURRENTSTATE == GameStateManager.GameState.SECOND_RUN) {
                Spotlight.SetActive(false);
                TinyMom.SetActive(false);
                BunnyOnSwings.SetActive(true);
            }
        }
    }
}
