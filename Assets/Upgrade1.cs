using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade1 : MonoBehaviour
{
    public GameObject upgrade1;
    public GameObject bambuUI;
    public Atack1 attack1;
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
            upgrade1.SetActive(true);
            bambuUI.SetActive(false);
            attack1.enabled = true;
        }
    }
}
