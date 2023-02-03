using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void StartGaame()
    {
        
        


            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }
}
