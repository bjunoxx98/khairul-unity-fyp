using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class planeingcategoryliquid03 : MonoBehaviour
{
    public GameObject Canvas_END;
    public bool gameComplete = false;

    public bool oilisThere = false;
    public bool waterisThere = false;
    public bool santanisThere = false;

    public int oilCounter = 0;
    public int waterCounter = 0;
    public int santanCounter = 0;

    public Text[] ing_Text;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (oilCounter >= 1)       //CHECK CHICKEN NUMBER
        {
            oilisThere = true;
            ing_Text[0].color = new Color32(31, 255, 0, 255);
        }
        else
        {
            oilisThere = false;
        }

        if (waterCounter >= 2)       //CHECK MEAT NUMBER
        {
            waterisThere = true;
            ing_Text[1].color = new Color32(31, 255, 0, 255);
        }
        else
        {
            waterisThere = false;
        }

        if (santanCounter >= 1)       //CHECK FISH NUMBER
        {
            santanisThere = true;
            ing_Text[2].color = new Color32(31, 255, 0, 255);
        }
        else
        {
            santanisThere = false;
        }

        if (oilisThere == true && waterisThere == true && santanisThere == true)
        {
            //COMPLETED FOR THIS CATEGORY
            gameComplete = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Oil(Clone)") //1ST INGREDIENT //CHANGED METHOD TO .gameObject.name SINCE OBJECT IS CLONED AFTER PICKUP
        {
            oilCounter++;
            Debug.Log("OIL COUNTER = " + oilCounter);

            Debug.Log("ONE OIL DETECTED");

            collision.gameObject.SetActive(false);
        }
        else if (collision.gameObject.name == "water(Clone)") //1ST INGREDIENT //CHANGED METHOD TO .gameObject.name SINCE OBJECT IS CLONED AFTER PICKUP
        {
            waterCounter++;
            Debug.Log("WATER COUNTER = " + waterCounter);

            Debug.Log("ONE WATER DETECTED");

            collision.gameObject.SetActive(false);
        }
        else if (collision.gameObject.name == "Santan(Clone)") //1ST INGREDIENT //CHANGED METHOD TO .gameObject.name SINCE OBJECT IS CLONED AFTER PICKUP
        {
            santanCounter++;
            Debug.Log("SANTAN COUNTER = " + santanCounter);

            Debug.Log("ONE SANTAN DETECTED");

            collision.gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("WRONG ITEM");
        }

    }
}

