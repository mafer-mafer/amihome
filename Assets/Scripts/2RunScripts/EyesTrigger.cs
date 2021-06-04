using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyesTrigger : MonoBehaviour {

    public GameObject ForestEyes;

    public GameObject Door1Close;
    public GameObject Door1Open;
    public GameObject Door2Close;
    public GameObject Door2Open;

    public GameObject MomOnTV;
    public GameObject OnTVForMom;

    public GameObject BunntOnSwings;
    public GameObject foresteyesSFX;

    private bool hasEntered = false;
    public bool ThirdRunAble;

    private void Start()
    {
        ForestEyes.SetActive(false);
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.SECOND_RUN)
        {
            if (!hasEntered)
            {
                ForestEyes.SetActive(true);
                foresteyesSFX.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.SECOND_RUN)
        {
            ForestEyes.SetActive(false);
            hasEntered = true;
            Door1Close.SetActive(false);
            Door2Open.SetActive(true);
            Door2Close.SetActive(false);
            Door1Open.SetActive(true);
            ThirdRunAble = true;
            MomOnTV.SetActive(true);
            OnTVForMom.SetActive(true);
            BunntOnSwings.SetActive(false);
            this.GetComponent<EyesTrigger>().enabled = false;
        }
    }
}
