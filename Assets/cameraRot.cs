﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraRot : MonoBehaviour
{
    public Transform realCam;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = new Vector3(0, 0, Input.GetAxis("Horizontal"));
        transform.Rotate(dir * speed * Time.deltaTime);
        //transform.eulerAngles = new Vector3(0, realCam.eulerAngles.y, 0);
    }
}
