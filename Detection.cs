using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
namespace Chapter1
{

public class Detection : MonoBehaviour
{
    /*
    private RaycastHit hit;
    private LayerMask  detectionLayer;
    private float range = 5;
    private float checkRate = 0.5f;
    private float nextCheck;
    private Transform myTransform;



    // Start is called before the first frame update
    void Start()
    {
        SetInitalReferences();
    }

    // Update is called once per frame
    void Update()
    {
        DetectItems();
    }

    void SetInitalReferences(){
        myTransform = transform;
        detectionLayer = 1 << 9;
    }

    void DetectItems(){
        if(Time.time > nextCheck)
        {
            nextCheck = Time.time + checkRate;
            
           if(Physics.RayCast(myTransform.position, myTransform.forward, out hit,range, detectionLayer))
           {
                Debug.Log(hit.transform.name + "its an item");
           }
        }
    }
}

}
*/