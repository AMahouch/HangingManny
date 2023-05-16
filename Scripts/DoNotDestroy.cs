using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotDestroy : MonoBehaviour
{
    private void Awake()
    {
        // GameObject musicObj[] = GameObject.FindGameObjectWithTag("GameMusic");
        // Destroy(this.gameObject);
        // DontDestroyOnLoad(this.gameObject);
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("GameMusic");
       
        if(musicObj.Length>1)
            Destroy(this.gameObject);

         DontDestroyOnLoad(gameObject);
    }
}
