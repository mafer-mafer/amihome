using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameQuit : MonoBehaviour {


    void OnTriggerEnter(Collider c)
    {
     if (c.CompareTag("MiniHouse"))
        {
            Application.Quit();
        }
    }
}
