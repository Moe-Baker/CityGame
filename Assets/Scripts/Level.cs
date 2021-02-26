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

public abstract class Level : MonoBehaviour
{
    public Text PointsText;
    public Text PopulationText;
    public Text BudgetText;

    public Text AssistanceText;
    public Text GeneralText;

    protected IEnumerator TypeSentenceGeneralText(string sentence)
    {

        GeneralText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            GeneralText.text += letter;
            yield return null;
        }
    }

    protected IEnumerator TypeSentenceAssistanceText(string sentence)
    {

        AssistanceText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            AssistanceText.text += letter;
            yield return null;
        }
    }

    // Player Score
    protected void PointCals(int num)
    {
        PointsText.text = (int.Parse(PointsText.text) + num).ToString();
    }

    public int Points
    {
        get
        {
            return int.Parse(PointsText.text);
        }
        set
        {
            PointsText.text = $"{value}";
        }
    }

    protected void PopCals(int num)
    {
        PopulationText.text = PopulationText.text.Remove(PopulationText.text.Length - 1);
        PopulationText.text = (int.Parse(PopulationText.text) + num).ToString() + "%";
    }

    public int Population
    {
        get
        {
            return int.Parse(PopulationText.text.TrimEnd('%'));
        }
        set
        {
            PopulationText.text = $"{value}%";
        }
    }

    protected void BudgetCals(int num)
    {
        BudgetText.text = BudgetText.text.Remove(BudgetText.text.Length - 1);
        BudgetText.text = (int.Parse(BudgetText.text) + num).ToString() + "%";
    }

    public int Budget
    {
        get
        {
            return int.Parse(BudgetText.text.TrimEnd('%'));
        }
        set
        {
            BudgetText.text = $"{value}%";
        }
    }

    public void Next()
    {
        var type = GetType();

        var id = Array.IndexOf(TypeCollection, type) + 2;

        Debug.Log($"{id} | {PlaySession.Level}");

        if (PlaySession.Level < id) PlaySession.Level = id;

        SceneManager.LoadScene("Levels");
    }

    static readonly Type[] TypeCollection = new Type[]
    {
        typeof(Level1),
        typeof(Level2),
        typeof(Level3),
        typeof(Level4),
        typeof(Level5),
        typeof(Level6),
        typeof(Level7),
        typeof(Level8),
    };
}