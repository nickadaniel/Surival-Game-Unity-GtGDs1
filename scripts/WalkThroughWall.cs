

using System.Collections;
using UnityEngine;


namespace Chapter1{
public class WalkThroughWall : MonoBehaviour
{

    private Color myColor = new Color(0.5f, 1, 0.5f, 1);
    

    public void SetLayerToNotSolid(){
    GetComponent<Renderer>().material.color = myColor;
    }

    public void SetLayerToDefualt(){
        GetComponent<Renderer>().material.color = Color.white;
    }
  /*
   void OnEnable(){
       gameObject.Layer = LayerMask.NameToLayer("Not Solid");
   }

   void OnDisable(){
       gameObject.Layer = LayerMask.NameToLayer("Default");
   }

   */

/*
   public void SetLayerToNotSolid(){
       gameObject.Layer = LayerMask.NameToLayer("Not Solid");
   }

   public void SetLayerNotToDefault(){
       gameObject.Layer = LayerMask.NameToLayer("Default");
   }
   */


}


}