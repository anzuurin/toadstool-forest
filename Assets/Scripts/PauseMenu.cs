using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class PauseMenu : MonoBehaviour
{

    public string mainMenuScene; 
    public GameObject pauseMenu; 
    private bool isPaused = false; 

    public void resumeGame(){
        Debug.Log("resume");
        isPaused = false; 
        pauseMenu.SetActive(false);
        Time.timeScale = 1.0f; 
    }

    public void pauseGame(){
        Debug.Log("pause");
        isPaused = true; 
        pauseMenu.SetActive(true);
        Time.timeScale = 0f; 
    }

    public void returnToMainMenu(){
        isPaused = false; 
        Debug.Log("returned to main menu");
        SceneManager.LoadScene(mainMenuScene);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(isPaused){
                resumeGame(); 
            }else{
                pauseGame(); 
            }
        }
    }

    
}
