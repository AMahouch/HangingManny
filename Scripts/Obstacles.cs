using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
   //all we need is speed variable and in the update we will move it
    public float speed = 5f;
    // ^^ way to change the difficult of the game

    private float leftEdge;

    //need to only calculate it once and not every frame
    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x -1f; // -1f is to make sure the pipe is off the screen making it one unit further
    }

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < leftEdge)
        {
            Destroy(gameObject);
        }
    }

    //destroy the pipes when they are out of the screen
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
