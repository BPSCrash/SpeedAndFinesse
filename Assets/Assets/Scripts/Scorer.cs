using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int _wallHits = 0;
    private int _eggHits = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.parent.tag != "Boundary" && collision.transform.tag == "Wall")
        {
            _wallHits++;
            if (_wallHits < 1)
            {
                Debug.Log("You've hit a wall " + _wallHits + " time");
            }
            else
            {
                Debug.Log("You've hit a wall " + _wallHits + " times");
            }

        }
        if (collision.transform.tag == "Egg")
        {
            _eggHits++;
            if (_eggHits < 1)
            {
                Debug.Log("You've been hit by an egg " + _eggHits + " time");
            }
            else
            {
                Debug.Log("You've been hit by an egg " + _eggHits + " times");
            }

        }

    }
}
