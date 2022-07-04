using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drupa1 : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidbody;
    [SerializeField] float timeVar = 7.0f;
    // Start is called before the first frame update
    void Start()
    {   
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;

        rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = false;
 
    }

    // Update is called once per frame
    void Update()
    {

        if(Time.time > timeVar){
          renderer.enabled = true;  
          rigidbody.useGravity = true;
        }
    }
}
