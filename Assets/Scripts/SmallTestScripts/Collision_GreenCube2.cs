using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_GreenCube2 : MonoBehaviour {

    public GameObject ChangeObject;
    public Material oldMaterial;
    public Material newMaterial;

    private bool hasEntered = false;

    void OnTriggerEnter(Collider c)
    {
        if (!hasEntered){
            if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.SECOND_RUN)
            {
                ChangeObject.GetComponent<Renderer>().material = newMaterial;
                Debug.Log("2ND GREEN COLLIDED");
            }
        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.SECOND_RUN)
        {
            ChangeObject.GetComponent<Renderer>().material = oldMaterial;
            hasEntered = true;
            this.GetComponent<Collision_GreenCube2>().enabled = false;
        }
    }
}
