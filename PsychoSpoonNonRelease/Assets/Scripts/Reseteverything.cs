using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reseteverything : MonoBehaviour
{
    public GameObject Level_Selector;

    public void ResetTimeandSponge()
    {
        PlayerPrefs.DeleteAll();
        Level_Selector.GetComponent<Level_Selector>().Unlocked_Levels = 0;
        Level_Selector.GetComponent<Level_Selector>().Level1.interactable = true;
        Level_Selector.GetComponent<Level_Selector>().Level2.interactable = false;
        Level_Selector.GetComponent<Level_Selector>().Level3.interactable = false;
        Level_Selector.GetComponent<Level_Selector>().Level4.interactable = false;
        Level_Selector.GetComponent<Level_Selector>().Level5.interactable = false;
        Level_Selector.GetComponent<Level_Selector>().Level6.interactable = false;
        Level_Selector.GetComponent<Level_Selector>().Level7.interactable = false;
        Level_Selector.GetComponent<Level_Selector>().Level8.interactable = false;
        Level_Selector.GetComponent<Level_Selector>().World2Level1.interactable = true;
        Level_Selector.GetComponent<Level_Selector>().World2Level2.interactable = false;
        Level_Selector.GetComponent<Level_Selector>().World2Level3.interactable = false;
        Level_Selector.GetComponent<Level_Selector>().World2Level4.interactable = false;
        Level_Selector.GetComponent<Level_Selector>().World3Level1.interactable = false;
        Level_Selector.GetComponent<Level_Selector>().World3Level2.interactable = false;
        Level_Selector.GetComponent<Level_Selector>().World3Level3.interactable = false;
        Level_Selector.GetComponent<Level_Selector>().World3Level4.interactable = false;
        Level_Selector.GetComponent<Level_Selector>().World3Level5.interactable = false;
        Level_Selector.GetComponent<Level_Selector>().World3Level6.interactable = false;
        Level_Selector.GetComponent<Level_Selector>().World3Level7.interactable = false;
        Level_Selector.GetComponent<Level_Selector>().World3Level8.interactable = false;
    }
}