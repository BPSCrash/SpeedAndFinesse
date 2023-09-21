using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int _wallHits = 0;
    private int _eggHits = 0;
    private int _rollerHits = 0;

    private void OnCollisionEnter(Collision collision)
    {
        string collisionTag = collision.transform.tag;
        if (collision.transform.parent.tag != "Boundary")
        {
            switch (collisionTag)
            {
                case "Wall":
                    _wallHits++;
                    break;
                case "Egg":
                    _eggHits++;
                    break;
                case "Roller":
                    _rollerHits++;
                    break;
            }
        }
        LogHits(collisionTag, GetHitCount(collisionTag));


    }

    private int GetHitCount(string tag)
    {
        switch (tag)
        {
            case "Wall":
                return _wallHits;
            case "Egg":
                return _eggHits;
            case "Roller":
                return _rollerHits;
            default:
                return 0;
        }
    }

    void LogHits(string tag, int hits)
    {
        string word = (hits > 1) ? "times" : "time";
        Debug.Log($"You've hit a {tag} {hits} {word}");
    }
}
