using System.Collections;
using UnityEngine;

public class DestroyController : MonoBehaviour
{

    void Start()
    {
        
     
    }

    void Update()
    {

        if(transform.position.z < Camera.main.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
    
}
