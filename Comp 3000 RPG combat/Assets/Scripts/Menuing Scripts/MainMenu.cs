using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void PlayGame()
    {
        Debug.Log("This will send you to the main game screen");
    }

    public void Options()
    {
        Debug.Log("This will load the options");
    }
    
    public void QuitGame()
    {
        Debug.Log("QuitButtonPressed");
        Application.Quit();
    }
}
