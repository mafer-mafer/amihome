using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBlockage1 : MonoBehaviour {

    public GameObject Blockage1;
    public GameObject Blockage2;
    public GameObject Blockage3;

    void OnTriggerEnter(Collider c)
    {
        if (c.CompareTag("Player"))
        {
            Blockage1.SetActive(true);
            Blockage2.SetActive(false);
            Blockage3.SetActive(false);
        }
    }
}
