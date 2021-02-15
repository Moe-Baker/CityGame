using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level3 : Level
{
    public Text FinalResultPointsText;
    public Text FinalResultPopulationText;




    public int CurrentState = 0;
    public GameObject IsAssistanceGeneralTextVisible;

    public GameObject PlayerScore;
    public GameObject FinalReuslt;

    public GameObject IsGeneralTextVisible;
    public GameObject IsGeneralNextButtonVisible;
    public GameObject IsGeneralYesButtonVisible;
    public GameObject IsGeneralNoButtonVisible;

    public GameObject IsAssistanceNextButtonVisible;
 


    public GameObject IsD2Visible;
    public GameObject IsD2OptionsVisible;

    public GameObject IsD3Visible;
    public GameObject IsD3OptionsVisible;

    public GameObject IsD4Visible;
    public GameObject IsD4OptionsVisible;

    string[] Talks = new string[100];


    public Level3()
    {

        Talks[0] = "!ﺔﻴﻣﺎﻨﻟا ﺔﻳﻻﻮﻟا هﺬﻬﻟ لوﺆﺴﻤﻛ ﻲﻧﺎﺜﻟا ﻚﻣﺎﻋ أﺪﺒﺗ مﻮﻴﻟا";
        Talks[1] = "ﻚﺗازﺎﺠﻧا ﺔﻠﺻاﻮﻤﻟ ﻲﻧﺎﺜﻟا ﻚﻣﺎﻋ ﻲﻓ ﻖﻠﻄﻨﺗ ﺖﻧأ ﺎﻫو حﺎﺠﻨﻟﺎﺑ ﺎﺌﻴﻠﻣ ﻖﺑﺎﺴﻟا ﻚﻣﺎﻋ نﺎﻛ ﺪﻘﻟ";
        Talks[2] = "؟!ﺮﻤﺜﻤﻟا ﻞﻤﻌﻟا ﻦﻣ ﺪﻳﺰﻤﻟا زﺎﺠﻧﻹ ﺪﻌﺘﺴﻣ ﺖﻧأ ﻞﻫ";

        // Assistance Talk
        Talks[3] = " !ﺎﻌﻣ ﺎﻨﻫ ﻲﻧﺎﺜﻟا ﺎﻨﻣﺎﻋ ﻲﻓ ﻲﻟاﻮﻟا ﺪﻴﺴﻟا ﺮﻴﺨﻟا حﺎﺒﺻ";
        Talks[4] = "ﻪﺘﺒﻠﻃ ﻲﺘﻟا ﺮﻳﺮﻘﺘﻟا ﺰﻴﻬﺠﺘﺑ ﺖﻤﻗ ﺪﻘﻟ ؛مﺎﻌﻟا اﺬﻫ ﻞﻛﺎﺸﻤﺑ ﺺﺘﺨﻳ ﺎﻤﻴﻓ";
        Talks[5] = "ةرﻮﻄﺨﻟا ﺔﺗوﺎﻔﺘﻣ ةﺪﻋ ىﺮﺧأ ﻞﻛﺎﺸﻣ ﻦﻣ ﻲﻧﺎﻌﺗ ﺔﻳﻻﻮﻟا نﺈﻓ ﺎﻫﺰﻴﻬﺠﺗ ﻢﺗ ﻲﺘﻟا تﺎﺣﻮﺴﻤﻟا ﺐﺴﺣ ؛وﺪﺒﻳ ﺎﻣ ﯽﻠﻋو";
        Talks[6] = "؟ﻲﻟاﻮﻟا ﺪﻴﺴﻟا ، ﺔﻳودﻷا ﺮﻓﻮﺗ مﺪﻋ ﺔﻠﻜﺸﻣ ﻞﺤﻟ أﺪﺒﻧ نأ ﻦﻜﻤﻳ ﻦﻳأ ﻦﻣ";


        Talks[7] = "ﺔﻳودﻸﻟ ﻊﻧﺎﺼﻣ ءﺎﺸﻧإ ﻊﻳرﺎﺸﻣ ﯽﻠﻋ ﻞﻤﻌﻟﺎﺑ رﻮﻔﻟﺎﺑ اﺪﺒﻨﺳ !ﺎﻨﺴﺣ";
        Talks[8] = " !ىﺮﺧأ ﺔﻠﻜﺸﻣ يأ ﻞﺣ ﯽﻠﻋ ﻞﻤﻌﻠﻟ ﻲﻔﻜﻳ ﻻ ﺔﻴﻧاﺰﻴﻤﻟا ﻦﻣ ﯽﻘﺒﺗ ﺎﻣ نأ وﺪﺒﻳ !ًﻼﻬﻣ";
        Talks[9] = "!ﻞﻀﻓﻷا تارﺎﻴﺨﻟا ﺎﻧﺬﺨﺗا ﺪﻗ ﺎﻨﻧأ ﻮﺟرأ !مﺎﻌﻟا ﺔﻳﺎﻬﻧ ﯽﺘﺣ نﻵا ﺬﻴﻔﻨﺘﻟا ﯽﻠﻋ ﺰﻴﻛﺮﺘﻟا ﯽﻠﻋ ﻦﻳﺮﺒﺠﻣ ﺎﻨﻧأ وﺪﺒﻳ";


        Talks[10] = "ﺔﺤﺼﻟا ةرازﻮﻟ ﺎﻬﻓﺮﺼﻟ ﺔﻨﻳﺰﺨﻠﻟ ﺎﻬﻤﻴﻠﺴﺗ و ةرﻮﺗﺎﻓ ﺐﻠﻄﺑ رﻮﻔﻟﺎﺑ مﻮﻗﺄﺳ !ﺎﻨﺴﺣ";

        Talks[11] = "؟ﻲﻟاﻮﻟا ﺪﻴﺴﻟا ،ءﺎﺑﺮﻬﻜﻟا تﺎﻋﻮﻄﻗ ﺔﻠﻜﺸﻣ ﻞﺤﻟ أﺪﺒﻧ نأ ﻦﻜﻤﻳ ﻦﻳأ ﻦﻣ";

        Talks[12] = "!ﻊﻳزﻮﺘﻟاو ﺪﻴﻟﻮﺘﻟا تﺎﻄﺤﻣ و ءﺎﺑﺮﻬﻜﻟا طﻮﻄﺧ ﺔﻧﺎﻴﺼﻟ قﺎﻔﻧﻹا ﯽﻠﻋ ﻞﻤﻌﻟﺎﺑ رﻮﻔﻟﺎﺑ اﺪﺒﻨﺳ !ﺎﻨﺴﺣ";

        Talks[13] = "! ﻦﻳﺪﻟا ﺮﻴﻓﻮﺘﻟ رﺪﺼﻣ ﻦﻋ ﺚﺤﺒﻟا ﻢﺛ ﺔﻴﻧاﺰﻴﻤﻟا ﻦﻣ ﻪﻗﺎﻔﻧإ ﻦﻜﻤﻳ ﺎﻣ ﻢﺼﺧ و عوﺮﺸﻤﻟا ﺔﻔﻠﻜﺗ بﺎﺴﺤﺑ رﻮﻔﻟﺎﺑ مﻮﻘﻨﺳ !ﺎﻨﺴﺣ";
        Talks[14] = "ﺔﻠﺒﻘﻤﻟا ﻦﻴﻨﺴﻟا ﻲﻓ ﺔﻟوﺪﻟا دﺎﺼﺘﻗا ﯽﻠﻋ ﺮﺛﺆﻴﺳ اﺬﻫ نأ ﺪﺑﻻ !ﺔﻴﺟرﺎﺨﻟا ﺔﻟوﺪﻟا نﻮﻳد ﻦﻣ ﺎﻨﻤﻗﺎﻓ ﺪﻗ ﺎﻨﻧأ ﺎﻤﻛ";
        Talks[15] = "!ﻞﻀﻓﻷا تارﺎﻴﺨﻟا ﺎﻧﺬﺨﺗا ﺪﻗ ﺎﻨﻧأ ﻮﺟرأ";
   





    }



    void Start()
    {
        IsAssistanceGeneralTextVisible.SetActive(false);
      

        IsD2Visible.SetActive(false);
        IsD2OptionsVisible.SetActive(false);

        IsD3Visible.SetActive(false);
        IsD3OptionsVisible.SetActive(false);

        IsD4Visible.SetActive(false);
        IsD4OptionsVisible.SetActive(false);

        FinalReuslt.SetActive(false);

        //Set Points for Players



        MyManageState();
    }


    public void MyManageState()
    {
        if (CurrentState == 0)
        {
            CurrentState = 1;

            StopAllCoroutines();
            StartCoroutine(TypeSentenceGeneralText(Talks[0]));
        }
        else
        if (CurrentState == 1)
        {
            CurrentState = 2;

            StopAllCoroutines();
            StartCoroutine(TypeSentenceGeneralText(Talks[1]));
        }
        else
        if (CurrentState == 2)
        {
            CurrentState = 3;

            IsGeneralNextButtonVisible.SetActive(false);
            IsGeneralNoButtonVisible.SetActive(true);
            IsGeneralYesButtonVisible.SetActive(true);

            StopAllCoroutines();
            StartCoroutine(TypeSentenceGeneralText(Talks[2]));
        }
        else
        if (CurrentState == 3)
        {
            CurrentState = 4;

            IsGeneralTextVisible.SetActive(false);
            IsAssistanceGeneralTextVisible.SetActive(true);

            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[3]));
        }
        else
        if (CurrentState == 4)
        {
            CurrentState = 5;


            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[4]));
        }
        else
        if (CurrentState == 5)
        {
            CurrentState = 6;

      

            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[5]));
        }

        else
        if (CurrentState == 6)
        {
            CurrentState = 7;

            IsD2OptionsVisible.SetActive(true);
            IsD2Visible.SetActive(true);

          //  StopAllCoroutines();
          //  StartCoroutine(TypeSentenceAssistanceText(Talks[5]));
        }

        #region Tree (1)
        else
        if (CurrentState == 8)
        {
            CurrentState = 9;

            IsD2OptionsVisible.SetActive(false);
            IsD2Visible.SetActive(false);

            IsD3OptionsVisible.SetActive(true);
            IsD3Visible.SetActive(true);

            BudgetCals(-45);
            PointCals(10);

            StopAllCoroutines();
              StartCoroutine(TypeSentenceAssistanceText(Talks[6]));
        }
        if (CurrentState == 10)
        {
            CurrentState = 11;

            IsD3OptionsVisible.SetActive(false);
            IsD3Visible.SetActive(false);

            BudgetCals(-45);
            PointCals(40);
            PopCals(20);


            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[7]));
        }

   
        else
        if (CurrentState == 11)
        {

            CurrentState = 12;
         

            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[8]));
        }
        if (CurrentState == 12)
        {

            CurrentState = 30;


            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[9]));
 
        }

        else
        if (CurrentState == 14)
        {

            BudgetCals(-45);
            PointCals(20);
            PopCals(60);

            CurrentState = 15;

            IsD3OptionsVisible.SetActive(false);
            IsD3Visible.SetActive(false);

            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[10]));
        }
        else
        if (CurrentState == 15)
        {
            CurrentState = 16;

          

            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[8]));
        }
        else
        if (CurrentState == 16)
        {
            CurrentState = 30;



            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[9]));
        }
        #endregion


        #region Tree (2)
        else
        if (CurrentState == 18)
        {



            IsD2OptionsVisible.SetActive(false);
            IsD2Visible.SetActive(false);

            BudgetCals(-65);
            PointCals(5);

            IsD4OptionsVisible.SetActive(true);
            IsD4Visible.SetActive(true);

            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[11]));
        }
        else
        if (CurrentState == 19)
        {
            CurrentState = 20;


            IsD4OptionsVisible.SetActive(false);
            IsD4Visible.SetActive(false);


            BudgetCals(-65);
            PointCals(40);
            PopCals(50);

            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[12]));
        }
         else
        if (CurrentState == 20)
        {
            CurrentState = 21;



            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[8]));
        }
        else
        if (CurrentState == 21)
        {
            CurrentState = 30;
            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[9]));
        }


        else
        if (CurrentState == 22)
        {


            CurrentState = 23;

            IsD4OptionsVisible.SetActive(false);
            IsD4Visible.SetActive(false);


            BudgetCals(-65);
            PointCals(20);
            PopCals(20);


            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[13]));
        }
        else
        if (CurrentState == 23)
        {
            CurrentState = 24;



            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[14]));
        }
        else
        if (CurrentState == 24)
        {
            CurrentState = 30;



            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[15]));
        }



        #endregion

        if(CurrentState== 30)
        {
            FinalResult();
        }
    }


    // D2 Option 1-1
    public void D2Option1()
    {
        CurrentState = 8;
        MyManageState();
    }
    // D2 option 1-2
    public void D2Option2()
    {
        CurrentState = 18;
        MyManageState();
    }

    // D3 Option 1-1-1
    public void D3Option1()
    {
        CurrentState = 10;
        MyManageState();
    }

    // D3 Option 1-1-2
    public void D3Option2()
    {
        CurrentState = 14;
        MyManageState();
    }


    // D4 Option 1-2-1
    public void D4Option1()
    {
        CurrentState = 19;
        MyManageState();
    }

    // D4 Option 1-2-2
    public void D4Option2()
    {
        CurrentState = 22;
        MyManageState();
    }








    public void GeneralTextYes()
    {
        CurrentState = 3;
        MyManageState();
    }

    public void BackToMenu()
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
