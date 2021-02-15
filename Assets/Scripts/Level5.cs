using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level5 : Level
{
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

    string[] Talks = new string[100];
    public Level5()
    {



        Talks[1] = "ﻲﻟاﻮﺘﻟا ﯽﻠﻋ ﺔﻌﺑاﺮﻟا ﺔﻨﺴﻟا ﺎﻬﻧإ ،ﺔﻳﻻﻮﻟا هﺬﻫ ﯽﻠﻋ لوﺆﺴﻤﻛ ﻚﻟ ﺔﻨﺳ ﺮﺧآ ﺪﻴﻛﺄﺘﻟﺎﺑ هﺬﻫ";
        Talks[2] = "!ﻞﻌﻔﻟﺎﺑ ﺮﻴﺜﻜﻟا ﺖﻘﻘﺣ ﺪﻗ ﻚﻧأ ﺪﺑﻻ  .ﺔﻳﻻﻮﻟا نﺎﻜﺳ ﺎﻬﻴﻓ كرﺎﺘﺨﻳ ﻲﺘﻟاو";
        Talks[3] = "!تازﺎﺠﻧإ ﻦﻣ مﺎﻌﻟا اﺬﻫ ﻒﻴﻀﺗ نأ ﻚﻨﻜﻤﻳ اذﺎﻣ ىﺮﻨﻟ";


        //Show Char and start
        Talks[4] = ".ﺎﻨﻫ ﻚﻟ مﺎﻋ ﺮﺧآ ﻪﻧإ ،ﻲﻟاﻮﻟا ﺪﻴﺴﻟا ﺮﻴﺨﻟا حﺎﺒﺻ";
        Talks[5] = "!ﺔﻳﻻﻮﻟا هﺬﻫ ﻲﻓ ﻚﺘﻗو ﻦﻣ ﯽﻘﺒﺗ ﺎﻤﻴﻓ ﻞﻀﻓﻷا ﻊﻨﺼﻨﻠﻓ";
        Talks[6] = "وﺪﺒﻳ ﺎﻣ ﯽﻠﻋو ،مﺎﻋ ﻞﻛ ﻲﻓ ﺎﻤﻛ ﺮﻳﺮﻘﺘﻟا ﺰﻴﻬﺠﺘﺑ ﺖﻤﻗ ﺪﻘﻟ !ﻞﻤﻌﻟا أﺪﺒﻨﻠﻓ ﺎﻨﺴﺣ";
        Talks[7] = "ﺔﻘﺑﺎﺴﻟا ماﻮﻋﻷا ﻦﻣ ةرﻮﻄﺧ ﻞﻗأ وﺪﺒﺗ ةﺪﻋ ىﺮﺧأ ﻞﻛﺎﺸﻣ ﻦﻣ ﻲﻧﺎﻌﺗ ﺔﻳﻻﻮﻟا نﺈﻓ ﺎﻫﺰﻴﻬﺠﺗ ﻢﺗ ﻲﺘﻟا تﺎﺣﻮﺴﻤﻟا ﺐﺴﺣ  ";

        Talks[8] = "؟ﻚﻳأر ﻲﻓ مﺎﻌﻟا اﺬﻫ ﺎﻬﻴﻠﻋ ﻞﻤﻌﻠﻟ ﺔﻳﻮﻟوﻷا ﯽﻄﻌﻳ نأ ﺐﺠﻳ ﺎﻤﻬﻳأ";

        // D1Option 1
        Talks[9] = "؟ﻲﻟاﻮﻟا ﺪﻴﺴﻟا ، تﺎﻳﺎﻔﻨﻟا ﺔﻠﻜﺸﻣ ﻞﺣ ﯽﻠﻋ ﻞﻤﻌﻟﺎﺑ أﺪﺒﻧ نأ ﻦﻜﻤﻳ ﻦﻳأ ﻦﻣ";

        // Option 1 - 1
        Talks[10] = "ﺔﻴﻨﻌﻤﻟا تﺎﻬﺠﻠﻟ ًﺎﻳﺮﻬﺷ بﻮﻠﻄﻤﻟا ﻎﻠﺒﻤﻟا عﺎﻄﻘﺘﺳﺎﺑ ﺮﻣﺄﻳ بﺎﻄﺧ ﺔﺑﺎﺘﻜﺑ رﻮﻔﻟﺎﺑ مﻮﻘﻨﺳ !ﺎﻨﺴﺣ";
        Talks[11] = " !ىﺮﺧأ ﺔﻠﻜﺸﻣ يأ ﻞﺣ ﯽﻠﻋ ﻞﻤﻌﻠﻟ ﻲﻔﻜﻳ ﻻ ﺔﻴﻧاﺰﻴﻤﻟا ﻦﻣ ﯽﻘﺒﺗ ﺎﻣ نأ وﺪﺒﻳ !ﻼﻬﻣ";
        Talks[12] = "!ﻞﻀﻓﻷا تارﺎﻴﺨﻟا ﺎﻧﺬﺨﺗا ﺪﻗ ﺎﻨﻧأ ﻮﺟرأ !مﺎﻌﻟا ﺔﻳﺎﻬﻧ ﯽﺘﺣ نﻵا ﺬﻴﻔﻨﺘﻟا ﯽﻠﻋ ﺰﻴﻛﺮﺘﻟا ﯽﻠﻋ ﻦﻳﺮﺒﺠﻣ ﺎﻨﻧأ وﺪﺒﻳ";

        // Opton 1 - 2
        Talks[13] = "عوﺮﺸﻤﻠﻟ ﻂﻴﻄﺨﺘﻟا ﯽﻠﻋ ﻞﻤﻌﻠﻟ ﺔﻨﺠﻟ ﻦﻳﻮﻜﺘﺑ رﻮﻔﻟﺎﺑ مﻮﻗﺄﺳ !ﺎﻨﺴﺣ";


        // Option 2

        Talks[14] = "؟ﻲﻟاﻮﻟا ﺪﻴﺴﻟا ،تﺎﻣﺪﺨﻟا يدﺮﺗ ﺔﻠﻜﺸﻣ ﻞﺤﻟ أﺪﺒﻧ نأ ﻦﻜﻤﻳ ﻦﻳأ ﻦﻣ";

        Talks[15] = "عوﺮﺸﻤﻟا ﯽﻠﻋ فاﺮﺷﻹاو ﻂﻴﻄﺨﺘﻟا ﺔﻨﺠﻟ ﻦﻳﻮﻜﺘﺑ رﻮﻔﻟﺎﺑ أﺪﺒﻨﺳ !ﺎﻨﺴﺣ";
        Talks[16] = "!ﺔﻃﺮﺸﻠﻟ بﻮﻠﻄﻤﻟا ﻎﻠﺒﻤﻟا فﺮﺼﺑ رﻮﻔﻟﺎﺑ مﻮﻘﻨﺳ !ﺎﻨﺴﺣ";

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
            PopCals(40);
            BudgetCals(-65);

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

            PointCals(40);
            PopCals(70);
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

    void BackToMenu()
    {
        // Load Levels Scene
        SceneManager.LoadScene("Levels");
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
