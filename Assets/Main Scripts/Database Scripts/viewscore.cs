using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class viewscore : MonoBehaviour
{
    /*public Text email;
    public Text upd_name;
    public Text score;
    public Text upd_password;*/
    //public GameObject passInput; 
    /*public GameObject successmessage;
    public GameObject noinputmessage;*/

    public GameObject failedmessage;

    public logindb loginscript;

    //column 1 - level 1
    public string score1_1 = "";
    public Text score1_1text;
    public string score2_1 = "";
    public Text score2_1text;
    public string score3_1 = "";
    public Text score3_1text;
    public string score4_1 = "";
    public Text score4_1text;
    //column 2 - level 2
    public string score1_2 = "";
    public Text score1_2text;
    public string score2_2 = "";
    public Text score2_2text;
    public string score3_2 = "";
    public Text score3_2text;
    public string score4_2 = "";
    public Text score4_2text;
    //column 3 - level 3
    public string score1_3 = "";
    public Text score1_3text;
    public string score2_3 = "";
    public Text score2_3text;
    public string score3_3 = "";
    public Text score3_3text;
    public string score4_3 = "";
    public Text score4_3text;

    private void Start()
    {
        GetDetails();
    }

    public void GetDetails()
    {
        StartCoroutine(RetrievePlayerDetails());
        //SceneManager.LoadScene(20);
    }

    //3 UPDATE PLAYER
    IEnumerator RetrievePlayerDetails()
    {
        Debug.Log("Getting Score");

        string emailvalue = logindb.getemail;

        WWWForm form = new WWWForm();
        form.AddField("email", emailvalue);

        WWW www = new WWW("yourwebsite.php", form); //change "yourwebsite.php" to your own php file

        yield return www;
        if (www.error != null)
        {
            Debug.Log(www.error);
            failedmessage.SetActive(true);
            score1_1text.GetComponent<Text>().enabled = false;
            score2_1text.GetComponent<Text>().enabled = false;
            score3_1text.GetComponent<Text>().enabled = false;
            score4_1text.GetComponent<Text>().enabled = false;

            score1_2text.GetComponent<Text>().enabled = false;
            score2_2text.GetComponent<Text>().enabled = false;
            score3_2text.GetComponent<Text>().enabled = false;
            score4_2text.GetComponent<Text>().enabled = false;

            score1_3text.GetComponent<Text>().enabled = false;
            score2_3text.GetComponent<Text>().enabled = false;
            score3_3text.GetComponent<Text>().enabled = false;
            score4_3text.GetComponent<Text>().enabled = false;
        }
        else
        {
            failedmessage.SetActive(false);
            //-------------------------------------
            Debug.Log(www.text);
            string[] details = www.text.Split('|');
            Debug.Log("COLUMN 1");
            Debug.Log(details[0]);
            Debug.Log(details[1]);
            Debug.Log(details[2]);
            Debug.Log(details[3]);
            Debug.Log("COLUMN 2");
            Debug.Log(details[4]);
            Debug.Log(details[5]);
            Debug.Log(details[6]);
            Debug.Log(details[7]);
            Debug.Log("COLUMN 3");
            Debug.Log(details[8]);
            Debug.Log(details[9]);
            Debug.Log(details[10]);
            Debug.Log(details[11]);

            //1st scdecomp1             ------------------1ST COLUMN---------------
            score1_1 = "";   //clear first
            score1_1 += details[0];    //from www.text
            print(score1_1);
            score1_1text.text = score1_1;

            //2ND scdecomp2
            score2_1 = "";   //clear first
            score2_1 += details[1];    //from www.text
            print(score2_1);
            score2_1text.text = score2_1;

            //3RD scdecomp3
            score3_1 = "";   //clear first
            score3_1 += details[2];    //from www.text
            print(score3_1);
            score3_1text.text = score3_1;

            //4TH scpattern1
            score4_1 = "";   //clear first
            score4_1 += details[3];    //from www.text
            print(score4_1);
            score4_1text.text = score4_1;

            //1st scpattern2             ------------------2ND COLUMN---------------
            score1_2 = "";   //clear first
            score1_2 += details[4];    //from www.text
            print(score1_2);
            score1_2text.text = score1_2;

            //2ND scpattern3
            score2_2 = "";   //clear first
            score2_2 += details[5];    //from www.text
            print(score2_2);
            score2_2text.text = score2_2;

            //3RD scabstract1
            score3_2 = "";   //clear first
            score3_2 += details[6];    //from www.text
            print(score3_2);
            score3_2text.text = score3_2;

            //4TH scabstract2
            score4_2 = "";   //clear first
            score4_2 += details[7];    //from www.text
            print(score4_2);
            score4_2text.text = score4_2;

            //1st scabstract3             ------------------3RD COLUMN---------------
            score1_3 = "";   //clear first
            score1_3 += details[8];    //from www.text
            print(score1_3);
            score1_3text.text = score1_3;

            //2ND scalgo1
            score2_3 = "";   //clear first
            score2_3 += details[9];    //from www.text
            print(score2_3);
            score2_3text.text = score2_3;

            //3RD scalgo2
            score3_3 = "";   //clear first
            score3_3 += details[10];    //from www.text
            print(score3_3);
            score3_3text.text = score3_3;

            //4TH scalgo3
            score4_3 = "";   //clear first
            score4_3 += details[11];    //from www.text
            print(score4_3);
            score4_3text.text = score4_3;

            score1_1text.GetComponent<Text>().enabled = true;
            score2_1text.GetComponent<Text>().enabled = true;
            score3_1text.GetComponent<Text>().enabled = true;
            score4_1text.GetComponent<Text>().enabled = true;

            score1_2text.GetComponent<Text>().enabled = true;
            score2_2text.GetComponent<Text>().enabled = true;
            score3_2text.GetComponent<Text>().enabled = true;
            score4_2text.GetComponent<Text>().enabled = true;

            score1_3text.GetComponent<Text>().enabled = true;
            score2_3text.GetComponent<Text>().enabled = true;
            score3_3text.GetComponent<Text>().enabled = true;
            score4_3text.GetComponent<Text>().enabled = true;
        }
    }
}


