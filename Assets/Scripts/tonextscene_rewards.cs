using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class tonextscene_rewards : MonoBehaviour
{
    void OnEnable()
    {
        SceneManager.LoadScene("RewardsScene");
    }
}