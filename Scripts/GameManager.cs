using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score;
    public AudioSource coinSound;
 
  
    //keep track of score
   public void IncreseScore(int amount)
    {
        this.score += amount;
    }

    public int getScore()
    {
        return score;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameOver()
    {
       
        Debug.Log(score);
        Debug.Log("Score has been updated from old score: " + AuthManager.score);
        AuthManager.score += score;
        Debug.Log("Score has been updated to new score: " + AuthManager.score);
        Debug.Log("Game Over hit the asteroid");
      

        //UnityEditor.EditorApplication.isPlaying = false;

    }



}
