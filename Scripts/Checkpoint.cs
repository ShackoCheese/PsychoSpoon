using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public gamemanager mygamemanagerScript;
    public Animator myAnimator;
    public ParticleSystem ps;
    public ParticleSystem activatedps;
    public AudioSource a_s;
    public bool activeted;
    private void Start()
    {
        myAnimator = GetComponent<Animator>();
        activeted = false;
        a_s = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D box)
    {
        if(box.CompareTag("Player") && activeted == false)
        {
            a_s.Play();
            mygamemanagerScript.Checkpoint = mygamemanagerScript.Checkpoint_GameObject.transform.position;
            myAnimator.SetFloat("active", 1);
            ps.Play();
            activeted = true;
            activatedps.Play();
        }
    }
}
