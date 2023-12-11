using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topcounter : MonoBehaviour
{
    public counter count;
    public counter count1;
    public int top = 0;
    // Update is called once per frame
    void Update()
    {
        if (count.check == true || count1.check == true)
        {
            top++;
        }
        count.check = false;
        count1.check = false;
    }
}
