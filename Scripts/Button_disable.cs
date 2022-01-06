using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_disable : MonoBehaviour
{
    public InGame_Button myInGame_ButtonScript;
    [SerializeField]
    private GameObject Puzzle_Object;

    public bool on;

    void Update()
    {
        if(myInGame_ButtonScript.button_active == true && on == true)
        {
            Puzzle_Object.SetActive(false);
        }

        else if(myInGame_ButtonScript.button_active == false && on == true)
        {
            Puzzle_Object.SetActive(true);
        }

        else if(myInGame_ButtonScript.button_active == true && on == false)
        {
            Puzzle_Object.SetActive(true);
        }
        else if(myInGame_ButtonScript.button_active == false && on == false)
        {
           Puzzle_Object.SetActive(false); 
        }
    }
}
