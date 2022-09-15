using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class clock : MonoBehaviour
{
    public GameObject timeTextObject;

    public DateTime GetEasternStandardTime(DateTime from)
    {
        //find TimeZoneInfo
        TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
        //Convert time from Local to EDT
        return TimeZoneInfo.ConvertTime(from, TimeZoneInfo.Local, tzi);
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("UpdateTime", 0f, 10f);
    }

    void UpdateTime()
    {
        timeTextObject.GetComponent<TextMeshPro>().text = GetEasternStandardTime(DateTime.Now).ToString("HH:mm");

    }
}
