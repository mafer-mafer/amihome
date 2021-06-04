using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyLightsGlowing : MonoBehaviour
{
    public Light Bunny_Light;
    public Light Vanity_Light;
    public Light Desk_Light;

    public GameObject DoorClose;
    public GameObject DoorOpen;

    public float BunnyLightIntensity;
    public float VanityLightIntensity;
    public float DeskLightIntensity;

    public GameObject lights_sfx;
    public GameObject door_unlock_sfx;
    private bool hasEntered = false;

    void Start()
    {
        Bunny_Light.GetComponent<Light>();
        Vanity_Light.GetComponent<Light>();
        Desk_Light.GetComponent<Light>();
        DoorClose.SetActive(true);
        DoorOpen.SetActive(false);
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.FIRST_RUN)
        {
            if (!hasEntered)
            {
                Bunny_Light.intensity = BunnyLightIntensity;
                Vanity_Light.intensity = VanityLightIntensity;
                Desk_Light.intensity = DeskLightIntensity;
                DoorClose.SetActive(false);
                DoorOpen.SetActive(true);
                lights_sfx.SetActive(true);
                Invoke("UnlockDoor", 1.5f);
            }
        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.CompareTag("Player") && GameStateManager.CURRENTSTATE == GameStateManager.GameState.FIRST_RUN)
        {
            Bunny_Light.intensity = .4f;
            Vanity_Light.intensity = .4f;
            Desk_Light.intensity = .4f;
            hasEntered = true;
            this.GetComponent<BunnyLightsGlowing>().enabled = false;
        }
    }

    void UnlockDoor(){
        door_unlock_sfx.SetActive(true);
    }
}
