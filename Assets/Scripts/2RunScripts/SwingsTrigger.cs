using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingsTrigger : MonoBehaviour {

    Animator SwingsAnimator;
 

    public GameObject LeftSwing;

    private bool hasEntered = false;

    void Start () {
        SwingsAnimator = LeftSwing.GetComponent<Animator>();
	}

    void OnTriggerEnter(Collider c)
    {
        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.SECOND_RUN)
        {
            if (!hasEntered)
            {
                SwingsAnimator.SetBool("SwingsStart", true);
                Debug.Log("SwingsTrigger");
            }
        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.SECOND_RUN)
        {
            hasEntered = true;
            this.GetComponent<SwingsTrigger>().enabled = false;
        }
    }
}
