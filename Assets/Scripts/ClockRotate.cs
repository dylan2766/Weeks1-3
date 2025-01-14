using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ClockRotate : MonoBehaviour
{
    public float MinuteSpeed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Rotate by MinuteSpeed
        transform.Rotate(0,0,MinuteSpeed * -Time.deltaTime);


    }
}
