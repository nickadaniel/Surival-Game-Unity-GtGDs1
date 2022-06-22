using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenadeexplode : MonoBehaviour
{
    private Collider[] hitColliders;
    public float blastRadius;
    public float explosionPower;
    public LayerMask explosionLayers;


    void OnCollisionEnter(Collision col){
       // Debug.Log(col.contacts[0].point.ToString());
       ExplosionWork(col.contacts[0].point);
        Destroy(gameObject);
    }
    

    void ExplosionWork(Vector3 explosionPoint){
        hitColliders = Physics.OverlapSphere(explosionPoint, blastRadius, explosionLayers);
   

   /*
   foreach (Collider hitCol in hitColliders){
       if (hitCol.GetComponentn<NavMeshAgent>() != null){
           hitCol.GetComponent<NavMeshAgent>().enabled = false;
       }
       */

/*
       if (hitCol.GetComponent<RigidBody>() != null){
           hitCol.GetComponent<RigidBody>().isKinematic = false;
           hitCol.GetComponent<RigidBody>().AddExplosionForce(explosionPower, explosionPoint,blastRadius, 1, ForceMode.Impulse);
       }

       */
   }

    

    }
    
    


