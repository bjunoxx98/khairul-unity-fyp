using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class planeingcategoryvegie03 : MonoBehaviour
{
    public GameObject Canvas_END;
    public bool gameComplete = false;

    public bool garlicisThere = false;
    public bool onionisThere = false;
    public bool gingerisThere = false;
    public bool bendiisThere = false;

    public int garlicCounter = 0;
    public int onionCounter = 0;
    public int gingerCounter = 0;
    public int bendiCounter = 0;

    public Text[] ing_Text;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (garlicCounter >= 1)       //CHECK CHICKEN NUMBER
        {
            garlicisThere = true;
            ing_Text[0].color = new Color32(31, 255, 0, 255);
        }
        else
        {
            garlicisThere = false;
        }

        if (onionCounter >= 2)       //CHECK MEAT NUMBER
        {
            onionisThere = true;
            ing_Text[1].color = new Color32(31, 255, 0, 255);
        }
        else
        {
            onionisThere = false;
        }

        if (gingerCounter >= 1)       //CHECK FISH NUMBER
        {
            gingerisThere = true;
            ing_Text[2].color = new Color32(31, 255, 0, 255);
        }
        else
        {
            gingerisThere = false;
        }

        if (bendiCounter >= 1)       //CHECK EGG NUMBER
        {
            bendiisThere = true;
            ing_Text[3].color = new Color32(31, 255, 0, 255);
        }
        else
        {
            bendiisThere = false;
        }

        if (garlicisThere == true && onionisThere == true && gingerisThere == true && bendiisThere == true)
        {
            //COMPLETED FOR THIS CATEGORY
            gameComplete = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "garlicwhole(Clone)") //1ST INGREDIENT //CHANGED METHOD TO .gameObject.name SINCE OBJECT IS CLONED AFTER PICKUP
        {
            garlicCounter++;
            Debug.Log("GARLIC COUNTER = " + garlicCounter);

            Debug.Log("ONE GARLIC DETECTED");

            collision.gameObject.SetActive(false);
        }
        else if (collision.gameObject.name == "onion(Clone)") //1ST INGREDIENT //CHANGED METHOD TO .gameObject.name SINCE OBJECT IS CLONED AFTER PICKUP
        {
            onionCounter++;
            Debug.Log("ONION COUNTER = " + onionCounter);

            Debug.Log("ONE ONION DETECTED");

            collision.gameObject.SetActive(false);
        }
        else if (collision.gameObject.name == "ginger(Clone)") //1ST INGREDIENT //CHANGED METHOD TO .gameObject.name SINCE OBJECT IS CLONED AFTER PICKUP
        {
            gingerCounter++;
            Debug.Log("GINGER COUNTER = " + gingerCounter);

            Debug.Log("ONE GINGER DETECTED");

            collision.gameObject.SetActive(false);
        }
        else if (collision.gameObject.name == "bendi(Clone)") //1ST INGREDIENT //CHANGED METHOD TO .gameObject.name SINCE OBJECT IS CLONED AFTER PICKUP
        {
            bendiCounter++;
            Debug.Log("BENDI COUNTER = " + bendiCounter);

            Debug.Log("ONE BENDI DETECTED");

            collision.gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("WRONG ITEM");
        }

    }
}

