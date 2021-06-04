using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorStart : MonoBehaviour{

    Animator doorOpens;

    void Start()
    {
        doorOpens = gameObject.GetComponent<Animator>();
        doorOpens.enabled = false;
    }
}
