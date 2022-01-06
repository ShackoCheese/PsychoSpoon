using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesObject : MonoBehaviour
{
    public gamemanager gm;
    [SerializeField]
    public GameObject Player;
    [SerializeField]
    public GameObject Spike;

    public Animator am;
    public Animator slider_anim;
    public float Somatimer = 0f;
    public bool Timeractive;
    public float downtime;
    public AudioSource a_s;

    void awake()
    {
        am = GetComponent<Animator>();
        a_s = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(Input.GetKeyDown("e"))
        {
            Timeractive = true;
            a_s.Pause();
            Spike.SetActive(false); 
            am.SetFloat("Active", 0);
            slider_anim.SetFloat("Activate", 1);
        }

        if(Timeractive == true)
        {
            Somatimer = Somatimer + 0.01f; 
        }

        if(Somatimer >= downtime)
        {
            Somatimer = 0f;
            Timeractive = false;
            Spike.SetActive(true);
            am.SetFloat("Active", 1);
            slider_anim.SetFloat("Activate", 0); 
            a_s.PlayDelayed(1);
        }
    }
}
