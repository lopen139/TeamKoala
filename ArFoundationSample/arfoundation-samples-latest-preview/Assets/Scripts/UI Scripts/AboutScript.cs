using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AboutScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void GoToAbout()
    {
        SceneManager.LoadScene("About");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
