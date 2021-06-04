using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsLerp : MonoBehaviour {

    public float speed = 1.0f;
    float startTime;
    public bool repeatable = false;

    public Color startColor1;
    public Color endColor1;
    public Color startColor2;
    public Color endColor2;
    public Color startColor3;
    public Color endColor3;
    public Color startColor4;
    public Color endColor4;
    public Color startColor5;
    public Color endColor5;

    //YellowWalls
    public GameObject Wall1;
    //LavenderWalls
    public GameObject Wall20;
    public GameObject Wall21;
    public GameObject Wall22;
    public GameObject Wall23;
    //PinkWalls
    public GameObject Wall31;
    public GameObject Wall32;

    public GameObject Floor;
    public GameObject Ceiling;
         
    public bool ifCollided = false;

    public GameObject BunnyForestScene;
    public GameObject Door2Close;
    public GameObject Door2Open;
    public GameObject staticSound;
    public GameObject lerpSFX;

    private bool hasEntered = false;

    Color Lerping1;

    void Start () {
        startTime = Time.time;
    }

    private void Update()
    {
        if (ifCollided == true)
        {
            if (!repeatable)
            {
                float t = (Time.time - startTime) * speed;
                Wall1.GetComponent<Renderer>().material.color = Color.Lerp(startColor1, endColor1, t);

                Wall20.GetComponent<Renderer>().material.color = Color.Lerp(startColor2, endColor2, t);
                Wall21.GetComponent<Renderer>().material.color = Color.Lerp(startColor2, endColor2, t);
                Wall22.GetComponent<Renderer>().material.color = Color.Lerp(startColor2, endColor2, t);
                Wall23.GetComponent<Renderer>().material.color = Color.Lerp(startColor2, endColor2, t);

                Wall31.GetComponent<Renderer>().material.color = Color.Lerp(startColor3, endColor3, t);
                Wall32.GetComponent<Renderer>().material.color = Color.Lerp(startColor3, endColor3, t);

                Floor.GetComponent<Renderer>().material.color = Color.Lerp(startColor4, endColor4, t);
                Ceiling.GetComponent<Renderer>().material.color = Color.Lerp(startColor5, endColor5, t);
            }
            else
            {
                float t = (Mathf.Sin(Time.time - startTime) * speed);
                Wall1.GetComponent<Renderer>().material.color = Color.Lerp(startColor1, endColor1, t);

                Wall20.GetComponent<Renderer>().material.color = Color.Lerp(startColor2, endColor2, t);
                Wall21.GetComponent<Renderer>().material.color = Color.Lerp(startColor2, endColor2, t);
                Wall22.GetComponent<Renderer>().material.color = Color.Lerp(startColor2, endColor2, t);
                Wall23.GetComponent<Renderer>().material.color = Color.Lerp(startColor2, endColor2, t);

                Wall31.GetComponent<Renderer>().material.color = Color.Lerp(startColor3, endColor3, t);
                Wall32.GetComponent<Renderer>().material.color = Color.Lerp(startColor3, endColor3, t);

                Floor.GetComponent<Renderer>().material.color = Color.Lerp(startColor4, endColor4, t);
                Ceiling.GetComponent<Renderer>().material.color = Color.Lerp(startColor5, endColor5, t);
            }
        }
    }

    void OnTriggerEnter(Collider c)
    {
        if (!hasEntered)
        {
            if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.SECOND_RUN)
            {
                ifCollided = true;
                BunnyForestScene.SetActive(false);
                staticSound.SetActive(false);
                lerpSFX.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.SECOND_RUN)
        {
            Door2Open.SetActive(false);
            Door2Close.SetActive(true);
            hasEntered = true;
        }
    }
}
        