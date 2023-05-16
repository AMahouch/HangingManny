using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    [Range(-1f, 1f)]
    public float scrollSpeed = 0.5f;
    private float offset;
    private Material mat;

    // Start is called before the first frame update
    void Start()
    {
        //material is populated with the material of the object this script is attached to
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        offset += (scrollSpeed * Time.deltaTime)/10f;
        mat.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
