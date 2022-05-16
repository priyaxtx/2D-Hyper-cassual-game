using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  public  GameManager gm;
 public GameObject CanvasScreenEnble;
   public void Start()
    {
        Time.timeScale = 1;
    }

   public void GameOver()
    {
        CanvasScreenEnble.SetActive(true);
        Time.timeScale = 0;
        
    }
}