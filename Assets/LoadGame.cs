using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGame : MonoBehaviour
{
   public void LoadScene()
   {
       UnityEngine.SceneManagement.SceneManager.LoadScene(1);
   }

   public void QuitGame()
   {
       Application.Quit();
   }

}

