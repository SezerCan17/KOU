using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ses : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource talk;
    public AudioSource cim;

    void Start()
    {
        // Eðer "Play On Awake" seçeneði iþaretli deðilse:
        audioSource.Play();
    }

    public void talk_()
    {
        talk.Play();
    }

    public void cim_()
    {
        cim.Play();
    }
}
