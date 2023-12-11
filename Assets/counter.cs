using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class counter : MonoBehaviour
{
    
    public bool check;
    public int say=0;
    [SerializeField] TMP_Text text;

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.CompareTag("treebullet"))
        {
            check = true;
            
        }
    }
    private void OnTriggerExit2D(Collider2D collider2D)
    {
        if (collider2D.CompareTag("treebullet"))
        {
            check = false;
        }
    }

    public void _counter()
    {
        say++;
        text.text = "Target:" + say +"/14";
        if(say==14)
        {
            
        }
         
    }




}
