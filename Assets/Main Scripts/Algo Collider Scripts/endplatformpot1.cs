using HighlightPlus;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

//NOT IN USE 1601
//FOR DECOMPOSTION STAGE - RENDANG
//NOT IN USE
public class endplatformpot1 : MonoBehaviour
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
    public bool gamePlaying = false;
    public GameObject[] popUps;
    public int popUpIndex;
    public bool step1done = false;
    public bool step2done = false;
    public bool step3done = false;
    public bool step4done = false;
    public bool step5done = false;
    public bool step6done = false;
    public bool step7done = false;
    public bool step8done = false;
    public bool step9done = false;
    public bool step10done = false;
    //public float waitTime = 2f;
    //camera script
    public GameObject headobject; //your other object 
    public string camerascript;

    //highlight script
    public GameObject[] hlobject; //your other object 
    public string hlscript = "HighlightEffect";

    void Start()
    {
        textwrong.SetActive(false);
        (hlobject[0].GetComponent(hlscript) as MonoBehaviour).enabled = true;
    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Oil(Clone)") //1ST INGREDIENT //CHANGED METHOD TO .gameObject.name SINCE OBJECT IS CLONED AFTER PICKUP
        {
            Debug.Log("SETEL STEP 1");
            step1done = true;

            //highlight test
            (hlobject[1].GetComponent(hlscript) as MonoBehaviour).enabled = true;   //next item = garlic

            Debug.Log(collision.gameObject.name); Debug.Log("THIS IS OIL");
            collision.gameObject.SetActive(false);
            textwrong.SetActive(false);
            Destroy(textStep1.gameObject);  //USE DESTORY TO AVOID DISPLAYING IT AGAIN IF THIS OBJECT PUT AFTER THIS
            textStep2.SetActive(true);
            ing1.color = new Color32(31, 255, 0, 255);
        }
        else if (collision.gameObject.name == "garlicwhole(Clone)") //2ND INGREDIENT
        {
            //check if previous step completed first
            if (step1done == true)
            {
                Debug.Log("SETEL STEP 2");
                step2done = true;

                //highlight test
                (hlobject[2].GetComponent(hlscript) as MonoBehaviour).enabled = true;   //next item = onion

                Debug.Log(collision.gameObject.name); Debug.Log("THIS IS GARLIC");
                collision.gameObject.SetActive(false);
                textwrong.SetActive(false);
                Destroy(textStep2.gameObject);
                textStep3.SetActive(true);
                ing2.color = new Color32(31, 255, 0, 255);
            }
            else //IF NOT FOLLOWING INSTRUCTIONS
            {
                collision.gameObject.SetActive(false);
                Debug.Log("WRONG OBJECT HERE");
                Debug.Log(collision.gameObject.name);
                textwrong.SetActive(true);
            }

        }
        else if (collision.gameObject.name == "onion(Clone)") //3RD INGREDIENT
        {
            //check if previous step completed first
            if (step2done == true)
            {
                Debug.Log("SETEL STEP 3");
                step3done = true;

                //highlight test
                (hlobject[3].GetComponent(hlscript) as MonoBehaviour).enabled = true;   //next item = Chilli

                Debug.Log(collision.gameObject.name); Debug.Log("THIS IS ONION");
                collision.gameObject.SetActive(false);
                textwrong.SetActive(false);
                Destroy(textStep3.gameObject);  //USE DESTORY TO AVOID DISPLAYING IT AGAIN IF THIS OBJECT PUT AFTER THIS
                textStep4.SetActive(true);
                ing3.color = new Color32(31, 255, 0, 255);
            }
            else //IF NOT FOLLOWING INSTRUCTIONS
            {
                collision.gameObject.SetActive(false);
                Debug.Log("WRONG OBJECT HERE");
                Debug.Log(collision.gameObject.name);
                textwrong.SetActive(true);
            }
        }
        else if (collision.gameObject.name == "Chilli(Clone)") //4TH INGREDIENT
        {
            //check if previous step completed first
            if (step3done == true)
            {
                Debug.Log("SETEL STEP 4");
                step4done = true;

                //highlight test
                (hlobject[4].GetComponent(hlscript) as MonoBehaviour).enabled = true;   //next item = ginger

                Debug.Log(collision.gameObject.name); Debug.Log("THIS IS CHILLI");
                collision.gameObject.SetActive(false);
                textwrong.SetActive(false);
                Destroy(textStep4.gameObject);  //USE DESTORY TO AVOID DISPLAYING IT AGAIN IF THIS OBJECT PUT AFTER THIS
                textStep5.SetActive(true);
                ing4.color = new Color32(31, 255, 0, 255);
            }
            else //IF NOT FOLLOWING INSTRUCTIONS
            {
                collision.gameObject.SetActive(false);
                Debug.Log("WRONG OBJECT HERE");
                Debug.Log(collision.gameObject.name);
                textwrong.SetActive(true);
            }
        }
        else if (collision.gameObject.name == "ginger(Clone)") //5TH INGREDIENT
        {
            //check if previous step completed first
            if (step4done == true)
            {
                Debug.Log("SETEL STEP 5");
                step5done = true;

                //highlight test
                (hlobject[5].GetComponent(hlscript) as MonoBehaviour).enabled = true;   //next item = chickenv2

                Debug.Log(collision.gameObject.name); Debug.Log("THIS IS GINGER");
                collision.gameObject.SetActive(false);
                textwrong.SetActive(false);
                Destroy(textStep5.gameObject);  //USE DESTORY TO AVOID DISPLAYING IT AGAIN IF THIS OBJECT PUT AFTER THIS
                textStep6.SetActive(true);
                ing5.color = new Color32(31, 255, 0, 255);
            }
            else //IF NOT FOLLOWING INSTRUCTIONS
            {
                collision.gameObject.SetActive(false);
                Debug.Log("WRONG OBJECT HERE");
                Debug.Log(collision.gameObject.name);
                textwrong.SetActive(true);
            }
        }
        else if (collision.gameObject.name == "chickenv2(Clone)") //6TH INGREDIENT
        {
            //check if previous step completed first
            if (step5done == true)
            {
                Debug.Log("SETEL STEP 6");
                step6done = true;

                //highlight test
                (hlobject[6].GetComponent(hlscript) as MonoBehaviour).enabled = true;   //next item = Santan

                Debug.Log(collision.gameObject.name); Debug.Log("THIS IS CHICKEN");
                collision.gameObject.SetActive(false);
                textwrong.SetActive(false);
                Destroy(textStep6.gameObject);  //USE DESTORY TO AVOID DISPLAYING IT AGAIN IF THIS OBJECT PUT AFTER THIS
                textStep7.SetActive(true);
                ing6.color = new Color32(31, 255, 0, 255);
            }
            else //IF NOT FOLLOWING INSTRUCTIONS
            {
                collision.gameObject.SetActive(false);
                Debug.Log("WRONG OBJECT HERE");
                Debug.Log(collision.gameObject.name);
                textwrong.SetActive(true);
            }
        }
        else if (collision.gameObject.name == "Santan(Clone)") //7TH INGREDIENT
        {
            //check if previous step completed first
            if (step6done == true)
            {
                Debug.Log("SETEL STEP 7");
                step7done = true;

                //highlight test
                (hlobject[7].GetComponent(hlscript) as MonoBehaviour).enabled = true;   //next item = kerisik

                Debug.Log(collision.gameObject.name); Debug.Log("THIS IS SANTAN");
                collision.gameObject.SetActive(false);
                textwrong.SetActive(false);
                Destroy(textStep7.gameObject);  //USE DESTORY TO AVOID DISPLAYING IT AGAIN IF THIS OBJECT PUT AFTER THIS
                textStep8.SetActive(true);
                ing7.color = new Color32(31, 255, 0, 255);
            }
            else //IF NOT FOLLOWING INSTRUCTIONS
            {
                collision.gameObject.SetActive(false);
                Debug.Log("WRONG OBJECT HERE");
                Debug.Log(collision.gameObject.name);
                textwrong.SetActive(true);
            }
        }
        else if (collision.gameObject.name == "kerisik(Clone)") //8TH INGREDIENT
        {
            //check if previous step completed first
            if (step7done == true)
            {
                Debug.Log("SETEL STEP 8");
                step8done = true;

                //highlight test
                (hlobject[8].GetComponent(hlscript) as MonoBehaviour).enabled = true;   //next item = salt

                Debug.Log(collision.gameObject.name); Debug.Log("THIS IS KERISIK");
                collision.gameObject.SetActive(false);
                textwrong.SetActive(false);
                Destroy(textStep8.gameObject);  //USE DESTORY TO AVOID DISPLAYING IT AGAIN IF THIS OBJECT PUT AFTER THIS
                textStep9.SetActive(true);
                ing8.color = new Color32(31, 255, 0, 255);
            }
            else //IF NOT FOLLOWING INSTRUCTIONS
            {
                collision.gameObject.SetActive(false);
                Debug.Log("WRONG OBJECT HERE");
                Debug.Log(collision.gameObject.name);
                textwrong.SetActive(true);
            }
        }
        else if (collision.gameObject.name == "salt(Clone)") //9TH INGREDIENT
        {
            //check if previous step completed first
            if (step8done == true)
            {
                Debug.Log("SETEL STEP 9");
                step9done = true;

                //highlight test
                (hlobject[9].GetComponent(hlscript) as MonoBehaviour).enabled = true;   //next item = Sugar

                Debug.Log(collision.gameObject.name); Debug.Log("THIS IS SALT");
                collision.gameObject.SetActive(false);
                textwrong.SetActive(false);
                Destroy(textStep9.gameObject);  //USE DESTORY TO AVOID DISPLAYING IT AGAIN IF THIS OBJECT PUT AFTER THIS
                textStep10.SetActive(true);
                ing9.color = new Color32(31, 255, 0, 255);
            }
            else //IF NOT FOLLOWING INSTRUCTIONS
            {
                collision.gameObject.SetActive(false);
                Debug.Log("WRONG OBJECT HERE");
                Debug.Log(collision.gameObject.name);
                textwrong.SetActive(true);
            }
        }
        else if (collision.gameObject.name == "Sugar(Clone)") //10TH INGREDIENT--LAST
        {
            //check if previous step completed first
            if (step9done == true)
            {
                Debug.Log("SETEL STEP 10");
                step10done = true;

                //highlight test
                (hlobject[10].GetComponent(hlscript) as MonoBehaviour).enabled = true;   //next item = POT

                Debug.Log(collision.gameObject.name); Debug.Log("THIS IS SALT");
                collision.gameObject.SetActive(false);
                textwrong.SetActive(false);
                Destroy(textStep10.gameObject);  //USE DESTORY TO AVOID DISPLAYING IT AGAIN IF THIS OBJECT PUT AFTER THIS
                ing10.color = new Color32(31, 255, 0, 255);

                //GAMEWON FINISH
                //GAMEEND
                Canvas_END.SetActive(true);
                //TIME CONTROL
                timercontroller.instance.EndTimer();

                //gameIsPaused = !gameIsPaused;
                Time.timeScale = 0f;

                //unlock cursor | show cursor
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;

                //disable camera movement script
                (headobject.GetComponent(camerascript) as MonoBehaviour).enabled = false;
            }
            else //IF NOT FOLLOWING INSTRUCTIONS
            {
                collision.gameObject.SetActive(false);
                Debug.Log("WRONG OBJECT HERE");
                Debug.Log(collision.gameObject.name);
                textwrong.SetActive(true);
            }

        }
        else     //if wrong ingredient
        {
            collision.gameObject.SetActive(false);
            Debug.Log("WRONG OBJECT HERE");
            Debug.Log(collision.gameObject.name);
            textwrong.SetActive(true);
        }
    }


    //OTHER METHOD
    //Destroy(collision.gameObject);        //destroy the object
    //collision.gameObject.SetActive(false);  //'disable' the object
    //chickenDestroy();

    //Force/remind coder to use this function for destroying
    /*public void chickenDestroy()
    {
        if (!chicken_isDestroy)
        {
            GameObject.Destroy(chicken);
            chicken_isDestroy = true;
        }
    }

    //Use this function to check
    public bool chickenIsDestroy
    {
        get { return chicken_isDestroy; }
    }

    public void displayUi()
    {
        if (chickenIsDestroy == true)
        {
            textStep2.SetActive(true);
        }
    }*/
}