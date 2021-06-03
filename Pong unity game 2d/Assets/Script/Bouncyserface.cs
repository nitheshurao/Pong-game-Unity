using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncyserface : MonoBehaviour
{

    public float bounceStrangth = 10.0f;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Ball Ball = other.gameObject.GetComponent<Ball>();
        if(Ball != null)
        {
            Vector2 normal = other.GetContact(0).normal;
            Ball.AddForce(normal * this.bounceStrangth);
        }
    }
}
