using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Clock : MonoBehaviour
{
    const float hoursToDegrees = -30, minutesToDegrees = -6, secondsToDegrees = -6;

    [SerializeField]
    Transform hoursPivot = default, minutesPivot = default, secondsPivot = default;


    void Awake()
    {
        hoursPivot.localRotation = Quaternion.Euler(0, 0, hoursToDegrees * DateTime.Now.Hour);
    }

    void Update()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation =
            Quaternion.Euler(0, 0, hoursToDegrees * (int)time.TotalHours);
        minutesPivot.localRotation =
            Quaternion.Euler(0, 0, minutesToDegrees * (int)time.TotalMinutes);
        secondsPivot.localRotation =
            Quaternion.Euler(0, 0, secondsToDegrees * (int)time.TotalSeconds);
    }
}