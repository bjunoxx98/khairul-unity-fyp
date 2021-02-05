using HighlightPlus;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

//FOR ALGO STAGE - CHICKEN RENDANG 
public class endplatformpot : MonoBehaviour
{
    public GameObject Canvas_END;
    public GameObject textStep1;
    public GameObject textStep2;
    public GameObject textStep3;
    public GameObject textStep4;
    public GameObject textStep5;
    public GameObject textStep6;
    public GameObject textStep7;
    public GameObject textStep8;
    public GameObject textStep9;
    public GameObject textStep10;
    public GameObject textwrong;
    public GameObject waterFX;
    public GameObject ikanFX;
    public GameObject oilFX;
    public Text ing1;
    public Text ing2;
    public Text ing3;
    public Text ing4;
    public Text ing5;
    public Text ing6;
    public Text ing7;
    public Text ing8;
    public Text ing9;
    public Text ing10;
    [HideInInspector] public bool gamePlaying = false;
    //public GameObject[] popUps;
    public int popUpIndex;
    [HideInInspector] public bool step1done = false;
    [HideInInspector] public bool step2done = false;
    [HideInInspector] public bool step3done = false;
    [HideInInspector] public bool step4done = false;
    [HideInInspector] public bool step5done = false;
    [HideInInspector] public bool step6done = false;
    [HideInInspector] public bool step7done = false;
    [HideInInspector] public bool step8done = false;
    [HideInInspector] public bool step9done = false;
    [HideInInspector] public bool step10done = false;
    //public float waitTime = 2f;
    //camera script
    public GameObject headobject; //your other object 
    public string camerascript;

    [HideInInspector] public bool stageComplete = false;
    [HideInInspector] public bool terminategame = false;

    void Start()
    {
        textwrong.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        if (collision.gameObject.name == "Oil(Clone)") //1ST INGREDIENT //CHANGED METHOD TO .gameObject.name SINCE OBJECT IS CLONED AFTER PICKUP
        {
            if (step1done == false)
            {
                Debug.Log("SETEL STEP 1");
                step1done = true;
                oilFX.SetActive(true);    //OIL FX

                Debug.Log(collision.gameObject.name); Debug.Log("THIS IS OIL");
                collision.gameObject.SetActive(false);
                textwrong.SetActive(false);
                Destroy(textStep1.gameObject);  //USE DESTORY TO AVOID DISPLAYING IT AGAIN IF THIS OBJECT PUT AFTER THIS
                textStep2.SetActive(true);
                ing1.color = new Color32(31, 255, 0, 255);
            }
            else //IF NOT FOLLOWING INSTRUCTIONS
            {
                terminategame = true;
                collision.gameObject.SetActive(false);
                Debug.Log("WRONG OBJECT HERE");
                Debug.Log(collision.gameObject.name);
                textwrong.SetActive(true);
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        else if (collision.gameObject.name == "garlicwhole(Clone)") //2ND INGREDIENT
        {
            //check if previous step completed first
            if (step1done == true)
            {
                Debug.Log("SETEL STEP 2");
                step2done = true;

                Debug.Log(collision.gameObject.name); Debug.Log("THIS IS GARLIC");
                collision.gameObject.SetActive(false);
                textwrong.SetActive(false);
                Destroy(textStep2.gameObject);
                textStep3.SetActive(true);
                ing2.color = new Color32(31, 255, 0, 255);
            }
            else //IF NOT FOLLOWING INSTRUCTIONS
            {
                terminategame = true;
                collision.gameObject.SetActive(false);
                Debug.Log("WRONG OBJECT HERE");
                Debug.Log(collision.gameObject.name);
                textwrong.SetActive(true);
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        else if (collision.gameObject.name == "onion(Clone)") //3RD INGREDIENT
        {
            //check if previous step completed first
            if (step2done == true)
            {
                Debug.Log("SETEL STEP 3");
                step3done = true;

                Debug.Log(collision.gameObject.name); Debug.Log("THIS IS ONION");
                collision.gameObject.SetActive(false);
                textwrong.SetActive(false);
                Destroy(textStep3.gameObject);  //USE DESTORY TO AVOID DISPLAYING IT AGAIN IF THIS OBJECT PUT AFTER THIS
                textStep4.SetActive(true);
                ing3.color = new Color32(31, 255, 0, 255);
            }
            else //IF NOT FOLLOWING INSTRUCTIONS
            {
                terminategame = true;
                collision.gameObject.SetActive(false);
                Debug.Log("WRONG OBJECT HERE");
                Debug.Log(collision.gameObject.name);
                textwrong.SetActive(true);
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        else if (collision.gameObject.name == "Chilli(Clone)") //4TH INGREDIENT
        {
            //check if previous step completed first
            if (step3done == true)
            {
                Debug.Log("SETEL STEP 4");
                step4done = true;

                Debug.Log(collision.gameObject.name); Debug.Log("THIS IS CHILLI");
                collision.gameObject.SetActive(false);
                textwrong.SetActive(false);
                Destroy(textStep4.gameObject);  //USE DESTORY TO AVOID DISPLAYING IT AGAIN IF THIS OBJECT PUT AFTER THIS
                textStep5.SetActive(true);
                ing4.color = new Color32(31, 255, 0, 255);
            }
            else //IF NOT FOLLOWING INSTRUCTIONS
            {
                terminategame = true;
                collision.gameObject.SetActive(false);
                Debug.Log("WRONG OBJECT HERE");
                Debug.Log(collision.gameObject.name);
                textwrong.SetActive(true);
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        else if (collision.gameObject.name == "ginger(Clone)") //5TH INGREDIENT
        {
            //check if previous step completed first
            if (step4done == true)
            {
                Debug.Log("SETEL STEP 5");
                step5done = true;

                Debug.Log(collision.gameObject.name); Debug.Log("THIS IS GINGER");
                collision.gameObject.SetActive(false);
                textwrong.SetActive(false);
                Destroy(textStep5.gameObject);  //USE DESTORY TO AVOID DISPLAYING IT AGAIN IF THIS OBJECT PUT AFTER THIS
                textStep6.SetActive(true);
                ing5.color = new Color32(31, 255, 0, 255);
            }
            else //IF NOT FOLLOWING INSTRUCTIONS
            {
                terminategame = true;
                collision.gameObject.SetActive(false);
                Debug.Log("WRONG OBJECT HERE");
                Debug.Log(collision.gameObject.name);
                textwrong.SetActive(true);
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        else if (collision.gameObject.name == "chickenv2(Clone)") //6TH INGREDIENT
        {
            //check if previous step completed first
            if (step5done == true)
            {
                Debug.Log("SETEL STEP 6");
                step6done = true;
                waterFX.SetActive(true);    //water FX
                ikanFX.SetActive(true);    //chicken FX

                Debug.Log(collision.gameObject.name); Debug.Log("THIS IS CHICKEN");
                collision.gameObject.SetActive(false);
                textwrong.SetActive(false);
                Destroy(textStep6.gameObject);  //USE DESTORY TO AVOID DISPLAYING IT AGAIN IF THIS OBJECT PUT AFTER THIS
                textStep7.SetActive(true);
                ing6.color = new Color32(31, 255, 0, 255);
            }
            else //IF NOT FOLLOWING INSTRUCTIONS
            {
                terminategame = true;
                collision.gameObject.SetActive(false);
                Debug.Log("WRONG OBJECT HERE");
                Debug.Log(collision.gameObject.name);
                textwrong.SetActive(true);
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        else if (collision.gameObject.name == "Santan(Clone)") //7TH INGREDIENT
        {
            //check if previous step completed first
            if (step6done == true)
            {
                Debug.Log("SETEL STEP 7");
                step7done = true;

                Debug.Log(collision.gameObject.name); Debug.Log("THIS IS SANTAN");
                collision.gameObject.SetActive(false);
                textwrong.SetActive(false);
                Destroy(textStep7.gameObject);  //USE DESTORY TO AVOID DISPLAYING IT AGAIN IF THIS OBJECT PUT AFTER THIS
                textStep8.SetActive(true);
                ing7.color = new Color32(31, 255, 0, 255);
            }
            else //IF NOT FOLLOWING INSTRUCTIONS
            {
                terminategame = true;
                collision.gameObject.SetActive(false);
                Debug.Log("WRONG OBJECT HERE");
                Debug.Log(collision.gameObject.name);
                textwrong.SetActive(true);
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        else if (collision.gameObject.name == "kerisik(Clone)") //8TH INGREDIENT
        {
            //check if previous step completed first
            if (step7done == true)
            {
                Debug.Log("SETEL STEP 8");
                step8done = true;

                Debug.Log(collision.gameObject.name); Debug.Log("THIS IS KERISIK");
                collision.gameObject.SetActive(false);
                textwrong.SetActive(false);
                Destroy(textStep8.gameObject);  //USE DESTORY TO AVOID DISPLAYING IT AGAIN IF THIS OBJECT PUT AFTER THIS
                textStep9.SetActive(true);
                ing8.color = new Color32(31, 255, 0, 255);
            }
            else //IF NOT FOLLOWING INSTRUCTIONS
            {
                terminategame = true;
                collision.gameObject.SetActive(false);
                Debug.Log("WRONG OBJECT HERE");
                Debug.Log(collision.gameObject.name);
                textwrong.SetActive(true);
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        else if (collision.gameObject.name == "salt(Clone)") //9TH INGREDIENT
        {
            //check if previous step completed first
            if (step8done == true)
            {
                Debug.Log("SETEL STEP 9");
                step9done = true;

                Debug.Log(collision.gameObject.name); Debug.Log("THIS IS SALT");
                collision.gameObject.SetActive(false);
                textwrong.SetActive(false);
                Destroy(textStep9.gameObject);  //USE DESTORY TO AVOID DISPLAYING IT AGAIN IF THIS OBJECT PUT AFTER THIS
                textStep10.SetActive(true);
                ing9.color = new Color32(31, 255, 0, 255);
            }
            else //IF NOT FOLLOWING INSTRUCTIONS
            {
                terminategame = true;
                collision.gameObject.SetActive(false);
                Debug.Log("WRONG OBJECT HERE");
                Debug.Log(collision.gameObject.name);
                textwrong.SetActive(true);
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        else if (collision.gameObject.name == "Sugar(Clone)") //10TH INGREDIENT--LAST
        {
            //check if previous step completed first
            if (step9done == true)
            {
                Debug.Log("SETEL STEP 10");
                step10done = true;

                Debug.Log(collision.gameObject.name); Debug.Log("THIS IS SALT");
                collision.gameObject.SetActive(false);
                textwrong.SetActive(false);
                Destroy(textStep10.gameObject);  //USE DESTORY TO AVOID DISPLAYING IT AGAIN IF THIS OBJECT PUT AFTER THIS
                ing10.color = new Color32(31, 255, 0, 255);

                stageComplete = true;   //to be sent to gameflow SCRIPT
            }
            else //IF NOT FOLLOWING INSTRUCTIONS
            {
                terminategame = true;
                collision.gameObject.SetActive(false);
                Debug.Log("WRONG OBJECT HERE");
                Debug.Log(collision.gameObject.name);
                textwrong.SetActive(true);
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        else     //if wrong ingredient
        {
            terminategame = true;
            collision.gameObject.SetActive(false);
            Debug.Log("WRONG OBJECT HERE");
            Debug.Log(collision.gameObject.name);
            textwrong.SetActive(true);
        }
    }










































}