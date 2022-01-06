using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoost_Moveable : MonoBehaviour
{
    public Animator anim;
    public GameObject gm;
    public AudioSource a_S;

    void Awake()
    {
        gm = GameObject.FindWithTag("GameController");
        a_S = GetComponent<AudioSource>();
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("JumpBooster"))
        {
            gm.GetComponent<gamemanager>().disableSpeedBoost();
            gm.GetComponent<gamemanager>().enebleJumpBoost();
            anim.SetFloat("sboosted", 0);
            anim.SetFloat("jboosted", 1);
            a_S.Play();
        }

        if(col.CompareTag("SpeedBooster"))
        {
            gm.GetComponent<gamemanager>().disableJumpBoost();
            gm.GetComponent<gamemanager>().enebleSpeedBoost();
            anim.SetFloat("jboosted", 0);
            anim.SetFloat("sboosted", 1);
            a_S.Play();
        }
        
    }
}
