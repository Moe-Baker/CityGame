using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    [SerializeField]
    float duration = 5;

    void Start()
    {
        StartCoroutine(DelayLoadLevel());
    }

    IEnumerator DelayLoadLevel()
    {
        yield return new WaitForSeconds(duration);

        SceneManager.LoadScene("Menu");
    }
}
