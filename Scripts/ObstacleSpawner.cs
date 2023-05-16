using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    //reference to prehad
   //variables to change position of pipes and how often they are spawned

   public GameObject[] prefab;
   public float spawnRate = 1f; //amount of seconds
   public float minHeight = -1f;
   public float maxHeight = 1f;
    public int prefabCounter = 0;
   private void OnEnable()
   {
    //if the player loses we want to disable the player
    //do the spawning when the script is actually enabled
    //
    InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
   }

    //disable the spawning when the script is disabled
    private void onDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

   private void Spawn()
   {
        //clone our prefab
        //Instantiate clones the existing object and give it a initial position and rotation and Quaternion.identity is the default rotation (no-rotation)


        GameObject pipes = Instantiate(prefab[prefabCounter++], transform.position, Quaternion.identity);
        if (prefabCounter >= prefab.Length)
        {
            prefabCounter = 0;
        }
        //position of the pipes up or down between the min and max height
        pipes.transform.position += new Vector3(9,0,0);
        pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
        
   }
}
