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
        // E�er "Play On Awake" se�ene�i i�aretli de�ilse:
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
