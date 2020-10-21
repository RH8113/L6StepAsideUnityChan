using System.Collections;
using UnityEngine;

public class DestroyController : MonoBehaviour
{
    private float deadLine = -1;

    void Start()
    {
        
    }

    
    void Update()
    {
        if(transform.position.z < this.deadLine)
        {
            Destroy(gameObject);
        }
    }
}
