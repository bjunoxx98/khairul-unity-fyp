using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class registerdb : MonoBehaviour
{
    public Text email;
    public Text name;
    public Text password;
    public Text repassword;
    public InputField xxx;
    public InputField rexxx;
    public string passwordxxx;
    public string repasswordxxx;
    public GameObject errormessage;
    public GameObject duplicateerrormessage; 
    public GameObject repassworderror; 
    public GameObject backbutton;
    public GameObject registerbutton;
    public GameObject continuebutton;
    public GameObject successtext;

    public void AddDetails()
    {
        StartCoroutine(AddPlayerDetails());
    }

    //1 ADD PLAYER
    IEnumerator AddPlayerDetails()
    {
        Debug.Log("Adding Details");

        if (string.IsNullOrEmpty(email.text) | string.IsNullOrEmpty(name.text) | string.IsNullOrEmpty(password.text) | string.IsNullOrEmpty(repassword.text)) //check if ALL input field is null or not
        {
            Debug.Log("PLEASE INPUT ALL REQUIRED DETAILS");
            errormessage.SetActive(true);
            repassworderror.SetActive(false);
            duplicateerrormessage.SetActive(false);
        }
        else
        {
            passwordxxx = "";
            passwordxxx = xxx.text;
            repasswordxxx = "";
            repasswordxxx = rexxx.text;

            Debug.Log("Password string = " + passwordxxx);
            Debug.Log("REPassword string = " + repasswordxxx);

            if (passwordxxx == repasswordxxx)    //CHECK IF PASSWORD IS SAME AS RECONFIRM PASSWORD
            {
                errormessage.SetActive(false);
                repassworderror.SetActive(false);
                

                WWWForm form = new WWWForm();
                form.AddField("email", email.text);
                form.AddField("name", name.text);
                form.AddField("password", passwordxxx);
                WWW www = new WWW("yourwebsite.php", form); //change "yourwebsite.php" to your own php file

                yield return www;
                if (www.error != null)
                {
                    Debug.Log(www.error);
                }
                else if (www.text.StartsWith("ERROR"))   //duplicate error
                {
                    Debug.Log("DUPLICATE ENTRY");
                    Debug.Log(www.text);
                    repassworderror.SetActive(false); 
                    duplicateerrormessage.SetActive(true);
                }
                else
                {
                    Debug.Log(www.text);    //success register
                    repassworderror.SetActive(false); 
                    duplicateerrormessage.SetActive(false);
                    backbutton.SetActive(false);
                    registerbutton.SetActive(false);
                    continuebutton.SetActive(true);
                    successtext.SetActive(true);
                }
            }
            else          //IF RECONFIRM PASSWORD IS NOT THE SAME AS PASSWORD
            {
                Debug.Log("RECONFIRM PASSWORD IS NOT THE SAME AS PASSWORD");
                errormessage.SetActive(false); 
                duplicateerrormessage.SetActive(false); 
                repassworderror.SetActive(true);
            }
            
        }
        
    }
}
/*LOG
  *301220 = ADDED ERROR HANDLING IF NO INPUT FOR ALL FIELD *
  *301220 = IMPROVED UI AND GAMEFLOW AFTER SUCCESS REGISTER - USER WILL BE REDIRECTED TO SPECIFIC LOGIN PAGE FOR FIRST TIME LOGIN
  *050121 = TRY TO FIX PASSWORD ARTERISK ISSUE https://stackoverflow.com/questions/56532028/text-of-password-type-inputfield-only-gets-asterisks */
