using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BambuCollect : MonoBehaviour
{
    public GameObject bambu_UI;
    public GameObject bambu;
    private bool temasvar;
    // Start is called before the first frame update
    void Start()
    {
        temasvar = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            collect_Bambu();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="player")
        {
            temasvar = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            temasvar = false;
        }
    }

    public void collect_Bambu()
    {
        if(temasvar)
        {
            bambu.SetActive(false);
            bambu_UI.SetActive(true);
        }
    }
}
