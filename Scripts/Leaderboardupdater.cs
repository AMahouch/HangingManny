using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Leaderboardupdater : MonoBehaviour
{

    public TMP_Text usern;
    public TMP_Text users;
    public TMP_Text userg;
    // Start is called before the first frame update
    void Start()
    {
        usern.text = AuthManager.username.ToString();
        users.text = AuthManager.score.ToString();
        userg.text = AuthManager.gamesPlayed.ToString();
    }

    // Update is called oncex per frame
    void Update()
    {
        
    }
}
