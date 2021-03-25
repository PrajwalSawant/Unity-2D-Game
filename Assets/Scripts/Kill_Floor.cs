using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill_Floor : MonoBehaviour
{
    int a = 0;
    [SerializeField] Transform spwanPoint;

    private void OnCollisionEnter2D(Collision2D col)
    {
       

        if(a==5)
        {
          SceneManager.LoadScene("Main_Menu");
            a = 0;
        }
        else if (col.transform.CompareTag("Player"))
        {
            Debug.Log("A="+a.ToString());
            a++;
            col.transform.position = spwanPoint.position;
        }
    }
}
