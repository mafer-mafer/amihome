using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_RedCube3 : MonoBehaviour
{
    //CHECK IF THIS IS WORKING WITH EARPHONES
    public AudioSource audioSourcee;

    private bool hasEntered = false;

    void Start()
    {
        //audioSourcee.GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider c)
    {
        if (!hasEntered)
        {
            if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.THIRD_RUN)
            {
                //Invoke("StereoSound", 1f);
                audioSourcee.panStereo = 1.0f;
                Debug.Log("3RD COLLISION RED");
            }
        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.THIRD_RUN)
        {
            hasEntered = true;
            audioSourcee.panStereo = 0.0f;
            this.GetComponent<Collision_RedCube3>().enabled = false;
        }
    }

}
    //void StereoSound(){
        // audioSourcee.panStereo { 0.0 ;  -9.0};


    //}


