using UnityEngine;

public class Upgrade3 : MonoBehaviour
{
    public GameObject upgrade3;
    public GameObject bambuUI;
    public Weapon weapon;
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
            upgrade3.SetActive(true);
            weapon.enabled = true;
        }
    }
}