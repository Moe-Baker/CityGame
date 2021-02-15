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
        Points = PlaySession.Data.points;
        Population = PlaySession.Data.population;
        Budget = PlaySession.Data.budget;
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

        PlaySession.Data.points = Points;
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

        PlaySession.Data.population = Population;
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

        PlaySession.Data.budget = Budget;
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
        switch (this)
        {
            case Level8 level:
                SceneManager.LoadScene("Levels");
                break;

            default:
                var current = int.Parse(GetType().Name.Replace("Level", ""));
                SceneManager.LoadScene($"Level{current + 1}");
                break;
        }
    }
}