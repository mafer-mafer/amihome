using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopFPSMovement : MonoBehaviour
{

    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController controller;
    public float TimeUntilAnimationEnds;

    public float walkspeed;
    public float runspeed;

    public void Start()
    {
        Invoke("StopFPC", TimeUntilAnimationEnds);
    }

    public void StopFPC()
    {
        controller.m_WalkSpeed = walkspeed;
        controller.m_RunSpeed = runspeed;
    }
}