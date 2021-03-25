using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ambient_SOund : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
