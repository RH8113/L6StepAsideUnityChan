using System.Collections;
using UnityEngine;

public class CoinCotroller : MonoBehaviour
{
    void Start()
    {
        this.transform.Rotate(0, Random.Range(0, 360), 0);
    }

    void Update()
    {
        this.transform.Rotate(0, 3, 0);
        
    }
}
