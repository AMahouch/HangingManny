using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{   
    [SerializeField] GameObject gameOverMenu;
    [SerializeField] GameObject AdvertisementMenu;  
    [SerializeField] Text Score;

    public void DisplayGameOver()
    {
        Debug.Log("Total Coins Collected");
        Debug.Log(FindObjectOfType<GameManager>().score);
        gameOverMenu.SetActive(true);
    }
    public void DisplayAdvertisement()
    {
        gameOverMenu.SetActive(false);
        FindObjectOfType<GameManager>().IncreseScore(3);
        AuthManager.score+=3;
        Score.text = "Score " + FindObjectOfType<GameManager>().score;
        Debug.Log("Total Coins Collected is(post Ads): " + FindObjectOfType<GameManager>().score);
        AdvertisementMenu.SetActive(true);
    }

    public void AdvToGameOver()
    {
        AdvertisementMenu.SetActive(false);
        gameOverMenu.SetActive(true);
    }
    
}
