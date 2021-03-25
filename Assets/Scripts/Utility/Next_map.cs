using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next_map : MonoBehaviour
{
    [SerializeField] Transform spwanPoint;

    private void OnCollisionEnter2D(Collision2D col)
    {

        if(GameManager.Instance.KeyToCastle)
        {
            SceneManager.LoadScene("Main_Menu");
        }
        else
        {
            col.transform.position = spwanPoint.position;
        }
    }
}
