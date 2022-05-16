using UnityEngine.SceneManagement;
using UnityEngine;

public class EndGame : MonoBehaviour
{
  public void StartGame()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Quit()
    {
       Debug.Log("application is quit");
         Application.Quit();
    }

}