using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorsBedroom : MonoBehaviour {

    public GameObject Door2Close;
    public GameObject Door2Open;
    public GameObject Door3Close;
    public GameObject Door3Open;
    public GameObject Door4Close;
    public GameObject Door4Open;

    private bool hasEntered = false;

    void OnTriggerEnter(Collider c)
    {
        if (!hasEntered)
        {
            if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.THIRD_RUN)
            {
                
                Door2Close.SetActive(true);
                Door2Open.SetActive(false);
                Door3Close.SetActive(false);
                Door3Open.SetActive(true);
                Door4Close.SetActive(false);
                Door4Open.SetActive(true);
                Debug.Log("doors");

                Debug.Log("DoorsOpen");
            }
        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.THIRD_RUN)
        {
            hasEntered = true;
            this.GetComponent<DoorsBedroom>().enabled = false;
        }
    }
}
