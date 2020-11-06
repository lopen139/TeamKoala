using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeButotnScript : MonoBehaviour
{
    public void GoToHome()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
