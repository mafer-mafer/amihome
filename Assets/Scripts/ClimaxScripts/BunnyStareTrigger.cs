using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyStareTrigger : MonoBehaviour
{

    Animator _1_BunnyWave;
    Animator _2_BunnyWave;
    Animator _3_BunnyWave;
    Animator _4_BunnyWave;
    Animator _5_BunnyWave;
    Animator _6_BunnyWave;
    Animator _7_BunnyWave;
    Animator _8_BunnyWave;

    public GameObject Bunny1;
    public GameObject Bunny2;
    public GameObject Bunny3;
    public GameObject Bunny4;
    public GameObject Bunny5;
    public GameObject Bunny6;
    public GameObject Bunny7;
    public GameObject Bunny8;

    public GameObject bunnyWaveSFX;
    public float lifeTime = 1.5f;

    private bool hasEntered = false;

    void Start()
    {
        _1_BunnyWave = Bunny1.GetComponent<Animator>();
        _2_BunnyWave = Bunny2.GetComponent<Animator>();
        _3_BunnyWave = Bunny3.GetComponent<Animator>();
        _4_BunnyWave = Bunny4.GetComponent<Animator>();
        _5_BunnyWave = Bunny5.GetComponent<Animator>();
        _6_BunnyWave = Bunny6.GetComponent<Animator>();
        _7_BunnyWave = Bunny7.GetComponent<Animator>();
        _8_BunnyWave = Bunny8.GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.CompareTag("Player"))
        {
            if (!hasEntered)
            {
                _1_BunnyWave.SetTrigger("Wave");
                _2_BunnyWave.SetTrigger("Wave");
                _3_BunnyWave.SetTrigger("Wave");
                _4_BunnyWave.SetTrigger("Wave");
                _5_BunnyWave.SetTrigger("Wave");
                _6_BunnyWave.SetTrigger("Wave");
                _7_BunnyWave.SetTrigger("Wave");
                _8_BunnyWave.SetTrigger("Wave");

                bunnyWaveSFX.SetActive(true);
                Destroy(bunnyWaveSFX, lifeTime);
            }
        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.CompareTag("Player"))
        {
            hasEntered = true;
            this.GetComponent<BunnyStareTrigger>().enabled = false;
        }
    }

}