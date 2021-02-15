using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

#if UNITY_EDITOR
using UnityEditor;
using UnityEditorInternal;
#endif

using Object = UnityEngine.Object;
using Random = UnityEngine.Random;

public class PlaySession
{
    static PlaySession data = null;
    public static PlaySession Data
    {
        get
        {
            if (data == null) Start();

            return data;
        }
    }

    public int points;
    public int population;
    public int budget;

    public static void Start()
    {
        data = new PlaySession()
        {
            points = 0,
            budget = 100,
            population = 10,
        };
    }

    public static void Clear()
    {
        data = null;
    }
}