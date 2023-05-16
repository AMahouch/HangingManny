using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeProfileToLogin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeSceneToLogin()
    {
        SceneManager.LoadScene("LogIn");
    }

    public void ChangeSceneToProfile()
    {
        SceneManager.LoadScene("Profile");
    }

    public void ChangeSceneToRegister()
    {
        SceneManager.LoadScene("Registration");
    }

    public void ChangeSceneToHOme()
    {
        SceneManager.LoadScene("HomeScreen");
    }

    public void ChangeSceneToGamePlay()
    {
        SceneManager.LoadScene("GamePlay");
        AuthManager.gamesPlayed+=1 ;
    }
}
