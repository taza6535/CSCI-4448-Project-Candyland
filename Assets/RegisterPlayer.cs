using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Networking;
//code based off of: https://www.youtube.com/watch?v=SKbY-0zt2VE&ab_channel=BoardToBitsGames
//code based off of: https://www.youtube.com/watch?v=4W90-mh70JY&t=1389s&ab_channel=BoardToBitsGames 
public class RegisterPlayer : MonoBehaviour
{
    public TMP_InputField nameField;
    public Button submitButton;

    public void CallRegister(){
        StartCoroutine(Register());
    }

    IEnumerator Register(){
        Debug.Log("In register");
        WWWForm form = new WWWForm();
        form.AddField("username", nameField.text);
        UnityWebRequest www = UnityWebRequest.Post("http://localhost:8888/sqlconnect/register.php", form);
        yield return www.SendWebRequest();
        if(www.result == UnityWebRequest.Result.Success){
            Debug.Log("User created successfully.");
            SceneManager.LoadScene(3);
        }
        else{
            Debug.Log("User creation failed. Error #" + www.error);
        }
    }

    public void verifyInputs(){
        submitButton.interactable = (nameField.text.Length <= 10);
    }
}
