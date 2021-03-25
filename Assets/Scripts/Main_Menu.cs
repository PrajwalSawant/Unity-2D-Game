using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start_Button()
    {
        SceneManager.LoadScene("Game");
    }
    public void End_Button()
    {
        Application.Quit();
    }
    //public void Show_Table()
    //{
    //    SceneManager.LoadScene("Highscore_Table");
    //}


}