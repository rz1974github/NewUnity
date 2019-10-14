using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseDownTest : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody rigidbody = null;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void OnMouseDown()
    {
        rigidbody.AddForce(transform.forward * 100f);
    }



    // Update is called once per frame
    void Update()
    {
            
    }
}
