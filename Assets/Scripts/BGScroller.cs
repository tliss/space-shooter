using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroller : MonoBehaviour
{
    public float scrollSpeed;
    public float tileSizeZ;

    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
        // Time.time is the time (in seconds) since the start of the game
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);
        // move background along the Z axis x number of units, where x is newPosition.
        transform.position = startPosition + Vector3.forward * newPosition;
    }
}
