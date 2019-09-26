using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorMachine : MonoBehaviour
{
    public GameObject RunAnim;
    public GameObject StopAnim;

    public bool Running;
    public bool Jumping;


    private void Update()
    {
        if (Running == true && Jumping == false)
        {
            RunAnim.SetActive(true);
            StopAnim.SetActive(false);
        }

        if (Jumping == true && Running == false)
        {
            RunAnim.SetActive(false);
            StopAnim.SetActive(true);
        }
        
        print(Running);
        print(Jumping);
    }
}
