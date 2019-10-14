using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holder : MonoBehaviour
{

    List<GameObject> myChild;

    // Start is called before the first frame update
    void Start()
    {
        foreach(Transform child in transform)
        {
            myChild.Add(child.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
