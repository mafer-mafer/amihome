using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_BlueCube : MonoBehaviour {

    Animator blueExpands;
    //bool Collision1;
    public bool SecondRunAble;

    public GameObject Door;
    public Animator doorOpening;

    private bool hasEntered = false;

    void Start()
    {
        blueExpands = gameObject.GetComponent<Animator>();
        //Collision1 = false;
        doorOpening = Door.GetComponent<Animator>();
    }

    void Update()
    {/*
        if (Collision1 == true)
        {
            blueExpands.SetBool("BlueCollide", true);
        } else if (Collision1 == false)
        {
            blueExpands.SetBool("BlueCollide", false);
        }*/
        
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.FIRST_RUN)
        {
            if (!hasEntered)
            {
                //Collision1 = true;
                blueExpands.SetBool("BlueCollide", true);
                Debug.Log("COLLISION BLUE");
            }
        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.FIRST_RUN)
        {
            //Collision1 = false;
            blueExpands.SetBool("BlueCollide", false);
            SecondRunAble = true;
            Debug.Log("SecondRunAble = " + SecondRunAble);
            doorOpening.enabled = true;
            hasEntered = true;
            this.GetComponent<Collision_BlueCube>().enabled = false;
        }
    }
}
