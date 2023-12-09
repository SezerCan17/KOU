using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookReading : MonoBehaviour
{
    public bool isOpen;
    public Animator animator;
 //   private LearnSkill learn;
	//void Update()
	//{
	//	if(learn.onbook == true)
 //       {
	//		GetComponent<Collider2D>().enabled = false;
	//	}
	//}
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
