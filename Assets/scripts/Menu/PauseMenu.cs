using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
   [SerializeField] GameObject pauseMenu;
   
   public void Pause() {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
   }

   public void Home() {
        SceneManager.LoadScene(2);
        Timer.elapsedTime = 0.0f;
        Timer2.elapsedTime = 0.0f;
        Timer3.elapsedTime = 0.0f;
        Time.timeScale = 1;

   }

   public void Resume() {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
   }

   public void Restart() {
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
         Timer.elapsedTime += 3.0f;
         Time.timeScale = 1;
   }


}
