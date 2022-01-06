using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDeath : MonoBehaviour
{
    public gamemanager mygamemanagerScript;
    [SerializeField]
    public GameObject Player;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("Player"))
        {
            mygamemanagerScript.Respawn();
        }
    }
}