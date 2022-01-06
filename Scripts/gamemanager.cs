using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public Rigidbody2D playerRigidbody2D;
    public Rigidbody2D platformRigidbody2D;
    public bool playerMovementEnabled;
    public bool platformMovementEnabled;
    private Brainpower brainpowerscript;
    public Vector3 offset;
    public float TeleportOffset;
    public GameObject Player;
    [SerializeField]
    private GameObject Start_GameObject;
    [SerializeField]
    public GameObject Checkpoint_GameObject;
    public Vector3 Checkpoint;
    public int Score;
    
    [SerializeField]
    public int PlayerScore;
    public int pickedup;

    public GameObject moveAble;
    public Vector2 plateOffset;

    void Start()
    {
        enablePlayerMovement();
        disablePlatformMovement();
        platformRigidbody2D.constraints = RigidbodyConstraints2D.FreezeAll;
        Checkpoint = Start_GameObject.transform.position;
        Player.transform.position = Checkpoint;
        moveAble.transform.position = new Vector3(Player.transform.position.x + 2, Player.transform.position.y);

    }

    void Update()
    {
        if (Input.GetKeyDown("e"))
        {

            if(playerMovementEnabled == true){
                disablePlayerMovement();
            }
            else{
                enablePlayerMovement();
            }

            if(platformMovementEnabled == true){
                disablePlatformMovement();
            }
            else{
                enablePlatformMovement();
            }
        }

        if(Input.GetKeyDown("f") || Input.GetKeyDown("r"))
        {
            moveAble.transform.position = new Vector2(Player.transform.position.x + TeleportOffset, Player.transform.position.y + TeleportOffset);
        }

        if(playerRigidbody2D.rotation != 0)
        {
            GameObject.Find("NGHelper").GetComponent<NGHelper>().unlockMedal(66541);
        }

        if(playerRigidbody2D.velocity.y == 0 && playerMovementEnabled == false)
        {
            playerRigidbody2D.constraints = RigidbodyConstraints2D.FreezeAll;
        }

    }

    public void disablePlayerMovement()
    {
            GameObject varGameObject = GameObject.FindWithTag("Player");
            varGameObject.GetComponent<PlayerMovement>().enabled = false; 
            playerRigidbody2D.constraints = RigidbodyConstraints2D.FreezeRotation & RigidbodyConstraints2D.FreezePositionX;
            playerMovementEnabled = false;
    }

    public void enablePlayerMovement()
    {
            GameObject varGameObject = GameObject.FindWithTag("Player");
            varGameObject.GetComponent<PlayerMovement>().enabled = true;
            playerMovementEnabled = true;
            playerRigidbody2D.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    public void disablePlatformMovement()
    {
            GameObject varGameObject = GameObject.FindWithTag("Platform");
            varGameObject.GetComponent<PlatformMovement>().enabled = false;
            platformMovementEnabled = false;
            platformRigidbody2D.constraints = RigidbodyConstraints2D.FreezeAll;
    }

    public void enablePlatformMovement()
    {
            GameObject varGameObject = GameObject.FindWithTag("Platform");
            varGameObject.GetComponent<PlatformMovement>().enabled = true;
            platformMovementEnabled = true;
            platformRigidbody2D.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    public void enebleJumpBoost()
    {   

        GameObject varGameObject = GameObject.FindWithTag("Player");
        varGameObject.GetComponent<CharacterController2D>().JumpBoostEnabled = true;

    }

    public void disableJumpBoost()
    {
            GameObject varGameObject = GameObject.FindWithTag("Player");
            varGameObject.GetComponent<CharacterController2D>().JumpBoostEnabled = false;
    }

        public void enebleSpeedBoost()
    {   

        GameObject varGameObject = GameObject.FindWithTag("Player");
        varGameObject.GetComponent<CharacterController2D>().SpeedBoostEnabled = true;
    }

    public void disableSpeedBoost()
    {
            GameObject varGameObject = GameObject.FindWithTag("Player");
            varGameObject.GetComponent<CharacterController2D>().SpeedBoostEnabled = false;
    }


    public void Respawn()
    {
        GameObject Player = GameObject.FindWithTag("Player");
        GameObject Start_GameObject = GameObject.Find("Start");
        GameObject Checkpoint_GameObject = GameObject.Find("Checkpoint");
        Player.transform.position = Checkpoint + offset;
        brainpowerscript = Player.GetComponent<Brainpower>();
        brainpowerscript.brainpower = 100f;
        brainpowerscript.timer = 0f;
        GameObject varGameObject = GameObject.FindWithTag("Player");
        varGameObject.GetComponent<CharacterController2D>().StopAllCoroutines();
        varGameObject.GetComponent<CharacterController2D>().speed = 10f;
        Transform SpbI = Player.transform.GetChild(0);
        SpbI.GetComponent<Animator>().SetInteger("SpbActive", 0);
        disablePlatformMovement();
        enablePlayerMovement();
    }
    
    public void ScoreUp()
    {
        Score += 1;
        pickedup = 1;
        PlayerScore += 1;
    }

    void OnDisable()
    {
        PlayerPrefs.SetInt("score", PlayerScore);
        PlayerPrefs.SetInt("lvlscore", Score);
        
    }
    void OnEnable()
    {
        PlayerScore = PlayerPrefs.GetInt("score");
        Score = 0;
        PlayerPrefs.SetInt("lvlscore", 0);
    }
}