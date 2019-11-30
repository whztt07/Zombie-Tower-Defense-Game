﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoints3 : MonoBehaviour
{
    public static Transform[] points;

    private void Awake()
    {
        points = new Transform[transform.childCount];
        for (int i = 0; i < points.Length; i++)
        {
            points[i] = transform.GetChild(i);
        }
    }
}
