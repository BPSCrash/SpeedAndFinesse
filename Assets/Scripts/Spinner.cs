using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float _rotationSpeed = 500f;

    void Update()
    {
        transform.Rotate(new Vector3(0f, _rotationSpeed* Time.deltaTime , 0f));
    }
}
