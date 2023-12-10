using UnityEngine;

public class Upgrade4 : MonoBehaviour
{
    public GameObject upgrade4;
    public GameObject bambuUI;
    public Weapon3 weapon3;
    public bool temasvar;
    // Start is called before the first frame update
    void Start()
    {
        temasvar = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
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
            upgrade4.SetActive(true);
            weapon3.enabled = true;
        }
    }
}