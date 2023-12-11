using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonTrigger : MonoBehaviour
{
    public GameObject upgrade3;
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="enemies")
        {
            upgrade3.SetActive(true);
        }
    }
}
