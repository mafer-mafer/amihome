using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MomGrapes : MonoBehaviour {

    public GameObject Door3Close;
    public GameObject Door3Open;
    public GameObject Door4Close;
    public GameObject Door4Open;

    public GameObject momSound;

    public float TimeTilDoorOpens;
    
    private bool hasEntered = false;

    void OnTriggerEnter(Collider c)
    {
        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.SECOND_RUN)
        {
            if (!hasEntered)
            {
                Invoke("DoorsOpen", TimeTilDoorOpens);
                Door3Close.SetActive(true);
                Door3Open.SetActive(false);
                momSound.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.SECOND_RUN)
        {
            momSound.SetActive(false);
            this.GetComponent<MomGrapes>().enabled = false;
        }
    }

    void DoorsOpen(){
        Door4Close.SetActive(false);
        Door4Open.SetActive(true);
    }
}
