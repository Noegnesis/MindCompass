using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class tonextscene_breath : MonoBehaviour
{
    void OnEnable()
    {
        SceneManager.LoadScene("ImmersiveMeditationScene");
    }
}
