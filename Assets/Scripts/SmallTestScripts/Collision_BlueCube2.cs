using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_BlueCube2 : MonoBehaviour{

    public float speed = 1.0f;
    public Color startColor;
    public Color endColor;
    public bool repeatable = false;
    float startTime;

    public GameObject Object2Change;

    public bool ifCollided = false;

    public bool ThirdRunAble;

    private bool hasEntered = false;

    void Start()
    {
        startTime = Time.time;
    }

    private void Update()
    {
        if (ifCollided == true) {
        if (!repeatable)
        {
            float t = (Time.time - startTime) * speed;
            Object2Change.GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColor, t);
        }
        else
        {
            float t = (Mathf.Sin(Time.time - startTime) * speed);
            Object2Change.GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColor, t);
        }
        Debug.Log("2ND COLLISION BLUE");
        }
    }

    void OnTriggerEnter(Collider c)
    {
        if (!hasEntered){
            if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.SECOND_RUN)
            {
                ifCollided = true;
            }
        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.SECOND_RUN)
        {
            ifCollided = false;
            Object2Change.GetComponent<Renderer>().material.color = startColor;
            ThirdRunAble = true;
            Debug.Log("ThirdRunAble = " + ThirdRunAble);
            hasEntered = true;
            this.GetComponent<Collision_BlueCube2>().enabled = false;

        }
    }
}