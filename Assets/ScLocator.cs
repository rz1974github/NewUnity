using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScLocator : MonoBehaviour
{
    public GameObject otherObject;
    private someScript someSc;
    private cylinderScript cylinderSc;
    private CapsuleCollider capCol;

    private void Awake()
    {
        someSc = GetComponent<someScript>();
        Debug.Log("someValue = " + someSc.someValue);

        if(otherObject)
        {
            cylinderSc = otherObject.GetComponent<cylinderScript>();

            Debug.Log("cylinderValue = " + cylinderSc.cylinderValue);

            capCol = otherObject.GetComponent<CapsuleCollider>();

            Debug.Log(capCol.ToString());

            capCol.height = 90;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
