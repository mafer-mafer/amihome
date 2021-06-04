using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyOnTV : MonoBehaviour {

    public GameObject OldTvPlane;
    public GameObject BunnyForestScene;

    public GameObject Door2Close;
    public GameObject Door2Open;
    public GameObject Door1Close;
    public GameObject Door1Open;

    public GameObject MomStanding;
    public GameObject BunnyOnBed;
    public GameObject NewMainWall;

    public GameObject staticSound;
    private bool hasEntered = false;
    
    void Start()
    {
        BunnyForestScene.SetActive(false);
    }

    void OnTriggerEnter(Collider c)
    {
        if (!hasEntered)
        {
            if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.SECOND_RUN)
            {
                OldTvPlane.SetActive(false);
                BunnyForestScene.SetActive(true);
                Door1Close.SetActive(true);
                Door1Open.SetActive(false);
                Debug.Log("CollidedforTV");
                MomStanding.SetActive(false);
                BunnyOnBed.SetActive(false);
                NewMainWall.SetActive(true);
                staticSound.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.SECOND_RUN)
        {
            Door2Close.SetActive(false);
            Door2Open.SetActive(true);
            hasEntered = true;
        }
    }
}
