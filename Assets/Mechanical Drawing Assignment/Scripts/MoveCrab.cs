using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCrab : MonoBehaviour
{
    //Variables
    public AnimationCurve crab;

    [Range(0, 1)] public float crabRange;

    public float speed;
    public Transform start;
    public Transform end;

    public float rotSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Sets the crabs speed to be the speed multiplied by input from horizontal axis multiplied by time
        crabRange += (speed * Input.GetAxis("Horizontal")) * Time.deltaTime;

        //Changes crabs position within two points
        transform.position = Vector2.Lerp(start.position, end.position, crab.Evaluate(crabRange));

        //If crab is moving left or right rotate the crab to a certain angle and back
        if(Input.GetAxis("Horizontal") != 0)
        {
            transform.Rotate(0, 0, - rotSpeed * Time.deltaTime);
            if (transform.eulerAngles.z > 15)
            {
                rotSpeed = rotSpeed * -1;
            }
        }
    }
}
