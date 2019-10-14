using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helloWorld : MonoBehaviour
{
    public float coffeeTemp = 100.0f;
    int ucount = 0;
    int fcount = 0;

    private anotherClass myAnother;

    private void Awake()
    {
        Debug.Log("helloWorld awake is called.");
    }

    // Start is called before the first frame update
    void Start()
    {
        coffeeTemp = 400;
        /*
        myAnother = new anotherClass();
        myAnother.fruitMachine((int)coffeeTemp, myAnother.apple);
        */
        Debug.Log("helloWorld start is called.");
    }

    void checkCoffeeTemp()
    {
        if(coffeeTemp > 85.0)
        {
            Debug.LogFormat("{0:F1} Coffee is too hot.", coffeeTemp);
        }
        else if(coffeeTemp < 50.0)
        {
            Debug.LogFormat("{0:F1} Coffee is too cold.", coffeeTemp);
        }
        else
        {
            Debug.LogFormat("{0:F1} Coffee temperature is just right.", coffeeTemp);
        }
        
    }

    private void FixedUpdate()
    {
        fcount++;
        if(fcount%100 == 0)
        {
            Debug.Log("FixedUpdate time:" + Time.time);
        }
    }



    // Update is called once per frame
    void Update()
    {
        ucount++;
        if (ucount % 100 == 0)
        {
            Debug.Log("Update time:" + Time.time);
        }
        coffeeTemp -= Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            checkCoffeeTemp();
        }
    }
}
