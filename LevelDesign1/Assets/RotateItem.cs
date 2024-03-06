using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateItem : MonoBehaviour
{
    [SerializeField] private float _speed = 2.0f; // Velocidad de movimiento
    [SerializeField] private float _amplitude = 0.5f; // Amplitud del movimiento
    [SerializeField] private float _rotSpeed= 10; 

    void Update()
    {
        float verticalMovement = Mathf.Sin(Time.time * _speed) * _amplitude;
        gameObject.transform.Translate(0, verticalMovement * Time.deltaTime, 0);

        gameObject.transform.Rotate(Vector3.up, _rotSpeed * Time.deltaTime);
    }
    
}