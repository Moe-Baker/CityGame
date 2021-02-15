using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level6 : MonoBehaviour
{

    public Text PointsText;
    public Text PopulationText;
    public Text BudgetText;

    public Text FinalResultPointsText;
    public Text FinalResultPopulationText;


    public GameObject PlayerScore;
    public GameObject FinalReuslt;



    public int CurrentState = 0;
    public GameObject IsAssistanceGeneralTextVisible;

    public GameObject IsGeneralTextVisible;
    public GameObject IsGeneralNextButtonVisible;
    public GameObject IsGeneralYesButtonVisible;
    public GameObject IsGeneralNoButtonVisible;

    public GameObject IsAssistanceNextButtonVisible;

    public GameObject IsD1Visible;
    public GameObject IsD1OptionsVisible;

    public GameObject IsD2Visible;
    public GameObject IsD2OptionsVisible;


    public GameObject IsD3Visible;
    public GameObject IsD3OptionsVisible;


    public Text AssistanceText;
    public Text GeneralText;



    string[] Talks = new string[100];
    public Level6()
    {



        Talks[1] = "كرﺎﺸﺘﺴﻣ ﻦﻣ ةدراو ةﺪﻳﺪﺟ  ﺔﻟﺎﺳر ةءاﺮﻘﺑ ﺪﻳﺪﺠﻟا ﻚﻣﺎﻋ حﺎﺒﺻ أﺪﺒﺗ";
        Talks[2] = "!ﻢﻴﻠﻗﻹا ﻦﻋ ﻻوﺆﺴﻣ ﻚﻨﻴﻴﻌﺗ راﺮﻘﺑ ﺖﻌﻤﺳ ﺪﻘﻟ !ﺔﻳﺬﻴﻔﻨﺘﻟا ﻚﺘﻄﻠﺳ ﺔﻌﻗر ﺖﻌﺳﻮﺗ ﺪﻘﻟ !ﺎﻨﻴﻧﺎﻬﺗ";
        Talks[3] = "!ﻲﻘﻳﺪﺻ ﻖﻴﻓﻮﺘﻟﺎﺑ !ﺔﻴﻟوﺆﺴﻤﻠﻟ ﻞﻫأ ﺖﻧأ ﻖﻠﻘﺗ ﻻ ،بﻮﻠﻄﻣ ﻮﻫ ﺎﻤﻣ ﻞﻀﻓﺄﺑ مﺎﻴﻘﻟا ﯽﻠﻋ ﻚﺗرﺪﻗ ﻲﻓ ﻖﺛاو ﺎﻧأ";


        //Show Char and start
        Talks[4] = "ﻚﺋﺎﻘﻠﺑ ترﺮﺳ ،ﻚﺗرﺎﺸﺘﺴﻣ كزﺎﻧ ﺎﻧأ ،يﺪﻴﺳ ﺮﻴﺨﻟا حﺎﺒﺻ";
        Talks[5] = "!ﻚﻌﻣ ﻞﻤﻌﻠﻟ ﻊﻠﻄﺘﻧ ﺎﻨﻫ ﺎﻨﻌﻴﻤﺟ و ،ﺔﻳﻻﻮﻟا ﻲﻓ ﻲﻓ ﻚﺗازﺎﺠﻧﺎﺑ ﺎﻌﻴﻤﺟ ﺎﻨﻌﻤﺳ ﺪﻘﻟ";
        Talks[6] = " !رﻮﻔﻟا ﯽﻠﻋ أﺪﺒﻨﻠﻓ !ﺔﺴﻤﺤﺘﻣ ﺎﻧأ ..ﻞﻛ ﯽﻠﻋ ";
        Talks[7] = "مﺎﻌﻟا اﺬﻬﻟ ةﺪﻳﺪﺟ ﺔﻄﺧ ﻊﺿو ﻦﻣ ﻦﻜﻤﺘﻧ ﯽﺘﺣ ﻖﺑﺎﺴﻟا مﺎﻌﻟا ﻲﻓ ﻢﻴﻠﻗﻹا ﻞﻛﺎﺸﻣ ضاﺮﻌﺘﺳﺎﺑ مﻮﻗﺄﺳ";

        Talks[8] = "ﯽﻠﻋ ﻞﻤﻌﻧ نا ﺐﺠﻳ ﻪﻧا ﺪﻘﺘﻋا";

        // D1Option 1
        Talks[9] = "؟تﺎﻴﻔﺸﺘﺴﻤﻟا ﺔﻠﻜﺸﻣ ﻞﺣ ﯽﻠﻋ ﻞﻤﻌﻟﺎﺑ أﺪﺒﻧ نأ ﻦﻜﻤﻳ ﻦﻳأ ﻦﻣ";

        // Option 1 - 1
        Talks[10] = "عوﺮﺸﻤﻠﻟ ﻂﻴﻄﺨﺘﻟا ﯽﻠﻋ ﻞﻤﻌﻟﺎﺑ مﻮﻘﺘﻟ تاءﺎﻔﻛ ﻦﻣ ﺔﻨﺠﻟ ﺎﻘﺣﻻ ﻦﻴﻌﻨﻟ …اذإ ﻞﻴﻤﺟ";
        Talks[11] = "  ﺬﻴﻔﻨﺘﻟا ﯽﻠﻋ صﺮﺤﻟا نﻵا ﺎﻨﻴﻠﻋ نﻮﻜﻴﺳ ،ﺔﻴﻧاﺰﻴﻤﻟا ﻦﻣ ﻊﻳرﺎﺸﻤﻟا ﺐﻴﺼﻧ ﻲﻬﺘﻨﻳ ﺎﻨﻫ ﯽﻟإ !ًﺎﻨﺴﺣ";
        Talks[12] = "!ﺔﻤﻜﺣ ﺮﺜﻛﻷا ﻖﻳﺮﻄﻟا ﺎﻨﻜﻠﺳ ﺪﻗ ﺎﻨﻧأ ﻲﻠﺼﻨﻠﻓ !مﺎﻌﻟا ﺔﻳﺎﻬﻧ ﯽﺘﺣ";

        // Opton 1 - 2
        Talks[13] = "عوﺮﺸﻤﻠﻟ ﻂﻴﻄﺨﺘﻟا ﯽﻠﻋ ﻞﻤﻌﻠﻟ ﺔﻨﺠﻟ ﻦﻳﻮﻜﺗ ﯽﻠﻋ ﺎﻘﺣﻻ ﻞﻤﻌﻨﻠﻓ !ًﺎﻌﺋار ارﺎﻴﺧ وﺪﺒﻳ";


        // Option 2

        Talks[14] = "؟سراﺪﻤﻟا ﺔﻠﻜﺸﻣ ﻞﺤﻟ أﺪﺒﻧ نأ ﻦﻜﻤﻳ ﻦﻳأ ﻦﻣ";

        Talks[15] = "ﺎﻳﻮﻨﺳ ﻪﻓﺮﺻ راﺮﻗ جاﺮﺨﺘﺳﻻ ﻎﻠﺒﻤﻟا ﻖﻳﺪﺼﺗ ﻢﺛ ﺔﻴﺋﺎﻬﻨﻟا ﺔﻔﻠﻜﺘﻟا بﺎﺴﺣ ﯽﻠﻋ ﺔﻴﻟﺎﻤﻟا ﺔﺌﻴﻬﻟا ﻒﻴﻠﻜﺗ ﯽﻠﻋ ﻞﻤﻋﺎﺳ ،ًاﺪﺟ ﻞﻴﻤﺟ";
        Talks[16] = "مﺎﻌﻟا ﺔﻴﻧاﺰﻴﻣ ﻦﻣ ﺎﻬﻤﺼﺧ و ﺔﺿوﺮﻔﻤﻟا ﺔﺒﺴﻨﻟا بﺎﺴﺤﺑ ﺔﻴﻟﺎﻤﻟا ﺔﺌﻴﻬﻟا ﺔﻔﻠﻜﺘﺑ مﻮﻗﺄﺳ ..ﺎﻨﺴﺣ ﻢﻤﻫ";

    }



    void Start()
    {
        // Init

        IsGeneralNoButtonVisible.SetActive(false);
        IsGeneralYesButtonVisible.SetActive(false);
        IsAssistanceGeneralTextVisible.SetActive(false);
        IsD1Visible.SetActive(false);
        IsD1OptionsVisible.SetActive(false);


        IsD2Visible.SetActive(false);
        IsD2OptionsVisible.SetActive(false);

        IsD3Visible.SetActive(false);
        IsD3OptionsVisible.SetActive(false);

        MyManageState();
    }


    public void MyManageState()
    {
        // General Text
        if (CurrentState == 0)
        {
            CurrentState = 1;

            StopAllCoroutines();
            StartCoroutine(TypeSentenceGeneralText(Talks[1]));
        }
        else if (CurrentState == 1)
        {
            CurrentState = 2;
            StopAllCoroutines();
            StartCoroutine(TypeSentenceGeneralText(Talks[2]));
        }
        else if (CurrentState == 2)
        {
            CurrentState = 3;
            StopAllCoroutines();
            StartCoroutine(TypeSentenceGeneralText(Talks[3]));
            IsGeneralNextButtonVisible.SetActive(false);
            IsGeneralNoButtonVisible.SetActive(true);
            IsGeneralYesButtonVisible.SetActive(true);
        }

        // Question if you wanna Continue or back to menu

        else if (CurrentState == 4)
        {
            StopAllCoroutines();
            StartCoroutine(TypeSentenceGeneralText(Talks[3]));
            IsGeneralNextButtonVisible.SetActive(false);
            IsGeneralNoButtonVisible.SetActive(true);
            IsGeneralYesButtonVisible.SetActive(true);
        }

        else if (CurrentState == 5)
        {
            BackToMenu();
        }

        else if (CurrentState == 6)
        {
            CurrentState = 7;
            IsGeneralTextVisible.SetActive(false);
            IsAssistanceGeneralTextVisible.SetActive(true);
            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[4]));
        }



        else if (CurrentState == 7)
        {
            CurrentState = 8;
            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[6]));
        }

        else if (CurrentState == 8)
        {
            CurrentState = 9;

            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[7]));
        }

        else if (CurrentState == 9)
        {
            CurrentState = 10;
            IsD1Visible.SetActive(true);
            IsD1OptionsVisible.SetActive(true);
            IsAssistanceNextButtonVisible.SetActive(false);

            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[8]));
        }

        // D1Option1
        else if (CurrentState == 10)
        {
            CurrentState = 11;
            IsD1Visible.SetActive(false);
            IsD1OptionsVisible.SetActive(false);
            IsAssistanceNextButtonVisible.SetActive(false);



            PointCals(10);

            IsD2Visible.SetActive(true);
            IsD2OptionsVisible.SetActive(true);

            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[9]));
        }
        //D2 Option 1-1
        else if (CurrentState == 11)
        {
            CurrentState = 12;
            IsD2Visible.SetActive(false);
            IsD2OptionsVisible.SetActive(false);
            IsAssistanceNextButtonVisible.SetActive(true);

            PointCals(20);
            PopCals(30);
            BudgetCals(-65);

            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[10]));
        }
        else if (CurrentState == 12)
        {
            CurrentState = 13;
            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[11]));
        }
        else if (CurrentState == 13)
        {
            CurrentState = 30;
            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[12]));
        }



        //Optioni 1-2
        else if (CurrentState == 15)
        {
            CurrentState = 30;
            IsD2Visible.SetActive(false);
            IsD2OptionsVisible.SetActive(false);
            IsAssistanceNextButtonVisible.SetActive(true);

            PointCals(40);
            PopCals(60);
            BudgetCals(-55);

            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[13]));
        }



        // Option 2 - 1

        else if (CurrentState == 17)
        {
            IsD1Visible.SetActive(false);
            IsD1OptionsVisible.SetActive(false);
            IsAssistanceNextButtonVisible.SetActive(false);



            PointCals(5);

            IsD3Visible.SetActive(true);
            IsD3OptionsVisible.SetActive(true);

            CurrentState = 18;
            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[14]));
        }

        // Option 2 - 2

        else if (CurrentState == 19)
        {
            IsD3Visible.SetActive(false);
            IsD3OptionsVisible.SetActive(false);
            IsAssistanceNextButtonVisible.SetActive(true);

            PointCals(20);
            PopCals(20);
            BudgetCals(-45);

            CurrentState = 20;
            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[15]));
        }

        else if (CurrentState == 20)
        {


            CurrentState = 30;
            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[12]));
        }

        else if (CurrentState == 21)
        {
            IsD3Visible.SetActive(false);
            IsD3OptionsVisible.SetActive(false);
            IsAssistanceNextButtonVisible.SetActive(true);

            PointCals(20);
            PopCals(20);
            BudgetCals(-45);

            CurrentState = 22;
            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[16]));
        }
        else if (CurrentState == 22)
        {
            CurrentState = 23;
            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[11]));
        }
        else if (CurrentState == 23)
        {
            CurrentState = 30;
            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[12]));
        }





        else
      if (CurrentState == 30)
        {
            FinalResult();
        }




    }


    public void GeneralTextNo()
    {
        CurrentState = 5;
        MyManageState();
    }


    public void GeneralTextYes()
    {
        CurrentState = 6;
        MyManageState();
    }


    public void D1Option1()
    {
        CurrentState = 10;
        MyManageState();
    }

    public void D1Option2()
    {
        CurrentState = 17;
        MyManageState();
    }

    // D2 Option 1-1
    public void D2Option1()
    {
        CurrentState = 11;
        MyManageState();
    }
    // D2 Option 1-2
    public void D2Option2()
    {
        CurrentState = 15;
        MyManageState();
    }

    // D3 Options
    public void D3Option1()
    {
        CurrentState = 19;
        MyManageState();
    }
    // D2 Option 1-2
    public void D3Option2()
    {
        CurrentState = 21;
        MyManageState();
    }



    IEnumerator TypeSentenceGeneralText(string sentence)
    {

        GeneralText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            GeneralText.text += letter;
            yield return null;
        }
    }


    IEnumerator TypeSentenceAssistanceText(string sentence)
    {

        AssistanceText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            AssistanceText.text += letter;
            yield return null;
        }
    }


    void BackToMenu()
    {
        // Load Levels Scene
        SceneManager.LoadScene("Levels");
    }


    void PointCals(int num)
    {
        PointsText.text = (int.Parse(PointsText.text) + num).ToString();
    }

    void PopCals(int num)
    {
        PopulationText.text = PopulationText.text.Remove(PopulationText.text.Length - 1);
        PopulationText.text = (int.Parse(PopulationText.text) + num).ToString() + "%";
    }

    void BudgetCals(int num)
    {
        BudgetText.text = BudgetText.text.Remove(BudgetText.text.Length - 1);
        BudgetText.text = (int.Parse(BudgetText.text) + num).ToString() + "%";
    }


    void FinalResult()
    {
        PlayerScore.SetActive(false);
        IsAssistanceGeneralTextVisible.SetActive(false);
        FinalReuslt.SetActive(true);

        FinalResultPointsText.text = PointsText.text;
        FinalResultPopulationText.text = PopulationText.text;

    }


    void Update()
    {

    }
}
