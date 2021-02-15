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

public static class PlaySession
{
    public static int Points
    {
        get => PlayerPrefs.GetInt(nameof(Points), 0);
        set => PlayerPrefs.SetInt(nameof(Points), value);
    }

    public static int Population
    {
        get => PlayerPrefs.GetInt(nameof(Population), 10);
        set => PlayerPrefs.SetInt(nameof(Population), value);
    }

    public static int Budget
    {
        get => PlayerPrefs.GetInt(nameof(Budget), 100);
        set => PlayerPrefs.SetInt(nameof(Budget), value);
    }

    public static int Level
    {
        get => PlayerPrefs.GetInt(nameof(Level), 1);
        set => PlayerPrefs.SetInt(nameof(Level), value);
    }

    public static void Clear()
    {
        Points = 0;
        Population = 10;
        Budget = 100;
        Level = 1;
    }
}