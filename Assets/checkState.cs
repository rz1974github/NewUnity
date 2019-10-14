using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkState : MonoBehaviour
{
    public GameObject targetObject;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Active Self:" + targetObject.activeSelf);
        Debug.Log("Active in Hierarchy:" + targetObject.activeInHierarchy);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
