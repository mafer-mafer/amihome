using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_GreenCubeLerpMaybe : MonoBehaviour {

    //public GameObject FPS_Cam;

    public float xScale;
    public float yScale;
    public float zScale;

    float time = 3.0f;

    private Vector3 originalScale;

    void OnTriggerEnter(Collider c)
    {
        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.FIRST_RUN)
        {
            originalScale = transform.localScale;
            time -= Time.deltaTime;
            transform.localScale += new Vector3(xScale, yScale, zScale);
            Debug.Log("GREEN COLLIDED");
        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.FIRST_RUN)
        {
            time -= Time.deltaTime;
            originalScale = transform.localScale;
            this.GetComponent<Collision_GreenCube>().enabled = false;
        }
    }
}
