using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class BounceObject : MonoBehaviour
{
    public AnimationCurve jumpCurve;
    public AnimationCurve rotationCurve;

    [Range(0, 1)] public float t;
    public float speed;

    public bool isOn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        if (screenPos.x > Screen.width)
        {
            speed = speed * -1;
        }

        if (screenPos.x < 0)
        {
            speed = speed * -1;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isOn == false)
        {
            isOn = true;
        }

        Vector3 rot = transform.eulerAngles;
        Vector3 jump = transform.position;

        if (isOn == true)
        {
            t += Time.deltaTime;
           // transform.Translate(0, jumpCurve.Evaluate(t) * 0.04f, 0);

            jump.y += jumpCurve.Evaluate(t) * 0.05f;
            transform.position = jump;

            rot.z = rotationCurve.Evaluate(t) * 360;
            transform.eulerAngles = rot;

            //transform.Rotate(0, 0, rotationCurve.Evaluate(t));
            if (t > 1)
            {
                t = 0;
                isOn = false;
            }
        }
        if(isOn == false)
        {
            pos.y = 0;
        }
    }
}
