using UnityEngine;

public class Upgrade3 : MonoBehaviour
{
    public GameObject upgrade3;
    public GameObject bambuUI;
    public Weapon weapon;
    public bool temasvar;
    public AudioSource talk;
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
        if (upgrade3.activeSelf)
        {
            Debug.Log("TalkBaþladý");
            talk.Play();
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
            bambuUI.SetActive(false);
            weapon.enabled = true;
        }
    }
}