using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Levels : MonoBehaviour
{
    public Text LevelTitle;
    public Text Level1Goals;
    public Text Level2Goals;
    public Text Level3Goals;
    public Text Level4Goals;
    public Text Level5Goals;
    public Text Level6Goals;
    public Text Level7Goals;
    public Text Level8Goals;

    string Level1Title = "ﻚﺘﻴﻠﺤﻣ ﺪﻋﺎﺳ";
   

    string Level2Title = "ﻚﺘﻳﻻو ﺪﻋﺎﺳ";
  
    string Level3Title = "٢ﻚﺘﻳﻻو ﺪﻋﺎﺳ";
  
    string Level4Title = "ﻚﺘﻳﻻو ﯽﻠﻋ ﻖﻔﻧأ";
   



    string Level5Title = "٢ﻚﺘﻳﻻو ﯽﻠﻋ ﻖﻔﻧأ";
   

    string Level6Title = "ﻢﻴﻠﻗﻹا ﺪﻋﺎﺳ";
   


    string Level7Title = "ﻢﻴﻠﻗﻹا ﯽﻠﻋ ﻖﻔﻧأ";
  

    string Level8Title = "ﺔﻟوﺪﻟا ﯽﻠﻋ ﻖﻔﻧأ";
   


    public int SelectedLevelId = 1;


    private void Start()
    {
        HideAllDesc();
        Level1Goals.enabled = true;
    }

    public void LoadLevel()
    {
        if (SelectedLevelId == 1)
        {
            SceneManager.LoadScene("Level1");
        }
        else if (SelectedLevelId == 2)
        {
            SceneManager.LoadScene("Level2");

        }
        else if (SelectedLevelId == 3)
        {
            SceneManager.LoadScene("Level3");

        }
        else if (SelectedLevelId == 4)
        {
            SceneManager.LoadScene("Level4");

        }
        else if (SelectedLevelId == 5)
        {
            SceneManager.LoadScene("Level4");

        }
        else if (SelectedLevelId == 6)
        {
            SceneManager.LoadScene("Level6");

        }
        else if (SelectedLevelId == 7)
        {
            SceneManager.LoadScene("Level7");

        }
        else if (SelectedLevelId == 8)
        {
            SceneManager.LoadScene("Level8");

        }

    }

   


    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }





    public void LoadLevel1Info()
    {
        SelectedLevelId = 1;
        UpdateLevelDesc();
    }

    public void LoadLevel2Info()
    {
        SelectedLevelId = 2;
        UpdateLevelDesc();
    }


    public void LoadLevel3Info()
    {
        SelectedLevelId = 3;
        UpdateLevelDesc();
    }

    public void LoadLevel4Info()
    {
        SelectedLevelId = 4;
        UpdateLevelDesc();
    }

    public void LoadLevel5Info()
    {
        SelectedLevelId = 5;
        UpdateLevelDesc();
    }

    public void LoadLevel6Info()
    {
        SelectedLevelId = 6;
        UpdateLevelDesc();
    }

    public void LoadLevel7Info()
    {
        SelectedLevelId = 7;
        UpdateLevelDesc();
    }

    public void LoadLevel8Info()
    {
        SelectedLevelId = 8;
        UpdateLevelDesc();
    }

    public void UpdateLevelDesc()
    {
        if (SelectedLevelId == 1)
        {
            print("level1");
            StopAllCoroutines();
        
            StartCoroutine(TypeSentence(Level1Title));
            HideAllDesc();
            Level1Goals.enabled = true;

        }
        else if (SelectedLevelId == 2)
        {
            print("level2");
            StopAllCoroutines();
            StartCoroutine(TypeSentence(Level2Title));
            TypeSentence(Level2Title);
            HideAllDesc();
            Level2Goals.enabled = true;
        }

        else if (SelectedLevelId == 3)
        {
            print("level3");
            StopAllCoroutines();
            StartCoroutine(TypeSentence(Level3Title));
            TypeSentence(Level3Title);

            HideAllDesc();
            Level3Goals.enabled = true;
        }

        else if (SelectedLevelId == 4)
        {
            print("level4");
            StopAllCoroutines();
            StartCoroutine(TypeSentence(Level4Title));
            TypeSentence(Level4Title);

            HideAllDesc();
            Level4Goals.enabled = true;
        }
        else if (SelectedLevelId == 5)
        {
            print("level5");
            StopAllCoroutines();
            StartCoroutine(TypeSentence(Level5Title));
            TypeSentence(Level5Title);

            HideAllDesc();
            Level5Goals.enabled = true;
        }
        else if (SelectedLevelId == 6)
        {
            print("level6");
            StopAllCoroutines();
            StartCoroutine(TypeSentence(Level6Title));
            TypeSentence(Level6Title);


            HideAllDesc();
            Level6Goals.enabled = true;
        }
        else if (SelectedLevelId == 7)
        {
            print("level7");
            StopAllCoroutines();
            StartCoroutine(TypeSentence(Level7Title));
            TypeSentence(Level7Title);

            HideAllDesc();
            Level7Goals.enabled = true;
        }
        else if (SelectedLevelId == 8)
        {
            print("level8");
            StopAllCoroutines();
            StartCoroutine(TypeSentence(Level8Title));
            TypeSentence(Level8Title);

            HideAllDesc();
            Level8Goals.enabled = true;
        }
    }



    IEnumerator TypeSentence(string title)
    {

        LevelTitle.text = "";
      
        foreach (char letter in title.ToCharArray())
        {
            LevelTitle.text += letter;

            yield return null;
        }

       
    }

    public void HideAllDesc()
    {
        Level1Goals.enabled = false;
        Level2Goals.enabled = false;
        Level3Goals.enabled = false;
        Level4Goals.enabled = false;
        Level5Goals.enabled = false;
        Level6Goals.enabled = false;
        Level7Goals.enabled = false;
        Level8Goals.enabled = false;
    }

}
