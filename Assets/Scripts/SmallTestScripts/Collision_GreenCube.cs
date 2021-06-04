using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_GreenCube : MonoBehaviour {


    public float xScale;
    public float yScale;
    public float zScale;

    float time = 3.0f;
    
    public GameObject Door;
    public Animator doorOpening;

    private bool hasEntered = false;


    void Start()
    {
        doorOpening = Door.GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider c)
    {
        if (!hasEntered){
            if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.FIRST_RUN)
            {
                time -= Time.deltaTime;
                transform.localScale += new Vector3(xScale, yScale, zScale);
                Debug.Log("GREEN COLLIDED");
            }
        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.FIRST_RUN)
        {
            time -= Time.deltaTime;
            transform.localScale -= new Vector3(1, 1, 1);
            hasEntered = true;
            doorOpening.enabled = true;
            this.GetComponent<Collision_GreenCube>().enabled = false;
        }
    }
}