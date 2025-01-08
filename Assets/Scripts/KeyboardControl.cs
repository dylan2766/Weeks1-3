using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardControl : MonoBehaviour
{
    public float speed = 5;
    public float rotSpeed = 30;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 pos = transform.position;

        ////Left & right controls
        //pos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        ////Up & down controls
        //pos.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;

        //transform.position = pos;

        //Move up down left and right
        //transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);

        //Move up and down
        transform.Translate(0, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);

        //Rotate left and right
        transform.Rotate(0, 0, -Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime);
    }
}
