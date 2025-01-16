using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWaves : MonoBehaviour
{
    //speed variable
    public float speed;
    //range
    [Range(0,1)] public float waveRange;

    //animation curve
    public AnimationCurve waveCurve;

    //start and end positions
    public Transform start;
    public Transform end;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move the object in its animation curve by a defined speed
        waveRange += speed * Time.deltaTime;

        //if the range of the curve is above 1 switch direction
        if (waveRange > 1)
        {
            speed = speed * -1;
        }

        //if the range of the curve is below 0 switch direction
        if (waveRange < 0)
        {
            speed = speed * -1;
        }

        //Gets the start and end position and the animation curve range of the object
        transform.position = Vector2.Lerp(start.position, end.position, waveCurve.Evaluate(waveRange));
    }
}
