using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class EndScore : MonoBehaviour
{
     public  TextMeshProUGUI Score; 
     Score s;

    void Start()
    {
        // Score.text="";
    }
    public void UpdatedScores()
    {
        Score.text = s.score.text; 
        Debug.Log("helloo   "+s.score.text);
    }
}
