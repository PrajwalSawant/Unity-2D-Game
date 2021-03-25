using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    float currentTime = 0f;
    [SerializeField] Text Seconds;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        currentTime += 1 * Time.deltaTime;
        Seconds.text = "Time :" + currentTime.ToString("0");
    }
}
