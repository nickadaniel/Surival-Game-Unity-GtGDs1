﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter1{
    public class ThrowGrenade : MonoBehaviour
{
public GameObject grenadePrefab;
private Transform myTransform;
public float propulisionforce;

    // Start is called before the first frame update
    void Start()
    {
        SetInitialReferences();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            SpawnGrenade();
        }
    }

    void SetInitialReferences(){
        myTransform = transform;
    }

    void SpawnGrenade(){
        GameObject go = (GameObject) Instantiate(grenadePrefab, myTransform.TransformPoint(0,0,0.5f), myTransform.rotation);
      //  go.GetComponent<Rigibody>().AddForce(myTransform.foward * propulisionforce, ForceMode.Inpulse);
      //  Destroy(go,10);
    }
}

}

