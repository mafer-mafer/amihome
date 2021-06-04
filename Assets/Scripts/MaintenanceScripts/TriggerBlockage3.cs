using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBlockage3 : MonoBehaviour {

    public GameObject Blockage1;
    public GameObject Blockage2;
    public GameObject Blockage3;

    void OnTriggerEnter(Collider c)
    {
        if (c.CompareTag("Player"))
        {
            Blockage3.SetActive(true);
            Blockage2.SetActive(false);
            Blockage1.SetActive(false);
        }
    }
}
