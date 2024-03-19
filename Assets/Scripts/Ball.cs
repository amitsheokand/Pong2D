using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


[RequireComponent(typeof(Rigidbody2D))]
public class Ball : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        // flip a coin
        int coinValue = Random.Range(0, 2);
        
        if (coinValue == 0) // start towards left
        {
            Vector2 randomForce = new Vector2(Random.Range(-1.0f, -10.0f), 0);
            _rigidbody2D.AddForce(randomForce, ForceMode2D.Impulse);
        }
        else  // start towards right
        {
            Vector2 randomForce = new Vector2(Random.Range(1.0f, 10.0f), 0);
            _rigidbody2D.AddForce(randomForce, ForceMode2D.Impulse);
        }
        
       
       

    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
