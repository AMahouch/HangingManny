using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//import textmesh
using TMPro;

public class Usernameupdater : MonoBehaviour
{
    public TMP_Text UsernameText;
    // Start is called before the first frame update
    void Start()
    {
        UsernameText.text = AuthManager.username;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
