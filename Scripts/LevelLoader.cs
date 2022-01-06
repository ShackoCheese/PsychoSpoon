using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime;
    public int AnimPlayed = 0;
    public gamemanager gm;

    void OnTriggerEnter2D(Collider2D box)
    {
        if(box.CompareTag("Player"))
        {   
            Loadnextlevel();
            GetCurrentScene();
            GetScore();
        }
    }

    public void Loadnextlevel()
    {
        StartCoroutine(LoadLevel());
    }
    IEnumerator LoadLevel()
    {
        transition.SetTrigger("Start");
        
        yield return new WaitForSeconds(transitionTime);

        if(SceneManager.GetActiveScene().name == "World1lvl8"){
            GameObject.Find("NGHelper").GetComponent<NGHelper>().unlockMedal(66534);
            SceneManager.LoadScene("End");
        }else{
            SceneManager.LoadScene("levelEnd");
        }
        
    }

    void GetCurrentScene()
    {
        PlayerPrefs.SetInt("currentscene", SceneManager.GetActiveScene().buildIndex);
        Level_Selector.Scene = SceneManager.GetActiveScene().buildIndex;
    }

    void GetScore()
    {
        PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + gm.Score);
    }
}
