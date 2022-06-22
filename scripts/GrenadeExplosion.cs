using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Chapter1{
public class NewBehaviourScript : MonoBehaviour
{
  
    void OnCollisionEnter(Collision col){
        Debug.Log(col.contacts[0].point.ToString());
        Destroy(gameObject);
    }

}
}


