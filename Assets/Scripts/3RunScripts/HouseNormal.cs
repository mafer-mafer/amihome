using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseNormal : MonoBehaviour {

    public GameObject HouseElong;
    public GameObject Playground;
    public GameObject Swings;

    public float Playground_YYScale;
    public float Swings_YYScale;
    
    private bool hasEntered = false;

    void OnTriggerEnter(Collider c){
        if (!hasEntered)
        {
            if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.THIRD_RUN)
            {
                HouseElong.transform.localScale -= new Vector3(3, 1, 3);
                Playground.transform.localScale -= new Vector3(Playground.transform.position.x, Playground_YYScale, Playground.transform.position.z);
                Swings.transform.localScale -= new Vector3(Swings.transform.position.x, Swings_YYScale, Swings.transform.position.z);
            }
        }
    }

    void OnTriggerExit(Collider c){
        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.THIRD_RUN)
        {
            hasEntered = true;
            this.GetComponent<HouseNormal>().enabled = false;
        }
    }
}
