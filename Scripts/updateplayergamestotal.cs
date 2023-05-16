using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class updateplayergamestotal : MonoBehaviour
{
    public TMP_Text textGamePlayed;
    // Start is called before the first frame update
    void Start()
    {
        textGamePlayed.text = AuthManager.gamesPlayed.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
