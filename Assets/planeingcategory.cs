using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//EDITING FOR DECOMP - 01 - RENDANG
public class planeingcategory : MonoBehaviour
{
    public GameObject Canvas_END;
    public bool gameComplete = false;    

    public bool chickenisThere = false;
    public bool meatisThere = false;
    public bool fishisThere = false;
    public bool eggisThere = false;

    public int chicCounter = 0;
    public int meatCounter = 0;
    public int fishCounter = 0;
    public int eggCounter = 0;

    public Text[] ing_Text;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (chicCounter >= 1)       //CHECK CHICKEN NUMBER
        {
            chickenisThere = true;
            ing_Text[0].color = new Color32(31, 255, 0, 255);
        }
        else
        {
            chickenisThere = false;
        }

        /*if (meatCounter >= 1)       //CHECK MEAT NUMBER
        {
            meatisThere = true;
            ing_Text[1].color = new Color32(31, 255, 0, 255);
        }
        else
        {
            meatisThere = false;
        }*/

        /*if (fishCounter >= 1)       //CHECK FISH NUMBER
        {
            fishisThere = true;
            ing_Text[2].color = new Color32(31, 255, 0, 255);
        }
        else
        {
            fishisThere = false;
        }*/

        /*if (eggCounter >= 1)       //CHECK EGG NUMBER
        {
            eggisThere = true;
            ing_Text[3].color = new Color32(31, 255, 0, 255);
        }
        else
        {
            eggisThere = false;
        }*/

        if (chickenisThere == true)
        {
            //COMPLETED FOR THIS CATEGORY
            gameComplete = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "chickenv2(Clone)") //1ST INGREDIENT //CHANGED METHOD TO .gameObject.name SINCE OBJECT IS CLONED AFTER PICKUP
        {
            chicCounter++;
            Debug.Log("CHICKEN COUNTER = "+chicCounter);
            Debug.Log("ONE CHICKEN DETECTED");

            collision.gameObject.SetActive(false);
        }
        /*else if (collision.gameObject.name == "Meat(Clone)") //1ST INGREDIENT //CHANGED METHOD TO .gameObject.name SINCE OBJECT IS CLONED AFTER PICKUP
        {
            meatCounter++;
            Debug.Log("MEAT COUNTER = " + meatCounter);
            Debug.Log("ONE MEAT DETECTED");

            collision.gameObject.SetActive(false);
        }
        else if (collision.gameObject.name == "ikan(Clone)") //1ST INGREDIENT //CHANGED METHOD TO .gameObject.name SINCE OBJECT IS CLONED AFTER PICKUP
        {
            fishCounter++;
            Debug.Log("FISH COUNTER = " + fishCounter);
            Debug.Log("ONE FISH DETECTED");

            collision.gameObject.SetActive(false);
        }
        else if (collision.gameObject.name == "Egg(Clone)") //1ST INGREDIENT //CHANGED METHOD TO .gameObject.name SINCE OBJECT IS CLONED AFTER PICKUP
        {
            eggCounter++;
            Debug.Log("EGG COUNTER = " + eggCounter);
            Debug.Log("ONE EGG DETECTED");

            collision.gameObject.SetActive(false);
        }*/
        else
        {
            Debug.Log("WRONG ITEM");
        }
        
    }
}
