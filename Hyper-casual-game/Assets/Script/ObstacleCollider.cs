using UnityEngine;

public class ObstacleCollider : MonoBehaviour
{ 
  public Score scoreObject;
  public ObstacleCollider obstacleCollider;
  public PlayerMovement playerMovement;
  public ObjectSpawner objectSpawner;
  public int updateScore = 0;
  public GameObject CanvasScreenEnble;
    
public void OnCollisionEnter2D(Collision2D colliderInfo)
{
  MeshRenderer renderer = colliderInfo.collider.GetComponent<MeshRenderer>();
  if (renderer) {
             Color color = renderer.material.color;
            if (color == Color.blue)
            {
             updateScore++;
             scoreObject.UpdatedScore(updateScore);
              Destroy(colliderInfo.collider.gameObject);
          
            }
            else
            if(color == Color.red)
            {

               CanvasScreenEnble.SetActive(true);
               Destroy(colliderInfo.gameObject);
               objectSpawner.enabled = false;
               playerMovement.enabled = false;
               Time.timeScale = 0;

            }
         }
}
}
