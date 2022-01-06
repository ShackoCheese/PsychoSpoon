using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level_Selector : MonoBehaviour
{
    public Slider volume_slider;
    [SerializeField]
    private Button Level1;
    [SerializeField]
    private Button Level2;
    [SerializeField]
    private Button Level3;
    [SerializeField]
    private Button Level4;
    [SerializeField]
    private Button Level5;
    [SerializeField]
    private Button Level6;
    [SerializeField]
    private Button Level7;
    [SerializeField]
    private Button Level8;
    [SerializeField]
    public int Unlocked_Levels = 1;
    public static int Scene = 0;

    public void Start()
    {
        Level1.interactable = true;
        Level2.interactable = false;
        Level3.interactable = false;
        Level4.interactable = false;
        Level5.interactable = false;
        Level6.interactable = false;
        Level7.interactable = false;
        Level8.interactable = false;
        if(Unlocked_Levels <= Scene + 1)
        {
            Unlocked_Levels = Scene + 1;
        }
    }

    public void Update()
    {
        if(Unlocked_Levels == 1)
        {
            Level1.interactable = true;
        }

        else if(Unlocked_Levels == 2)
        {
            Level1.interactable = true;
            Level2.interactable = true;
        }

        else if(Unlocked_Levels == 3)
        {
            Level1.interactable = true;
            Level2.interactable = true;
            Level3.interactable = true;
        }

        else if(Unlocked_Levels == 4)
        {
            Level1.interactable = true;
            Level2.interactable = true;
            Level3.interactable = true;
            Level4.interactable = true;
        }

        else if(Unlocked_Levels == 5)
        {
            Level1.interactable = true;
            Level2.interactable = true;
            Level3.interactable = true;
            Level4.interactable = true;
            Level5.interactable = true;
        }

        else if(Unlocked_Levels == 6)
        {
            Level1.interactable = true;
            Level2.interactable = true;
            Level3.interactable = true;
            Level4.interactable = true;
            Level5.interactable = true;
            Level6.interactable = true;
        }

        else if(Unlocked_Levels == 7)
        {
            Level1.interactable = true;
            Level2.interactable = true;
            Level3.interactable = true;
            Level4.interactable = true;
            Level5.interactable = true;
            Level6.interactable = true;
            Level7.interactable = true;
        }

        else if(Unlocked_Levels == 8)
        {
            Level1.interactable = true;
            Level2.interactable = true;
            Level3.interactable = true;
            Level4.interactable = true;
            Level5.interactable = true;
            Level6.interactable = true;
            Level7.interactable = true;
            Level8.interactable = true;
        }
    }

    public void Start_Tutorial()
    {
        SceneManager.LoadScene(1);
    }

    public void Start_Level1()
    {
        SceneManager.LoadScene(2);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Set_Volume()
    {
        AudioListener.volume = volume_slider.value;
    }
}
