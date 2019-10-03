using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PassengerAnimations : MonoBehaviour
{
    public Animator animator;
    private void Update()
    {
        animator.SetBool("Walk", true);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "sitLoc")
        {
            //animator.SetBool("Walk", false);
            Debug.Log("Working");
        }
    }
}
