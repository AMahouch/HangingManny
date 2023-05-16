using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class updateplayerscoretotal : MonoBehaviour
{
    public TMP_Text texta;
    // Start is called before the first frame update
    void Start()
    {
        texta.text = AuthManager.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
