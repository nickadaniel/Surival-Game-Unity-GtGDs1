using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WelcomeM : MonoBehaviour
{
  public GameObject UiObject;
  public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        UiObject.SetActive(false);
    }

     void OnTriggerEnter(Collider enter){
        UiObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerExit(Collider enter){
        UiObject.SetActive(false);
        Destroy(cube);
    }
}
