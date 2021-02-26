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

[RequireComponent(typeof(Button))]
public class LevelButtonActivation : MonoBehaviour
{
    [SerializeField]
    int ID = default;

    public Color color1;
    public Color color2;

    Button button;

    void Awake()
    {
        button = GetComponent<Button>();
    }

    void Start()
    {
        var colors = button.colors;

        colors.normalColor = colors.highlightedColor = PlaySession.Level == ID ? color2 : color1;

        button.colors = colors;
    }

    void OnEnable()
    {
        button.interactable = PlaySession.Level >= ID;
    }
}