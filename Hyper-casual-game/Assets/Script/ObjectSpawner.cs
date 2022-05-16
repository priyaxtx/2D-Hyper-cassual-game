using UnityEngine;
[RequireComponent(typeof(Renderer))]
public class ObjectSpawner : MonoBehaviour
{
     public GameObject Circle;
    public float maxTime = 0.3f;
    private float timer =0;
    void Start()
    {

        GameObject NewCircle = Instantiate(Circle);
        var circleRenderer = NewCircle.GetComponent<MeshRenderer>();
           circleRenderer.material.SetColor("_Color",Color.red);
        NewCircle.transform.position = transform.position + new Vector3(Random.Range(-2.43f,2.77f),5.33f,11.91502f);
    }

    void Update()
    {
        if(timer>maxTime)
        {
            GameObject NewCircle = Instantiate(Circle);
           
            NewCircle.transform.position = transform.position + new Vector3(Random.Range(-2.43f,2.77f),5.33f,11.91502f);
            
            var circleRenderer = NewCircle.GetComponent<MeshRenderer>();
            if (UnityEngine.Random.Range(0, 2) == 0){
             circleRenderer.material.SetColor("_Color",Color.blue);
            }
             else{
                  circleRenderer.material.SetColor("_Color",Color.red);
             }
            Destroy(NewCircle,1.5f);
            timer=0;
        
        }
        timer +=Time.deltaTime;
    }
}
