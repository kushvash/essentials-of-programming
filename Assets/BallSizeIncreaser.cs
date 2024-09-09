using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSizeIncreaser : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float growthRate = 1.0f;

    void Update()
    {
        // Increase the size of the sphere over time
        transform.localScale += Vector3.one * growthRate * Time.deltaTime;
    }
}
