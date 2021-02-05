using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab1 : MonoBehaviour
{
    public GameObject Onion;
    //public GameObject Sphere;
    public GameObject Hand;
    public float handPower;

    bool inHands = false;
    //Vector3 spherePos;

    Collider onionCol;
    Rigidbody onionRb;
    Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        //spherePos = Sphere.transform.position;



        onionCol = Onion.GetComponent<SphereCollider>();
        onionRb = Onion.GetComponent<Rigidbody>();
        cam = GetComponentInChildren<Camera>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (!inHands)
            {

                onionCol.isTrigger = true;
               Onion.transform.SetParent(Hand.transform);
                Onion.transform.localPosition = new Vector3(0.0675f, -0.4f, 0.02f);
                onionRb.useGravity = false;
                onionRb.velocity = Vector3.zero;
                inHands = true;

            }
            else if (inHands)
            {
                onionCol.isTrigger = false;
                onionRb.useGravity = true;
                this.GetComponent<PlayerGrab>().enabled = false;
                Onion.transform.SetParent(null);
                onionRb.velocity = cam.transform.rotation * Vector3.forward * handPower;

                inHands = false;
            }
        }


    }
}
