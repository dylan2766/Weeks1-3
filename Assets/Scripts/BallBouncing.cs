using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBouncing : MonoBehaviour
{
    public float ballSpeedX = 1f;
    public float ballSpeedY = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 ballPos = transform.position;
        ballPos.x += ballSpeedX * Time.deltaTime;
        ballPos.y += ballSpeedY * Time.deltaTime;

        //Ball bouncing
        transform.Translate(ballPos.x * Time.deltaTime ,ballPos.y * Time.deltaTime ,0);

        //Testing Camera Borders
        Vector2 screenSize = new Vector2(Screen.width, Screen.height);
        Vector2 screenSizeWorld = new Vector2(Screen.width, Screen.height);
        screenSizeWorld = Camera.main.ScreenToWorldPoint(screenSize);

        Vector2 screenZeroWorld = Camera.main.ScreenToWorldPoint(Vector2.zero);

        if (ballPos.x < screenZeroWorld.x || ballPos.x > screenSizeWorld.x)
        {
            ballSpeedX = ballSpeedX * -1;
        }
    }
}
