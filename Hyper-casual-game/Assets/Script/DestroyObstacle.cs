using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacle : MonoBehaviour
{ public ObstacleCollider obstacleCollider;
    
public void OnCollisionEnter2D(Collision2D colliderInfo)
{
   if(colliderInfo.collider.tag != "Player")
    Destroy(colliderInfo.collider.gameObject);
     
    
         }
}
