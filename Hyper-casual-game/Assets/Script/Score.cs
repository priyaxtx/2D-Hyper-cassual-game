using UnityEngine.UI;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
  public Score s;
    public  TextMeshProUGUI score; 
   public void UpdatedScore(int updateScore)
    {
        score.text = updateScore.ToString(); 
    }
}
