using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField]
    Transform hoursPivot, minutesPivot, secondsPivot;
    
    private void Awake() 
    {
        hoursPivot.localRotation = Quaternion.Euler(0, 0, -30);
        minutesPivot.localRotation = Quaternion.Euler(0, 0, 0);
        secondsPivot.localRotation = Quaternion.Euler(0, 0, 0);
    }
// Start is called before the first frame update
void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(DateTime.Now.Hour);
        hoursPivot.localRotation = Quaternion.Euler(0, 0, -30 * DateTime.Now.Hour); //(1-12) (360/12=30)
        minutesPivot.localRotation = Quaternion.Euler(0, 0, -6 * DateTime.Now.Minute); //(1-60) (360/60=6)
        secondsPivot.localRotation = Quaternion.Euler(0, 0, -6 * DateTime.Now.Second); //(1-60) (360/60=6)
    }
}
