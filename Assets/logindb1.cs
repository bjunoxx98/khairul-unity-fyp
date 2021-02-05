using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEditor;

//17 1011 - TRY NOT USE THIS ONE ON LOGIN PAGE (REGISTER)
public class logindb1 : MonoBehaviour
{
    public Text email;
    public Text name;
    public Text score;
    public Text password;
    public GameObject loginfirsttime;
    public GameObject errormessage;
    public GameObject errormessage2;
    public GameObject okmessage;
    public GameObject nameInput;
    public GameObject nametext;
    public GameObject loginbutton;
    public GameObject backbutton;
    public GameObject ContinueButton;
    public static string getemail;

    public void GetDetails()
    {
        StartCoroutine(RetrievePlayerDetails());
    }

    //2 RETRIEVE PLAYER
    IEnumerator RetrievePlayerDetails()
    {
        Debug.Log("Retrieving Details");

        if (string.IsNullOrEmpty(email.text) | string.IsNullOrEmpty(password.text)) //check if both input field is null or not
        {
            Debug.Log("PLEASE INPUT EMAIL AND PASSWORD");
            errormessage.SetActive(false);
            okmessage.SetActive(false);
            errormessage2.SetActive(true);
        }
        else
        {
            errormessage2.SetActive(false);

            WWWForm form = new WWWForm();
            form.AddField("email", email.text);
            form.AddField("password", password.text);
            WWW www = new WWW("yourwebsite.php", form); //change "yourwebsite.php" to your own php file

            yield return www;
            if (www.error != null)
            {
                Debug.Log(www.error);
            }
            else
            {
                if (www.text == "No records found.")    //no record found or wrong password
                {
                    Debug.Log("option 1");
                    Debug.Log(www.text);
                    errormessage.SetActive(true);
                    okmessage.SetActive(false);
                    nameInput.SetActive(false);
                    nametext.SetActive(false);
                }
                else if (www.text.StartsWith("ERROR: Could"))   //error
                {
                    Debug.Log("option 2");
                    Debug.Log(www.text);
                    errormessage.SetActive(true);
                    okmessage.SetActive(false);
                    nameInput.SetActive(false);
                    nametext.SetActive(false);
                }
                else
                {
                    Debug.Log("option 3");  //success login
                    //static variable
                    getemail = email.text;

                    Debug.Log(www.text);
                    okmessage.SetActive(true);
                    errormessage.SetActive(false);

                    string[] details = www.text.Split('|');
                    name.transform.parent.GetComponent<InputField>().text = details[0];
                    if (details.Length > 2)
                    {
                        score.transform.parent.GetComponent<InputField>().text = details[1];
                    }

                    nameInput.SetActive(true);
                    nametext.SetActive(true);
                    loginbutton.SetActive(false);
                    backbutton.SetActive(false);
                    ContinueButton.SetActive(true);
                }
            }
        }


    }
}
/*LOG
  *301220 = ADDED ERROR HANDLING IF NO INPUT FOR EMAIL OR PASSWORD */

