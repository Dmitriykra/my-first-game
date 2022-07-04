using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
   int hits = 0; 
   private void OnCollisionEnter(Collision other){
       
       if (other.gameObject.tag != "Dimas"){
           hits++;
           Debug.Log("You`ve bumpmin the wall this many times: " + hits);
       }
 
   }
}
