using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Firebase;
using Firebase.Auth;
using Firebase.Database;

public class Player : MonoBehaviour
{


    public MovementJoyStick movementJoyStick;
    public float playerSpeed;
    private Rigidbody2D rb;
    public Text MyScoreText;
    public SpriteRenderer SR;
    public CharacterDatabase characterDB;
    //[SerializeField] GameObject gameOverMenu;

    // public FirebaseDatabase DBreference;
    // private DatabaseReference DBreference;

    private void UpdateCharacter()
    {

        Character character = characterDB.GetCharacter(CharacterManager.selectedOption);
        SR.sprite = character.characterSprite;
    }

    // Start is called before the first frame update
    void Start()
    {
        UpdateCharacter();
        rb = GetComponent<Rigidbody2D>();
        MyScoreText.text =  "Score " + FindObjectOfType<GameManager>().score;
       

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (rb.transform.position.x < -10f){
            rb.transform.position = new Vector2(-10f, rb.position.y);
            //rb.transform.position.x = -9f;
        }
        if (rb.transform.position.y < -4f){
            rb.transform.position = new Vector2(rb.position.x, -4f);
        }
        if (rb.transform.position.y >4f){
            rb.transform.position = new Vector2(rb.position.x, 4f);
        }


        // if (rb.transform.position.y > 4f){
        //     rb.transform.position.y = 4f;
        // }
        // if (rb.transform.position.y < -4f){
        //     rb.transform.position.y = -4f;
        // }

        if (movementJoyStick.joystickVec.y != 0){
            rb.velocity = new Vector2(movementJoyStick.joystickVec.x * playerSpeed, movementJoyStick.joystickVec.y * playerSpeed);
        }

        else{
            rb.velocity = Vector2.zero;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Rock" || other.gameObject.tag == "BrownRock")
        {
           // gameOverMenu.SetActive(true);
         
            //here try to update the firebase
           
            FindObjectOfType<GameManager>().GameOver();
     
        
            FindObjectOfType<GameOverManager>().DisplayGameOver();
            //call the function in the auth manager
            UpdateFirebase();

            Time.timeScale = 0f;
            //run into something
            //display playeremail and name
            

            

        } else if (other.gameObject.tag == "Coin")
        {
            //run into something
            Debug.Log("Collect the coin");
            GetComponent<AudioSource>().Play();
            Destroy(other.gameObject);
            FindObjectOfType<GameManager>().IncreseScore(1);
            MyScoreText.text = "Score " + FindObjectOfType<GameManager>().score;

        }
    }


    //function to update the firebase with useremail and score
    
     public void UpdateFirebase()
    {
    
       Debug.Log("UpdateFirebase hit");
    }

   
}
