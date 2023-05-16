using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{

    [SerializeField] GameObject pauseMenu;

    //public GameObject pauseMenu;
    //public bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // void Update()
    // {
    //     if(Input.GetKeyDown(KeyCode.Escape))
    //     {
    //         if(isPaused)
    //         {
    //             ResumeGame();
    //         }
    //         else
    //         {
    //             PauseGame();
    //         }
    //     }s
    // }

    public void Pause(){
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        //isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        //isPaused = false;
    }
    public void Home(int SceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneID);
    }
}
