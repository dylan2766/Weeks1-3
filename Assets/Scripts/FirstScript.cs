using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += speed;
        transform.position = pos;

        //test on right of screen
        Vector2 screenSize = new Vector2(Screen.width, Screen.height);
        Vector2 screenSizeWorld = new Vector2();
        screenSizeWorld = Camera.main.ScreenToWorldPoint(screenSize);

        //test on left of screen
        Vector2 screenZeroWorld = Camera.main.ScreenToWorldPoint(Vector2.zero);

        if (pos.x < screenZeroWorld.x || pos.x > screenSizeWorld.x)
        {
            speed = speed * -1;
        }
    }
}
