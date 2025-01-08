using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, speed * Time.deltaTime);


        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.localPosition = Vector3.zero;
            transform.localEulerAngles = Vector3.zero;
            //transform.localRotation = Quaternion.identity;
        }
    }
}
