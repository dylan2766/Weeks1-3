using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDolphin : MonoBehaviour
{
    //speed variable
    public float rotSpeed;

    //Set dolphins y position
    public float PosY;

    //Mouse position variable
    public Vector2 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ////When mouse clicked moves rotation point of dolphin to x position where mouse clicked
        //if (Input.GetMouseButtonDown(0))
        //{
        //    mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //    mousePos.y = PosY;
        //    transform.position = mousePos;
        //    transform.localEulerAngles = Vector3.zero;
        //}
        
        //When dolphin reaches an angle that is less than or equal to 180 it resets angle to 0. Dolphins X axis is moved to where the mousePosition is.
        if (transform.localEulerAngles.z < 180)
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.y = PosY;
            transform.position = mousePos;
            transform.localEulerAngles = Vector3.zero;
        }

        //Rotates the dolphin
        transform.Rotate(0, 0, -rotSpeed * Time.deltaTime);
    }
}
