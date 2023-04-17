using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene(5);
    }
    public void ShowLeaderboard ()
    {
        SceneManager.LoadScene(2);
    }
    public void CreateNewPlayer ()
    {
        SceneManager.LoadScene(4);
    }
}
