using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float rotationSpeed = 100f;

    // Update is called once per frame
    void Update()
    {
        // Rotate the plane around the Y-axis
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
