using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAroundY : MonoBehaviour
{

    Vector3 rot;
    float rotSpeed = 0.25f;


    // Use this for initialization
    void Start()
    {

        rot = new Vector3(0, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        rot = new Vector3(0, rotSpeed, 0);
        transform.Rotate(rot);
    }
}
