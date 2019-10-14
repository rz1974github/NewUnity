using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpInput : MonoBehaviour
{

    rzKinematics myKinematics;

    // Start is called before the first frame update
    void Start()
    {
        myKinematics = GetComponent<rzKinematics>();
    }

    Vector3 upPulse = new Vector3(0,0,0);

    // Update is called once per frame
    void Update()
    {
        bool down       = Input.GetButtonDown("Jump");
        bool hold       = Input.GetButton("Jump");
        bool released   = Input.GetButtonUp("Jump");

        if (down)
        {
            upPulse = Vector3.up * 3.0f;

            myKinematics.push(upPulse);

        }
        else if(hold)
        {
            upPulse = Vector3.Lerp(upPulse, Vector3.zero, 0.4f);

            myKinematics.push(upPulse);

        }
        else if (released)
        {
            upPulse = Vector3.zero;
        }

    }
}
