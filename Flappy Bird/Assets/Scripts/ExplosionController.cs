using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionController : MonoBehaviour
{
    // Length of explosion before being destroyed
    [SerializeField] float lifetime = 1.25f;
    void Start()
    {
        Destroy(gameObject, lifetime);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
