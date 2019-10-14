using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rzKinematics : MonoBehaviour
{
    public Vector3 extForce = new Vector3(0,0,0);
    public float bounceFactor = 0.75f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Vector3 nowSpeed = new Vector3(0,0,0);

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > 0)
        {
            if (nowSpeed.y > -9.8)
                nowSpeed.y -= (Time.deltaTime * 5.0f);
        }
        else
        {
            nowSpeed.y = -(nowSpeed.y* bounceFactor);
            transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        }

        transform.Translate(nowSpeed * Time.deltaTime);
        extForce = Vector3.zero;
    }

    public void push(Vector3 force)
    {
        extForce += force;

        nowSpeed += extForce;

        Debug.Log("Now Speed=" + nowSpeed.ToString());
    }
}
