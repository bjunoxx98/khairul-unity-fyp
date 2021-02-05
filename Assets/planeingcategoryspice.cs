using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//EDITING FOR DECOM-01-RENDANG
public class planeingcategoryspice : MonoBehaviour
{
    public GameObject Canvas_END;
    public bool gameComplete = false;

    //8 INGREDIENTS
    public bool ChilliisThere = false;
    public bool curypowderisThere = false;
    public bool spicesisThere = false;
    public bool daunkariisThere = false;
    public bool saltisThere = false;
    public bool SugarisThere = false;
    public bool kerisikisThere = false;
    public bool asamisThere = false;

    public int ChilliCounter = 0;
    public int curypowderCounter = 0;
    public int spicesCounter = 0;
    public int daunkariCounter = 0;
    public int saltCounter = 0;
    public int SugarCounter = 0;
    public int kerisikCounter = 0;
    public int asamCounter = 0;

    public Text[] ing_Text;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //--------------------------------------------------------------------------1
        if (ChilliCounter >= 1)       //CHECK CHICKEN NUMBER
        {
            ChilliisThere = true;
            ing_Text[0].color = new Color32(31, 255, 0, 255);
        }
        else
        {
            ChilliisThere = false;
        }

        /*if (curypowderCounter >= 1)       //CHECK MEAT NUMBER
        {
            curypowderisThere = true;
            ing_Text[1].color = new Color32(31, 255, 0, 255);
        }
        else
        {
            curypowderisThere = false;
        }*/

        /*if (spicesCounter >= 1)       //CHECK FISH NUMBER
        {
            spicesisThere = true;
            ing_Text[2].color = new Color32(31, 255, 0, 255);
        }
        else
        {
            spicesisThere = false;
        }*/
        //--------------------------------------------------------------------------4
        /*if (daunkariCounter >= 1)       //CHECK CHICKEN NUMBER
        {
            daunkariisThere = true;
            ing_Text[3].color = new Color32(31, 255, 0, 255);
        }
        else
        {
            daunkariisThere = false;
        }*/

        if (saltCounter >= 1)       //CHECK MEAT NUMBER
        {
            saltisThere = true;
            ing_Text[4].color = new Color32(31, 255, 0, 255);
        }
        else
        {
            saltisThere = false;
        }

        if (SugarCounter >= 1)       //CHECK FISH NUMBER
        {
            SugarisThere = true;
            ing_Text[5].color = new Color32(31, 255, 0, 255);
        }
        else
        {
            SugarisThere = false;
        }
        //--------------------------------------------------------------------------7
        if (kerisikCounter >= 1)       //CHECK CHICKEN NUMBER
        {
            kerisikisThere = true;
            ing_Text[6].color = new Color32(31, 255, 0, 255);
        }
        else
        {
            kerisikisThere = false;
        }

        /*if (asamCounter >= 1)       //CHECK MEAT NUMBER
        {
            asamisThere = true;
            ing_Text[7].color = new Color32(31, 255, 0, 255);
        }
        else
        {
            asamisThere = false;
        }*/

        if (ChilliisThere == true && saltisThere == true && SugarisThere == true && kerisikisThere == true)
        {
            //COMPLETED FOR THIS CATEGORY
            gameComplete = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Chilli(Clone)") //1ST INGREDIENT //CHANGED METHOD TO .gameObject.name SINCE OBJECT IS CLONED AFTER PICKUP
        {
            ChilliCounter++;
            Debug.Log("Chilli COUNTER = " + ChilliCounter);

            Debug.Log("ONE Chilli DETECTED");

            collision.gameObject.SetActive(false);
        }
        /*else if (collision.gameObject.name == "currypowder(Clone)") //1ST INGREDIENT //CHANGED METHOD TO .gameObject.name SINCE OBJECT IS CLONED AFTER PICKUP
        {
            curypowderCounter++;
            Debug.Log("curypowder COUNTER = " + curypowderCounter);

            Debug.Log("ONE curypowder DETECTED");

            collision.gameObject.SetActive(false);
        }
        else if (collision.gameObject.name == "spices(Clone)") //1ST INGREDIENT //CHANGED METHOD TO .gameObject.name SINCE OBJECT IS CLONED AFTER PICKUP
        {
            spicesCounter++;
            Debug.Log("spices COUNTER = " + spicesCounter);

            Debug.Log("ONE spices DETECTED");

            collision.gameObject.SetActive(false);
        }
        else if (collision.gameObject.name == "daunkari(Clone)") //1ST INGREDIENT //CHANGED METHOD TO .gameObject.name SINCE OBJECT IS CLONED AFTER PICKUP
        {
            daunkariCounter++;
            Debug.Log("daunkari COUNTER = " + daunkariCounter);

            Debug.Log("ONE daunkari DETECTED");

            collision.gameObject.SetActive(false);
        }*/
        else if (collision.gameObject.name == "salt(Clone)") //1ST INGREDIENT //CHANGED METHOD TO .gameObject.name SINCE OBJECT IS CLONED AFTER PICKUP
        {
            saltCounter++;
            Debug.Log("salt COUNTER = " + saltCounter);

            Debug.Log("ONE salt DETECTED");

            collision.gameObject.SetActive(false);
        }
        else if (collision.gameObject.name == "Sugar(Clone)") //1ST INGREDIENT //CHANGED METHOD TO .gameObject.name SINCE OBJECT IS CLONED AFTER PICKUP
        {
            SugarCounter++;
            Debug.Log("Sugar COUNTER = " + SugarCounter);

            Debug.Log("ONE Sugar DETECTED");

            collision.gameObject.SetActive(false);
        }
        else if (collision.gameObject.name == "kerisik(Clone)") //1ST INGREDIENT //CHANGED METHOD TO .gameObject.name SINCE OBJECT IS CLONED AFTER PICKUP
        {
            kerisikCounter++;
            Debug.Log("kerisik COUNTER = " + kerisikCounter);

            Debug.Log("ONE kerisik DETECTED");

            collision.gameObject.SetActive(false);
        }
        /*else if (collision.gameObject.name == "asam(Clone)") //1ST INGREDIENT //CHANGED METHOD TO .gameObject.name SINCE OBJECT IS CLONED AFTER PICKUP
        {
            asamCounter++;
            Debug.Log("asam COUNTER = " + asamCounter);

            Debug.Log("ONE asam DETECTED");

            collision.gameObject.SetActive(false);
        }*/
        else
        {
            Debug.Log("WRONG ITEM");
        }

    }
}

