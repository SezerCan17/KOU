using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade2 : MonoBehaviour
{
    public GameObject upgrade2;
    public GameObject bambuUI;
    public Weapon2 weapon2;
    public bool temasvar;
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
            upgrade_();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
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

    public void upgrade_()
    {
        if (temasvar && bambuUI.activeSelf)
        {
            upgrade2.SetActive(true);
            bambuUI.SetActive(false);
            weapon2.enabled = true;
        }
    }
}
