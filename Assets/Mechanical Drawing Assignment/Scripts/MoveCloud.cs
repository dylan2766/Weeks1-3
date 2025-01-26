using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCloud : MonoBehaviour
{
    //public variables
    public float speed;
    public float startPos;

    public AnimationCurve cloudCurve;
    [Range(0, 1)] public float cloudPos;

    public Transform start;
    public Transform end;

    //private variables

    // Start is called before the first frame update
    void Start()
    {
        cloudPos = startPos;
    }

    // Update is called once per frame
    void Update()
    {
        //move cloud to the left of the screen
        cloudPos += speed * Time.deltaTime;

        //if cloud is on or past the end point reset cloud to start point
        if (cloudPos >= 1)
        {
            cloudPos = 0;
        }

        transform.position = Vector2.Lerp(start.position,end.position, cloudCurve.Evaluate(cloudPos));
    }
}
