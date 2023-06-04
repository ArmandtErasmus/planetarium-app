using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public GameObject earth;
    void Start()
    {
        
    }

    
    void Update()
    {
        Rotate();
    }

    public void Rotate()
    {
        earth.transform.Rotate(0f, 4f * Time.deltaTime, 0f);

    }
        
}
