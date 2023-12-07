using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class tonextscene_home : MonoBehaviour
{
    void OnEnable()
    {
        SceneManager.LoadScene("MainScene");
    }
}