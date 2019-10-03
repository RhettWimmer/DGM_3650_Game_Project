using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
 void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name == "Tester")
        {
            Debug.Log("HELLLLLLLLLLOOO");
        }
    }
}
