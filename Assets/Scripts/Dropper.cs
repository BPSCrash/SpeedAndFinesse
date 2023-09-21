using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] int _secondsUnitlDrop = 3;
    MeshRenderer _renderer;
    Rigidbody _rigidBody;

    private void Start()
    {
        _renderer = GetComponent<MeshRenderer>();
        _rigidBody = GetComponent<Rigidbody>();

        _renderer.enabled = false;
        _rigidBody.useGravity = false;
    }
    private void Update()
    {
        if (Time.time > _secondsUnitlDrop)
        {
            _renderer.enabled = true;
            _rigidBody.useGravity = true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            //ADD EGG SPLAT and Particle System
            GameObject.Destroy(this.gameObject);
        }
    }
}
