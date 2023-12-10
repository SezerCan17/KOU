using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipButton : MonoBehaviour
{
    public GameObject UI_;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.O))
        {
            UI_.SetActive(false);
        }
    }
}
