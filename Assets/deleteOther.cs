using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteOther : MonoBehaviour
{
    public GameObject other;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            //if(other)
            //{
                Destroy(other.GetComponent<MeshRenderer>(),2.0f);
            //}
        }
    }
}
