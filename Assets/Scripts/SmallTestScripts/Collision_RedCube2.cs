using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_RedCube2 : MonoBehaviour {

    public GameObject CubeToAppear;

    private bool hasEntered = false;

    void OnTriggerEnter(Collider c) {
        if (!hasEntered){
            if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.SECOND_RUN)
            {
                CubeToAppear.SetActive(true);
                Debug.Log("2ND COLLISION RED");
            }
        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.SECOND_RUN) {
            CubeToAppear.SetActive(false);
            hasEntered = true;
            this.GetComponent<Collision_RedCube2>().enabled = false;

        }
    }
}


