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
    public static int Level
    {
        get => PlayerPrefs.GetInt(nameof(Level), 1);
        set => PlayerPrefs.SetInt(nameof(Level), value);
    }
}