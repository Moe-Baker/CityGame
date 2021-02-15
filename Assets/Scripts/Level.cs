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

    protected virtual void Awake()
    {
        Points = PlaySession.Points;
        Population = PlaySession.Population;
        Budget = PlaySession.Budget;
    }

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
        PlaySession.Points = Points;
        PlaySession.Population = Population;
        PlaySession.Budget = Budget;

        switch (this)
        {
            case Level8 level:
                PlaySession.Clear();
                SceneManager.LoadScene("Levels");
                break;

            default:
                var current = int.Parse(GetType().Name.Replace("Level", ""));
                PlaySession.Level = current + 1;
                SceneManager.LoadScene($"Level{current + 1}");
                break;
        }
    }
}