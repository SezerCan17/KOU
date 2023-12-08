using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookReading : MonoBehaviour
{
    public bool isOpen;
    public Animator animator;

    public void OpenBook()
    {
        if(!isOpen) 
        {
            isOpen = true;
            Debug.Log("new skill learning");
            //animator.SetBool("IsOpen",isOpen);
        }
    }
}
