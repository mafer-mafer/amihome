using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactersTalking : MonoBehaviour {

    public float lifeTime;
    public float glitchstart;
    public GameObject sfx_glitch1;

    void Start()
    {
        Invoke("Glitched", glitchstart);
        Destroy(gameObject, lifeTime);
    }

    void Glitched(){
        sfx_glitch1.SetActive(true);
    }
}
