using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickARScene : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void GoToARScene()
    {
        SceneManager.LoadScene("AR");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
