using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

    public float segundos;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, segundos);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
