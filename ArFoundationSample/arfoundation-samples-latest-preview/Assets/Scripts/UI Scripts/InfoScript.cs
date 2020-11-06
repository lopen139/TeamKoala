using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoScript : MonoBehaviour
{
    public GameObject panel;

    public void SourceClick()
    {
        
        panel.SetActive(!panel.activeSelf);
    }
}
