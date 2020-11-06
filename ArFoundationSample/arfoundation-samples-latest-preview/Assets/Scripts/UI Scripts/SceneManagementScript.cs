using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManagementScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PreviousStory()
    {
        var scene = SceneManager.GetActiveScene().name;
        if(string.Equals(scene, "Story 1", System.StringComparison.InvariantCultureIgnoreCase))
        {

        }
        if (string.Equals(scene, "Story 2", System.StringComparison.InvariantCultureIgnoreCase))
        {
            SceneManager.LoadScene("Story 1");
        }
        if (string.Equals(scene, "Story 3", System.StringComparison.InvariantCultureIgnoreCase))
        {
            SceneManager.LoadScene("Story 2");
        }
    }

    public void NextStory()
    {
        var scene = SceneManager.GetActiveScene();
        if (string.Equals(scene, "Story 1", System.StringComparison.InvariantCultureIgnoreCase))
        {
            SceneManager.LoadScene("Story 2");
        }
        if (string.Equals(scene, "Story 2", System.StringComparison.InvariantCultureIgnoreCase))
        {
            SceneManager.LoadScene("Story 3");
        }
        if (string.Equals(scene, "Story 3", System.StringComparison.InvariantCultureIgnoreCase))
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
