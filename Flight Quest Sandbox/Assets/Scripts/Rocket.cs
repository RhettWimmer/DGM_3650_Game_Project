using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public int moveSpeed;
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            var move = Time.deltaTime * moveSpeed;
            transform.Translate(0, 10, 0);
        }      
    }
}
