using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroychicken : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Destroy(GetComponent <MeshRenderer>());
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ayam")
        {
            Destroy(gameObject);
        }
    }
}
