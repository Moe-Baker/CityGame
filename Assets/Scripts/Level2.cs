using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level2 : Level
{
    public Text FinalResultPointsText;
    public Text FinalResultPopulationText;


    public GameObject IsD1Option1Visible;
    public GameObject IsD1Option2Visible;
    public GameObject IsD1Option3Visible;
    public GameObject IsD1Option4Visible;





    public int CurrentState = 0;
    public GameObject IsAssistanceGeneralTextVisible;

    public GameObject PlayerScore;
    public GameObject FinalReuslt;

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

    public GameObject IsD4Visible;
    public GameObject IsD4OptionsVisible;

    public GameObject IsD5Visible;
    public GameObject IsD5OptionsVisible;

    public GameObject IsD6Visible;
    public GameObject IsD6OptionsVisible;

    public GameObject IsD7Visible;
    public GameObject IsD7OptionsVisible;

    string[] Talks = new string[100];


    public Level2()
    {


        Talks[1] = "!ةدراو ﺔﻴﺼﻧ ﺔﻟﺎﺳر ﻚﻳﺪﻟ";
        Talks[2] = "!ﻖﻴﻓﻮﺘﻟا ﺺﻟﺎﺧ ﻚﻟ ﯽﻤﺘﻧ..ﻲﺋﻻو لوﺆﺴﻣ ﯽﻟإ ﻚﺘﻴﻗﺮﺗ ﺔﺒﺳﺎﻨﻤﺑ !ةرﺎﺤﻟا ﺎﻨﻴﻧﺎﻬﺗ ،ﺮﻴﺨﻟا حﺎﺒﺻ";
        Talks[3] = ".ﯽﻔﻄﺼﻣ ﻚﻘﻳﺪﺻ :ﻞﺳﺮﻤﻟا";


        // tallk Intro
        Talks[4] = " .ًﺔﻠﻣﺎﻛ ﺔﻳﻻﻮﻟا ﯽﻠﻋ ﺔﻳﺬﻴﻔﻨﺘﻟا ﺔﻄﻠﺴﻟا نﻵا كﺪﻴﺑ ،ﺮﺒﻛأ قﺎﻄﻧ ﯽﻠﻋ ﺮﻴﻴﻐﺘﻟا ﻊﻨﺻ نﻵا ﻚﻨﻜﻤﻳ !ﻚﺘﻴﻗﺮﺗ ﺖﻤﺗ ﺪﻘﻟ !ﯽﺣﺮﻣ";
        Talks[5] = " .ةرﻮﻄﺧو اﺪﻴﻘﻌﺗ ﺮﺜﻛأ نﻮﻜﺘﺳ ﻚﻬﺟاﻮﺘﺳ ﻲﺘﻟا ﻞﻛﺎﺸﻤﻟا نﺈﻓ !ﺐﻌﺻأ ﺔﻤﻬﻣ ﻚﻠﻤﻋ ﻦﻣ ﻞﻌﺠﻴﺳ ﺪﻴﻛﺄﺘﻟﺎﺑ ﻚﻟذ ";
        Talks[6] = "ﺪﻳﺪﺠﻟا ﻚﺒﺘﻜﻣ ﯽﻟإ ﻚﻌﻣ ﺪﻤﺤﻣ كرﺎﺸﺘﺴﻣ ﻞﻘﻧ ﯽﻠﻋ ﺔﻘﻓاﻮﻤﻟا ﺖﻤﺗ ﻆﺤﻟا ﻦﺴﺤﻟ ";
        Talks[7] = "  ﺔﻤﻬﻤﻟا ﺔﻴﻟوﺆﺴﻤﻟا هﺬﻫ ﻦﻣ ﺎﻌﻣ ﺎﻨﻜﻤﺘﺘﺳ ﺎﻤﻜﻧأ ﻚﺷ ﻻو";

        Talks[8] = "؟تازﺎﺠﻧﻹا ﻦﻣ ﺪﻳﺰﻣ ﻖﻴﻘﺤﺘﻟ ﺪﻌﺘﺴﻣ ﺖﻧأ ﻞﻫ";

        // D1Option 1
        Talks[9] = "!!اﺪﻴﻘﻌﺗ ﺮﺜﻛأ ﺎﻨﺘﻴﻟوﺆﺴﻣ ةﺮﻤﻟا هﺬﻫ ﻦﻜﻟو ،ﺎﻌﻣ ادﺪﺠﻣ ﻞﻤﻌﻧ ﻦﺤﻧ ﺎﻫ !ﻲﻟاﻮﻟا ﺪﻴﺴﻟا ﺮﻴﺨﻟا حﺎﺒﺻ";

        // Start 
        Talks[10] = "ـﺑ أﺪﺒﻧ نا ﺐﺠﻳ ﻪﻧا ﺪﻘﺘﻋا";
        Talks[11] = "؟ﻚﻳأر ﻲﻓ ﻪﻴﻠﻋ ﻞﻤﻌﻟا ﺔﻳاﺪﺒﻟ ﺔﻳﻮﻟوﻷا ﯽﻄﻌﻳ نأ ﺐﺠﻳ ﺎﻤﻬﻳأ";


        Talks[12] = "!ﻞﻀﻓﻷا تارﺎﻴﺨﻟا ﺎﻧﺬﺨﺗا ﺪﻗ ﺎﻨﻧأ ﻮﺟرأ !مﺎﻌﻟا ﺔﻳﺎﻬﻧ ﯽﺘﺣ نﻵا ﺬﻴﻔﻨﺘﻟا ﯽﻠﻋ ﺰﻴﻛﺮﺘﻟا ﯽﻠﻋ ﻦﻳﺮﺒﺠﻣ ﺎﻨﻧأ وﺪﺒﻳ";

       
        Talks[13] = "فﺮﺼﻟا ﺔﺒﻗاﺮﻤﻟ ﺔﻨﺠﻟ ﻦﻴﻴﻌﺗو ﺎﻬﻓﺮﺼﻟ ﺔﻨﻳﺰﺨﻠﻟ ﺎﻬﻤﻴﻠﺴﺗ و ةرﻮﺗﺎﻓ ﺐﻠﻄﺑ رﻮﻔﻟﺎﺑ مﻮﻗﺄﺳ !ﺎﻨﺴﺣ";


        // Option 2

        Talks[14] = "؟ﻲﻟاﻮﻟا ﺪﻴﺴﻟا ،تﺎﻣﺪﺨﻟا يدﺮﺗ ﺔﻠﻜﺸﻣ ﻞﺤﻟ أﺪﺒﻧ نأ ﻦﻜﻤﻳ ﻦﻳأ ﻦﻣ";





        Talks[15] = "!ﺔﻳﻻﻮﻟا نﺪﻣ ﯽﻠﻋ ﺎﻬﻌﻳزﻮﺗ ﻢﺛ ﺎﻬﻋﺎﻄﻘﺘﺳا و ﺔﺒﺴﻨﻟا بﺎﺴﺣ ﯽﻠﻋ ﻞﻤﻌﻟﺎﺑ رﻮﻔﻟﺎﺑ أﺪﺒﻨﺳ !ﺎﻨﺴﺣ";
        Talks[16] = "!ﺎﻬﻘﻴﻘﺤﺗ ﯽﻠﻋ قﺎﻔﻧﻹا ﻢﺛ ﻒﻴﻟﺎﻜﺘﻟا ﺮﻳﺪﻘﺘﻟ ﺔﻨﺠﻟ ﻦﻴﻴﻌﺘﺑ رﻮﻔﻟﺎﺑ مﻮﻘﻨﺳ !ﺎﻨﺴﺣ";



        Talks[20] = "؟ﻲﻟاﻮﻟا ﺪﻴﺴﻟا ،لﻮﺴﺘﻟا و دﺮﺸﺘﻟا ﺔﻠﻜﺸﻣ ﻞﺤﻟ أﺪﺒﻧ نأ ﻦﻜﻤﻳ ﻦﻳأ ﻦﻣ";

        Talks[21] = "!ﺔﻠﻜﺸﻤﻟا ﻞﺣ ﯽﻠﻋ ﻞﻤﻌﻠﻟ ﺔﻨﺠﻟ ﻞﻴﻜﺸﺗ أﺪﺒﻨﺳ ،ﻲﻟاﻮﻟا يﺪﻴﺳ ﺎﻨﺴﺣ";
        Talks[22] = "عوﺮﺸﻤﻠﻟ ﻂﻴﻄﺨﺘﻠﻟ رﻮﻔﻟا ﯽﻠﻋ ﺔﻨﺠﻟ ﻞﻴﻜﺸﺗ أﺪﺒﻨﺳ ،ﻲﻟاﻮﻟا يﺪﻴﺳ ﺎﻨﺴﺣ";
        Talks[23] = "تﺎﻓوﺮﺼﻤﻟا ﺬﻴﻔﻨﺗ و بﺎﺴﺤﻟ رﻮﻔﻟا ﯽﻠﻋ ﺔﻴﻟﺎﻣ ﺔﻨﺠﻟ ﻞﻴﻜﺸﺗ أﺪﺒﻨﺳ ،ﻲﻟاﻮﻟا يﺪﻴﺳ ﺎﻨﺴﺣ";
        Talks[24] = "عوﺮﺸﻤﻠﻟ ﻂﻴﻄﺨﺘﻠﻟ رﻮﻔﻟا ﯽﻠﻋ ﺔﻨﺠﻟ ﻞﻴﻜﺸﺗ أﺪﺒﻨﺳ ،ﻲﻟاﻮﻟا يﺪﻴﺳ ﺎﻨﺴﺣ";




        Talks[40] = "؟ﻲﻟاﻮﻟا ﺪﻴﺴﻟا ،هﺎﻴﻤﻟا ﺔﻠﻜﺸﻣ ﻞﺤﻟ أﺪﺒﻧ نأ ﻦﻜﻤﻳ ﻦﻳأ ﻦﻣ";
        Talks[41] = "!ﺔﻠﻜﺸﻤﻟا ﻞﺣ ﯽﻠﻋ ﻞﻤﻌﻠﻟ ﺔﻨﺠﻟ ﻞﻴﻜﺸﺗ أﺪﺒﻨﺳ ،ﻲﻟاﻮﻟا يﺪﻴﺳ ﺎﻨﺴﺣ";
        Talks[42] = "ﺔﻧﺎﻴﺼﻟا عوﺮﺸﻣ ﯽﻠﻋ فاﺮﺷﻹاو ﻂﻴﻄﺨﺘﻠﻟ رﻮﻔﻟا ﯽﻠﻋ ﺔﻨﺠﻟ ﻞﻴﻜﺸﺗ أﺪﺒﻨﺳ ،ﻲﻟاﻮﻟا يﺪﻴﺳ ﺎﻨﺴﺣ";



        Talks[60] = "؟ﺔﻳﻻﻮﻟﺎﺑ ﺔﺸﻴﻌﻤﻟا ءﻼﻏ ﺔﻠﻜﺸﻣ ﻞﺤﻟ ﻞﻤﻌﻟا أﺪﺒﻧ نأ ﻦﻜﻤﻳ ﻦﻳأ ﻦﻣ";
        Talks[61] = "قﺎﻔﻧﻹا ءﺪﺑ ﻢﺛ ﺔﻔﻠﻜﺘﻟا بﺎﺴﺣ ﯽﻠﻋ ﻞﻤﻌﻠﻟ ﺔﻨﺠﻟ ﻞﻴﻜﺸﺗ أﺪﺒﻨﺳ ،ﻲﻟاﻮﻟا يﺪﻴﺳ ﺎﻨﺴﺣ";
        Talks[62] = "عوﺮﺸﻤﻟا ءﺎﺸﻧإ ﯽﻠﻋ فاﺮﺷﻹاو ﻂﻴﻄﺨﺘﻟا ﯽﻠﻋ ﻞﻤﻌﻠﻟ ﺔﻨﺠﻟ ﻞﻴﻜﺸﺗ أﺪﺒﻨﺳ ،ﻲﻟاﻮﻟا يﺪﻴﺳ ﺎﻨﺴﺣ";


        Talks[80] = "؟ﺔﻳﻻﻮﻟﺎﺑ ﺔﺸﻴﻌﻤﻟا ءﻼﻏ ﺔﻠﻜﺸﻣ ﻞﺤﻟ ﻞﻤﻌﻟا أﺪﺒﻧ نأ ﻦﻜﻤﻳ ﻦﻳأ ﻦﻣ";
        Talks[81] = " ﺔﻴﻧاﺰﻴﻤﻟا ﻦﻣ ﺐﺋاﺮﻀﻟا ﺔﻤﻴﻗ ﻢﺼﺧ ﻢﺛ ﺔﻔﻠﻜﺘﻟا بﺎﺴﺣ ﯽﻠﻋ ﻞﻤﻌﻠﻟ ﺔﻨﺠﻟ ﻞﻴﻜﺸﺗ أﺪﺒﻨﺳ ،ﻲﻟاﻮﻟا يﺪﻴﺳ ﺎﻨﺴﺣ";
        Talks[82] = "؟ﻞﻤﻌﻧ نأ ﺎﻨﻨﻜﻤﻳ ىﺮﺧأ ﺔﻠﻜﺸﻣ يأ ﯽﻠﻋ.ﻞﺒﻘﻤﻟا مﺎﻌﻟا ﺔﻴﻧاﺰﻴﻤﻟ ﺎﻬﺘﻓﺎﺿاو ﺎﻨﺴﺣ";
        Talks[83] = "؟ﺔﻳﻻﻮﻟﺎﺑ ﺔﺸﻴﻌﻤﻟا ءﻼﻏ ﺔﻠﻜﺸﻣ ﻞﺤﻟ ﻞﻤﻌﻟا أﺪﺒﻧ نأ ﻦﻜﻤﻳ ﻦﻳأ ﻦﻣ";

        Talks[84] = " ﺎﻨﺴﺣ";
        Talks[85] = "ﻪﻴﻠﻋ فاﺮﺷﻹاو ﻂﻴﻄﺨﺘﻟا و عوﺮﺸﻤﻠﻟ ﺔﻔﻠﻜﺘﻟا بﺎﺴﺣ ﯽﻠﻋ ﻞﻤﻌﻠﻟ ﺔﻨﺠﻟ ﻞﻴﻜﺸﺗ أﺪﺒﻨﺳ ،ﻲﻟاﻮﻟا يﺪﻴﺳ ﺎﻨﺴﺣ";


        Talks[90] = "!ىﺮﺧأ ﺔﻠﻜﺸﻣ يأ ﻞﺣ ﯽﻠﻋ ﻞﻤﻌﻠﻟ ﻲﻔﻜﻳ ﻻ ﺔﻴﻧاﺰﻴﻤﻟا ﻦﻣ ﯽﻘﺒﺗ ﺎﻣ نأ وﺪﺒﻳ";
        Talks[91] = " !ةﺪﻴﺟ تاراﺮﻗ ﺎﻧﺬﺨﺗا ﺪﻗ ﺎﻨﻧأ ﻮﺟرأ !مﺎﻌﻟا ﺔﻳﺎﻬﻧ ﯽﺘﺣ نﻵا ﺬﻴﻔﻨﺘﻟا ﯽﻠﻋ ﺰﻴﻛﺮﺘﻟا ﯽﻠﻋ ﻦﻳﺮﺒﺠﻣ ﺎﻨﻧأ وﺪﺒﻳ";


    }


    void Start()
    {

        IsGeneralNoButtonVisible.SetActive(false);
        IsGeneralYesButtonVisible.SetActive(false);

        IsAssistanceGeneralTextVisible.SetActive(false);

        IsD1Visible.SetActive(false);
        IsD1OptionsVisible.SetActive(false);

        IsD2Visible.SetActive(false);
        IsD2OptionsVisible.SetActive(false);

        IsD3Visible.SetActive(false);
        IsD3OptionsVisible.SetActive(false);

        IsD4Visible.SetActive(false);
        IsD4OptionsVisible.SetActive(false);

        IsD5Visible.SetActive(false);
        IsD5OptionsVisible.SetActive(false);

        IsD6Visible.SetActive(false);
        IsD6OptionsVisible.SetActive(false);

        IsD7Visible.SetActive(false);
        IsD7OptionsVisible.SetActive(false);



        FinalReuslt.SetActive(false);

        //Set Points for Players



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

        }



        else if (CurrentState == 3)
        {
            CurrentState = 4;
            StopAllCoroutines();
            StartCoroutine(TypeSentenceGeneralText(Talks[4]));
        }

        else if (CurrentState == 4)
        {
            CurrentState = 5;
            StopAllCoroutines();
            StartCoroutine(TypeSentenceGeneralText(Talks[5]));
        }
        else if (CurrentState == 5)
        {
            CurrentState = 6;
            StopAllCoroutines();
            StartCoroutine(TypeSentenceGeneralText(Talks[6]));
        }
        else if (CurrentState == 6)
        {
            CurrentState = 7;
            StopAllCoroutines();
            StartCoroutine(TypeSentenceGeneralText(Talks[7]));
        }
        else if (CurrentState == 7)
        {
            CurrentState = 8;
            StopAllCoroutines();
            StartCoroutine(TypeSentenceGeneralText(Talks[8]));

            IsGeneralNextButtonVisible.SetActive(false);
            IsGeneralNoButtonVisible.SetActive(true);
            IsGeneralYesButtonVisible.SetActive(true);
        }


        else if (CurrentState == 9)
        {
            BackToMenu();
        }


        else if (CurrentState == 10)
        {
            CurrentState = 11;
            IsGeneralTextVisible.SetActive(false);
            IsAssistanceGeneralTextVisible.SetActive(true);

            IsD1Visible.SetActive(true);

            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[9]));


        }
        else if (CurrentState == 11)
        {
            CurrentState = 12;
            IsD1Visible.SetActive(false);
            IsD2Visible.SetActive(true);

        }
        else if (CurrentState == 12)
        {
            CurrentState = 13;

            IsD2Visible.SetActive(false);
            IsD3Visible.SetActive(true);

            IsD3OptionsVisible.SetActive(true);
            IsAssistanceNextButtonVisible.SetActive(false);

            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[10]));

        }
        else if (CurrentState == 13)
        {
            CurrentState = 13;

            IsD2Visible.SetActive(false);
            IsD3Visible.SetActive(true);

            IsD3OptionsVisible.SetActive(true);
            IsAssistanceNextButtonVisible.SetActive(false);

            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[11]));

        }


        else if (CurrentState == 20)
        {
            CurrentState = 21;

            IsD3Visible.SetActive(false);

            IsD3OptionsVisible.SetActive(false);
            IsAssistanceNextButtonVisible.SetActive(false);

            IsD4Visible.SetActive(true);
            IsD4OptionsVisible.SetActive(true);

            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[20]));

        }

        else if (CurrentState == 21)
        {
            CurrentState = 90;

            IsD4Visible.SetActive(false);
            IsD4OptionsVisible.SetActive(false);

            IsAssistanceNextButtonVisible.SetActive(true);

            PointCals(20);
            PopCals(10);
            BudgetCals(-60);

            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[21]));

        }

        else if (CurrentState == 22)
        {
            CurrentState = 90;

            IsD4Visible.SetActive(false);
            IsD4OptionsVisible.SetActive(false);

            IsAssistanceNextButtonVisible.SetActive(true);

            PointCals(10);
            PopCals(20);
            BudgetCals(-60);

            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[22]));

        }

        else if (CurrentState == 23)
        {
            CurrentState = 90;

            IsD4Visible.SetActive(false);
            IsD4OptionsVisible.SetActive(false);

            IsAssistanceNextButtonVisible.SetActive(true);

            PointCals(5);
            PopCals(10);
            BudgetCals(-60);


            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[23]));

        }




        else if (CurrentState == 40)
        {
            CurrentState = 41;

            IsD3Visible.SetActive(false);

            IsD3OptionsVisible.SetActive(false);
            IsAssistanceNextButtonVisible.SetActive(false);

            IsD6Visible.SetActive(true);
            IsD6OptionsVisible.SetActive(true);

            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[40]));

        }


        else if (CurrentState == 41)
        {
            CurrentState = 90;

            IsD5Visible.SetActive(false);
            IsD5OptionsVisible.SetActive(false);

            IsAssistanceNextButtonVisible.SetActive(true);

            PointCals(20);
            PopCals(10);
            BudgetCals(-20);

            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[41]));

        }

        else if (CurrentState == 42)
        {
            CurrentState = 90;

            IsD5Visible.SetActive(false);
            IsD5OptionsVisible.SetActive(false);

            IsAssistanceNextButtonVisible.SetActive(true);

            PointCals(30);
            PopCals(30);
            BudgetCals(-30);

            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[42]));

        }

        else if (CurrentState == 60)
        {
            CurrentState = 61;

            IsD3Visible.SetActive(false);

            IsD3OptionsVisible.SetActive(false);
            IsAssistanceNextButtonVisible.SetActive(false);

            IsD6Visible.SetActive(true);
            IsD6OptionsVisible.SetActive(true);

            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[60]));

        }


        else if (CurrentState == 61)
        {
            CurrentState = 90;

            IsD6Visible.SetActive(false);
            IsD6OptionsVisible.SetActive(false);

            IsAssistanceNextButtonVisible.SetActive(true);

            PointCals(20);
            PopCals(20);
            BudgetCals(-20);

            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[61]));

        }

        else if (CurrentState == 62)
        {
            CurrentState = 90;

            IsD6Visible.SetActive(false);
            IsD6OptionsVisible.SetActive(false);

            IsAssistanceNextButtonVisible.SetActive(true);

            PointCals(30);
            PopCals(30);
            BudgetCals(-20);

            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[62]));

        }

        else if (CurrentState == 80)
        {
            CurrentState = 81;

            IsD3Visible.SetActive(false);
            IsD3OptionsVisible.SetActive(false);
            IsAssistanceNextButtonVisible.SetActive(false);

            IsD7Visible.SetActive(true);
            IsD7OptionsVisible.SetActive(true);

            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[80]));

        }

        else if (CurrentState == 81)
        {
            CurrentState = 82;

            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[81]));
        }

        else if (CurrentState == 82)
        {
            CurrentState = 83;

            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[82]));
        }

        else if (CurrentState == 83)
        {
        

            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[83]));
        }

        else if (CurrentState == 84)
        {
            CurrentState = 90;
            IsD7Visible.SetActive(false);
            IsD7OptionsVisible.SetActive(false);
            IsAssistanceNextButtonVisible.SetActive(true);

            PointCals(20);
            PopCals(20);
            BudgetCals(-65);

            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[84]));
        }

        else if (CurrentState == 85)
        {
            CurrentState = 90;
            IsD7Visible.SetActive(false);
            IsD7OptionsVisible.SetActive(false);
            IsAssistanceNextButtonVisible.SetActive(true);
            PointCals(30);
            PopCals(30);
            BudgetCals(-65);

            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[85]));
        }


        else if (CurrentState == 90)
        {
            CurrentState = 91;
            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[90]));
        }
        else if (CurrentState == 91)
        {
            CurrentState = 95;
            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[91]));
        }



        if (CurrentState == 95)
        {
            FinalResult();
        }




        /*******************
        else if (CurrentState == 6)
        {
            CurrentState = 7;
            IsGeneralTextVisible.SetActive(false);
            // IsAssistanceGeneralTextVisible.SetActive(true);

            IsD1Visible.SetActive(true);

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

            PointCals(40);
            PopCals(40);
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
            CurrentState = 16;
            IsD2Visible.SetActive(false);
            IsD2OptionsVisible.SetActive(false);
            IsAssistanceNextButtonVisible.SetActive(true);

            PointCals(20);
            PopCals(20);
            BudgetCals(-65);

            StopAllCoroutines();
            StartCoroutine(TypeSentenceAssistanceText(Talks[13]));
        }
        else if (CurrentState == 16)
        {
            CurrentState = 30;
            StopAllCoroutines();

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

            PointCals(30);
            PopCals(60);
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
            BudgetCals(-65);

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

        */


    }



    public void GeneralTextNo()
    {
        CurrentState = 9;
        MyManageState();
    }


    public void GeneralTextYes()
    {
        CurrentState = 10;
        MyManageState();
    }


    public void D3Option1()
    {
        CurrentState = 20;
        MyManageState();
    }

    public void D3Option1Option1()
    {
        CurrentState = 21;
        MyManageState();
    }

    public void D3Option1Option2()
    {
        CurrentState = 22;
        MyManageState();
    }

    public void D3Option1Option3()
    {
        CurrentState = 23;
        MyManageState();
    }

    public void D3Option2()
    {
        CurrentState = 40;
        MyManageState();
    }

    public void D3Option2Option1()
    {
        CurrentState = 41;
        MyManageState();
    }

    public void D3Option2Option2()
    {
        CurrentState = 42;
        MyManageState();
    }

    public void D3Option3()
    {
        CurrentState = 60;
        MyManageState();
    }

    public void D3Option4()
    {
        CurrentState = 80;
        MyManageState();
    }

    public void D3Option4Optoin1()
    {
        CurrentState = 84;
        MyManageState();
    }
    public void D3Option4Optoin2()
    {
        CurrentState = 85;
        MyManageState();
    }


    public void D3Option3Optoin1()
    {
        CurrentState = 61;
        MyManageState();
    }
    public void D3Option3Optoin2()
    {
        CurrentState = 62;
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
