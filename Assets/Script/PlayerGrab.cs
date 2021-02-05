using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab : MonoBehaviour
{
    public GameObject Chicken;
    //public GameObject Sphere;
    public GameObject Hand;
    //public float handPower;

    bool inHands = false;
    Vector3 chickenPos;
  
    //Collider chickenCol;
    //Rigidbody chickenRb;
    //Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        chickenPos = Chicken.transform.position;
        
  
        
        //chickenCol = Chicken.GetComponent<SphereCollider>();
        //chickenRb = Chicken.GetComponent<Rigidbody>();
        //cam = GetComponentInChildren<Camera>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (!inHands)
            {

                //chickenCol.isTrigger = true;
                Chicken.transform.SetParent(Hand.transform);
                Chicken.transform.localPosition = new Vector3(-0.04500002f, -0.159f, 0.2375001f);
                //chickenRb.useGravity = false;
                //chickenRb.velocity = Vector3.zero;
                inHands = true;

            }else if (inHands)
            {
                //chickenCol.isTrigger = false;
                //chickenRb.useGravity = true;
               // this.GetComponent<PlayerGrab>().enabled = false;
                Chicken.transform.SetParent(null);
                Chicken.transform.localPosition = chickenPos;
                //chickenRb.velocity = cam.transform.rotation * Vector3.forward * handPower;
            
                inHands = false;
            }
        }
        

    }
}
