using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updatedetail : MonoBehaviour
{
    public Text email;
    public Text upd_name;
    public Text score;
    public Text upd_password;
    //public GameObject passInput; 
    public GameObject successmessage; 
    public GameObject failedmessage; 
    public GameObject noinputmessage; 
    public logindb loginscript;
    public string MyText = "";
    public Text text;

    public void UpdateDetails()
    {
        StartCoroutine(UpdatePlayerDetails());
    }

    //3 UPDATE PLAYER
    IEnumerator UpdatePlayerDetails()
    {
        if (string.IsNullOrEmpty(upd_name.text))//check if both input field is null or not
        {
            noinputmessage.SetActive(true);
            successmessage.SetActive(false);
            failedmessage.SetActive(false);
            Debug.Log("NO INPUT");
            text.GetComponent<Text>().enabled = false;
        }
        else
        {
            Debug.Log("Updating Details");

            string emailvalue = logindb.getemail;

            WWWForm form = new WWWForm();
            form.AddField("email", emailvalue);
            form.AddField("name", upd_name.text);
            WWW www = new WWW("yourwebsite.php", form); //change "yourwebsite.php" to your own php file

            yield return www;
            if (www.error != null)
            {
                Debug.Log(www.error);
                //passInput.SetActive(false);
                noinputmessage.SetActive(false);
                successmessage.SetActive(false);
                failedmessage.SetActive(true);
                text.GetComponent<Text>().enabled = false;
            }
            else
            {
                text.GetComponent<Text>().enabled = true;
                MyText = "";   //clear first
                MyText += "Changed Name To : "+upd_name.text;
                print(MyText);
                text.text = MyText;
                Debug.Log(text.text);

                Debug.Log(www.text);
                //passInput.SetActive(true);
                successmessage.SetActive(true);
                failedmessage.SetActive(false);
                noinputmessage.SetActive(false);
                //newname.SetA
            }
        }
        
            
            
    }
}
