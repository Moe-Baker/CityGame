using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level1 : Level
{
    public int CurrentState = 0;
    public GameObject IsAssistanceGeneralTextVisible;

    public Text FinalResultPointsText;
    public Text FinalResultPopulationText;

    public GameObject PlayerScore;
    public GameObject FinalReuslt;

    public GameObject IsGeneralTextVisible;
    public GameObject IsGeneralNextButtonVisible;
    public GameObject IsGeneralYesButtonVisible;
    public GameObject IsGeneralNoButtonVisible;

    public GameObject IsAssistanceNextButtonVisible;

    public GameObject IsD1OptionsVisible;

    public GameObject IsD2Visible;
    public GameObject IsD2OptionsVisible;

    public GameObject IsD3Visible;
    public GameObject IsD3OptionsVisible;

    public GameObject IsD4Visible;
    public GameObject IsD4OptionsVisible;

    public GameObject IsD5Visible;
    public GameObject IsD5OptionsVisible;

    public GameObject IsD6Visible;
    public GameObject IsD6OptionsVisible;

    string[] Talks = new string[100];

    public Level1()
    {

        Talks[0] = "ﺔﻴﻧاﺰﻴﻤﻟا يﺪﺤﺗ ﻲﻓ ﻢﻜﺑ ﺎﺒﺣﺮﻣ";
        Talks[1] = "\"ﺪﻳﺪﺠﻟا ﻚﺒﺼﻨﻣ يﺪﻴﺳ ﻚﻟ كرﺎﺒﻣ ،ﺮﻴﺨﻟا حﺎﺒﺻ\"";
        Talks[2] = " ﺪﻳﺪﺠﻟا ﻚﻠﻤﻋ ﻲﻓ ﻚﻟ مﻮﻳ لوأ حﺎﺒﺻ ﻲﻓ ﻪﺗأﺮﻗ ﺎﻣ لوأ ﻲﻫ ﻚﻘﻳﺪﺻ ﻦﻣ ﺔﻠﺳﺮﻤﻟا ﺔﻴﺼﻨﻟا ﺔﻟﺎﺳﺮﻟا هﺬﻫ";
        Talks[3] = "ﺔﻳﺬﻴﻔﻨﺗ ﺔﻄﻠﺴﻟ لﻮﺻﻮﻟا ﻲﻓ ﻚﺗﺎﺣﻮﻤﻃ ﺖﻘﻘﺤﺗ اﺮﻴﺧا ";
        Talks[4] = "ﺔﻴﻟوﺆﺴﻤﻟا هﺬﻬﻟ ﺔﺒﺳﺎﻨﻣ هءﺎﻔﻛ وذ ﺎﺼﺨﺷ ﻚﻨﻣ ﻼﻌﺟ ﻦﻳﺬﻠﻟا ﻢﻴﻠﻌﺘﻟاو ﻞﻴﻫﺄﺘﻟا ﻦﻣ تاﻮﻨﺳ ﺪﻌﺑ";
        Talks[5] = "ﻚﺒﻌﺷ ةﺎﻧﺎﻌﻣ ﻦﻣ ﺪﺤﻟا ﯽﻠﻋ ردﺎﻗ ﺮﻴﻴﻐﺗ ﻊﻨﺼﻟ ﻚﺒﺘﻜﻣ ﯽﻟإ ﻪﺠﺘﺗو ﺾﻬﻨﺗ نا ﻮﻫ ﻚﻴﻠﻋ ﺎﻣ ﻞﻛ نﻵا";

        // show assistance
        Talks[6] = "،كرﺎﺸﺘﺴﻣ ؛ﺪﻤﺤﻣ ﺎﻧأ ، (ﺪﻤﺘﻌﻤﻟا) ﺪﻴﺴﻟا ﺮﻴﺨﻟا حﺎﺒﺻ";
        Talks[7] = "دراﻮﻣ و ﻞﻛﺎﺸﻣ ﻦﻣ ،ﺔﻴﻠﺤﻤﻟا ﺔﻟﺎﺣ ﻦﻋ ﺮﻳرﺎﻘﺘﺑ كﺪﻣﻷ ﻚﺘﻣﺪﺧ ﻲﻓ ﺎﻤﺋاد نﻮﻛﺄﺳ";
        Talks[8] = " ،ﺢﻴﺤﺼﻟا راﺮﻘﻟا ﺬﻴﻔﻨﺘﻟ ﺎﻬﺟﺎﺘﺤﺗ ﻲﺘﻟا مﺎﻬﻤﻟﺎﺑ ﻲﻨﻔﻠﻜﺗ نأ ﻚﻨﻜﻤﻳ";
        Talks[9] = "ﺐﺘﻜﻤﻟا اﺬﻫ ﻲﻓ ﻲﺗﺮﺒﺧ ﻦﻣ ﺎﻬﺟﺎﺘﺤﺗ ﺎﻣﺪﻨﻋ ﻲﺗرﻮﺸﻣ ﻚﻟ مﺪﻗﺄﺳ ﺎﻤﻛ";
        Talks[10] = "!ﺐﺘﻜﻤﻟا ﯽﻟإ ﺎﻴﻫ !ﺮﻴﻴﻐﺘﻟا أﺪﺒﻨﻠﻓ";

        // Acutal Level One

        Talks[11] = "ﺔﻳدﺎﺼﺘﻗاو ﺔﻴﻋﺎﻤﺘﺟإ تﺎﻘﺒﻃ ةﺪﻋ ﻦﻣ ﺎﻬﻧﺎﻜﺳ نﻮﻜﺘﻳ تاذ ﺎﻬﺑ ﻚﻨﻴﻴﻌﺗ ﻢﺗ ﻲﺘﻟا ﺔﻴﻠﺤﻤﻟا";
        Talks[12] = "ﻞﺧﺪﻟا ﺔﻄﺳﻮﺘﻣ ﺮﺳﻷا ﻦﻣ ﺐﻠﻏﻷا";
        Talks[13] = "ﺔﻘﻴﻗد ﻦﻳﺮﺸﻋ ﻚﺗرﺎﻴﺳ تﻼﺠﻋ جاﺮﺧإ قﺮﻐﺘﺳا ﺪﻘﻓ اﺮﺧﺄﺘﻣ ﻚﺒﺘﻜﻣ ﯽﻟإ ﺖﻠﺻو مﻮﻴﻟا";
        Talks[14] = "رﺎﻄﻣﻷا هﺎﻴﻤﺑ ﯽﻄﻐﻣ ﻪﻧأ ﺔﺠﻴﺘﻧ ﻪﺘﻳؤر ﻊﻄﺘﺴﺗ ﻢﻟ ﻒﻳﺮﺼﺗ ىﺮﺠﻤﺑ ﺖﻘﻠﻋ ﺚﻴﺣ";
        Talks[15] = "ﻒﺳﺆﻣ ﺮﻣأ ﻦﻣ ﻪﻟ ﺎﻳ ،حﺎﺒﺼﻟا اﺬﻫ ﻚﺗرﺎﻴﺴﻟ ثﺪﺣ ﺎﻤﺑ ﺖﻌﻤﺳ ﺪﻘﻟ";
        Talks[16] = "ةرﺎﻴﺴﻟﺎﺑ ﺖﻠﺣ ﻲﺘﻟا راﺮﺿﻷا حﻼﺻﺈﺑ ﺔﻴﻠﺤﻤﻟا ﻞﻔﻜﺘﺘﺳ ﻖﻠﻘﺗ ﻻ ﻦﻜﻟو";
        Talks[17] = " ةرﺎﻴﺴﻟا ﺔﻠﻜﺸﻣ ﻞﺤﺗ ﯽﺘﺣ ىﺮﺧﻷا ﺐﺘﻜﻤﻟا تارﺎﻴﺳ ىﺪﺣﺈﺑ ﻚﻠﻴﺻﻮﺘﺑ ﻖﺋﺎﺴﻟا مﻮﻘﻴﺳ و";


        Talks[18] = "";
        Talks[19] = "اﺪﻴﺟ ﺎﻬﻌﻗﻮﻣ اﻮﻈﻔﺣ ﺪﻗ ﻢﻬﻧأ ﺪﻘﺘﻋا ﻦﻜﻟو ﺎﻬﻨﻣ نﻮﻜﺸﻳ نﺎﻜﺴﻟا نﺎﻛ ،ﻒﻳﺮﺧ ﻞﻛ ثﺪﺤﺗ ﺔﻠﻜﺸﻤﻟا هﺬﻫ ﻢﻌﻧ !هوا";
        Talks[20] = "ﻢﻬﻟ ﺔﺒﺴﻨﻟﺎﺑ ﺔﻠﻜﺸﻣ ﺔﻠﻜﺸﻣ ﺪﻌﺗ ﻢﻟ ﺎﻬﻧأ وﺪﺒﻳ اﺬﻟ";

        Talks[21] = "ﺮﻳﺮﻘﺘﻟا ﺔﺑﺎﺘﻜﺑ ﻖﻳﺮﻔﻟا أﺪﺒﻴﺳ ،يﺪﻴﺳ ﺎﻨﺴﺣ";
        Talks[22] = ".ىﺮﺧﻷا تﺎﻣﺪﺨﻟا ﯽﻠﻋ راﺮﻘﻟا اﺬﻫ ﺮﺛﺆﻴﺳ ﺎﻨﺘﻴﻧاﺰﻴﻣ ﻲﻓ ﺔﺟرﺪﻣ ﺖﺴﻴﻟ تﺎﻣﺪﺧ اﺬﻜﻫ ﻦﻜﻟو";

        Talks[40] = "ﺎﻬﻴﻠﻋ عﻼﻃﻻا ﻚﻨﻣ ﻮﺟرا ،ﺔﻘﻄﻨﻤﻟﺎﺑ ﺔﻃﺮﺸﻟا ﻢﺴﻗ ﺔﺳﺎﺋر ﻦﻣ ﺐﻟﺎﻄﻤﻟا و ﺮﻳرﺎﻘﺘﻟا ﺾﻌﺑ ﺎﻨﺘﻠﺻو ﺪﻘﻟ يﺪﻴﺳ";
        Talks[41] = "؟ﻞﻌﻔﻧ نأ ﺐﺠﻳ اذﺎﻣ";



        Talks[50] = "يﺪﻴﺳ ارﻮﻓ";
        Talks[51] = "اذإ ﺪﻐﻟا ﺬﻨﻣ ﻞﻤﻌﻟﺎﺑ ﻖﻳﺮﻔﻟا أﺪﺒﻴﺳ";

        Talks[90] = "ﺎﻨﻠﻤﻋ ﺔﺠﻴﺘﻧ يﺮﻨﻟ";



    }

    void Start()
    {
        IsAssistanceGeneralTextVisible.SetActive(false);
        IsGeneralYesButtonVisible.SetActive(false);
        IsGeneralNoButtonVisible.SetActive(false);
        IsD1OptionsVisible.SetActive(false);

        IsD2OptionsVisible.SetActive(false);
        IsD2Visible.SetActive(false);

        IsD6OptionsVisible.SetActive(false);
        IsD6Visible.SetActive(false);

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
        else if (CurrentState == 1)
        {
            CurrentState = 2;
            StopAllCoroutines();
            StartCoroutine(TypeSentenceGeneralText(Talks[1]));
        }
        else if (CurrentState == 2)
        {
            CurrentState = 3;
            StopAllCoroutines();
            StartCoroutine(TypeSentenceGeneralText(Talks[2]));
        }

        else if (CurrentState == 3)
        {
            CurrentState = 4;
            StopAllCoroutines();
            StartCoroutine(TypeSentenceGeneralText(Talks[3]));
        }




        else if (CurrentState == 4)
        {
            CurrentState = 5;
         
            StopAllCoroutines();
            StartCoroutine(TypeSentenceGeneralText(Talks[4]));
        }

        else if (CurrentState == 5)
        {
            CurrentState = 6;
            StopAllCoroutines();
            StartCoroutine(TypeSentenceGeneralText(Talks[5]));
        }
        else if (CurrentState == 6)
        {

            IsAssistanceGeneralTextVisible.SetActive(true);
            IsGeneralTextVisible.SetActive(false);

            CurrentState = 7;
            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[6]));
        }
        else if (CurrentState == 7)
        {
            CurrentState = 8;
            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[7]));
        }
        // Assistance show and start talking
        else if (CurrentState == 8)
        {
         

            CurrentState = 9;
            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[8]));
        }
        else if (CurrentState == 9)
        {
            CurrentState = 10;
            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[9]));
        }
        else if (CurrentState == 10)
        {
            CurrentState = 11;
          
            StopAllCoroutines();
           
            StartCoroutine(TypeSentenceAssistanceText(Talks[10]));
        }
        else if (CurrentState == 11)
        {
            CurrentState = 12;
            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[11]));
        }
        else if (CurrentState == 12)
        {
            CurrentState = 13;
            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[12]));
        }
        else if (CurrentState == 13)
        {
            CurrentState = 14;
            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[13]));
        }
        else if (CurrentState == 14)
        {
            CurrentState = 15;
            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[14]));
        }
        else if (CurrentState == 15)
        {
            CurrentState = 16;
            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[15]));
        }
        else if (CurrentState == 16)
        {
            CurrentState = 17;
            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[16]));
        }
        else if (CurrentState == 17)
        {
            CurrentState = 18;

            IsD1OptionsVisible.SetActive(true);
            IsAssistanceNextButtonVisible.SetActive(false);

            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[17]));
        }



        // D 1 -1 (begin tree)
        else if (CurrentState == 19)
        {
            CurrentState = 20;

            IsD1OptionsVisible.SetActive(false);
            IsAssistanceNextButtonVisible.SetActive(true);

            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[19]));
        }

        else if (CurrentState == 20)
        {
            CurrentState = 21;

            IsD2OptionsVisible.SetActive(true);
            IsD2Visible.SetActive(true);
            IsAssistanceNextButtonVisible.SetActive(false);


            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[20]));
        }

        // D 2- 1 (T1-1)
        else if (CurrentState == 21)
        {

            CurrentState = 40;
            IsD2OptionsVisible.SetActive(false);
            IsD2Visible.SetActive(false);
            IsAssistanceNextButtonVisible.SetActive(true);


            PointCals(20);
            PopCals(0);
            BudgetCals(-5);

            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[21]));
        }

        else if (CurrentState == 22)
        {
            CurrentState = 40;

            IsD2OptionsVisible.SetActive(false);
            IsD2Visible.SetActive(false);
            IsAssistanceNextButtonVisible.SetActive(true);

            PointCals(10);
            PopCals(10);
            BudgetCals(-30);


            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[22]));
        }

        else if (CurrentState == 40)
        {
            CurrentState = 41;

            IsD1OptionsVisible.SetActive(false);

            IsD2OptionsVisible.SetActive(false);
            IsD2Visible.SetActive(false);

            IsAssistanceNextButtonVisible.SetActive(true);

           

            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[40]));
        }

        else if (CurrentState == 41)
        {
            CurrentState = 42;

          

          
            IsD3Visible.SetActive(false);
            IsD4Visible.SetActive(true);

          

            StopAllCoroutines();
           // StartCoroutine(TypeSentenceAssistanceText(Talks[40]));
        }

        else if (CurrentState == 42)
        {
            CurrentState = 43;

         
            IsD4Visible.SetActive(false);
            IsD5Visible.SetActive(true);


           
            StopAllCoroutines();
           // StartCoroutine(TypeSentenceAssistanceText(Talks[40]));
        }

        else if (CurrentState == 43)
        {

            IsD5Visible.SetActive(false);
            IsD6Visible.SetActive(true);
            IsD6OptionsVisible.SetActive(true);

            StartCoroutine(TypeSentenceAssistanceText(Talks[41]));
        }



        else if (CurrentState == 50)
        {
            CurrentState = 90;

            IsD5Visible.SetActive(false);

            IsD6Visible.SetActive(false);
            IsD6OptionsVisible.SetActive(false);

            PointCals(20);
            PopCals(20);
            BudgetCals(-30);

           

            StartCoroutine(TypeSentenceAssistanceText(Talks[50]));
        }


        else if (CurrentState == 51)
        {
            CurrentState = 90;

            IsD5Visible.SetActive(false);
            IsD6Visible.SetActive(false);
            IsD6OptionsVisible.SetActive(false);

            PointCals(10);
            PopCals(0);
            BudgetCals(10);

            StartCoroutine(TypeSentenceAssistanceText(Talks[51]));
        }
        else
        if (CurrentState == 90)
        {
            CurrentState = 91;
            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[90]));
        
        }
        else
        if (CurrentState == 91)
        {
            FinalResult();
        }






    }


    public void D1Option1()
    {
        CurrentState = 19;
        PointCals(10);
        MyManageState();
    }

    public void D2Option1Optoin1()
    {
        CurrentState = 21;
       
        MyManageState();
    }

    public void D2Option1Optoin2()
    {
        CurrentState = 22;
      
        MyManageState();
    }



    public void D2Option1Optoin3()
    {
        CurrentState = 40;
        MyManageState();
    }



    public void D1Option2()
    {
        CurrentState = 40;
        MyManageState();
    }


    public void D6Option1()
    {
        CurrentState = 50;
        MyManageState();
    }

    public void D6Option2()
    {
        CurrentState = 51;
        MyManageState();
    }

    void Update()
    {

    }

    void FinalResult()
    {
        PlayerScore.SetActive(false);
        IsAssistanceGeneralTextVisible.SetActive(false);
        FinalReuslt.SetActive(true);

        FinalResultPointsText.text = PointsText.text;
        FinalResultPopulationText.text = PopulationText.text;

    }
}
