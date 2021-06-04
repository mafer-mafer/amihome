using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseElongation : MonoBehaviour {

    public GameObject Door1Close;
    public GameObject Door1Open;
    public float xScale;
    public float yScale;
    public float zScale;

    public float time = 1.0f;
    public GameObject HouseElong;
    private bool hasEntered = false;

    void OnTriggerEnter(Collider c)
    {
        if (!hasEntered)
        {
            if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.THIRD_RUN)
            {
                time -= Time.deltaTime;
                HouseElong.transform.localScale += new Vector3(xScale, yScale, zScale);
                Door1Open.SetActive(false);
                Door1Close.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.THIRD_RUN)
        {
            hasEntered = true;
            this.GetComponent<HouseElongation>().enabled = false;
        }
    }
}
