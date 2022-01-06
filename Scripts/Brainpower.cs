using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brainpower : MonoBehaviour
{
    public float brainpower;
    public bool brainpower_used;
    public float timer;
    public float recharge;
    public float cost = 1.5f;
    public Animator animator;
    public AudioSource a_s;

    public gamemanager mygamemanagerScript;

    void Start()
    {
        a_s = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        recharge = 3f;
    }

    void Update()
    { 

        if(mygamemanagerScript.platformMovementEnabled == true)
        {
            Brainpower_Activated();
        }

        else
        {
            brainpower_used = false;
            animator.SetBool("Activated", false);
        }

        if(brainpower == 100)
        {
            timer = 0f;
        }

        if(brainpower <= 0)
        {
            mygamemanagerScript.Respawn();
        }
    }

    void FixedUpdate()
    {
        if(brainpower_used == false)
        {
           Reload();
        }
    }

    void Reload()
    {
        a_s.Play();
        timer +=  0.016f;
        if(timer >= 0.5f && brainpower_used == false)
        {
            brainpower += Mathf.Sqrt(recharge * Time.deltaTime);
            if(brainpower >= 100)
            {
                brainpower = 100f;
            }
        }
    }

    void Brainpower_Activated()
    {
        brainpower -= Mathf.Sqrt(cost * Time.deltaTime);
        brainpower_used = true;
        timer = 0f;
        animator.SetFloat("Brainpower", brainpower);
        animator.SetBool("Activated", true);
    }
}