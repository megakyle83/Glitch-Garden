using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseLife : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        FindObjectOfType<Lives>().LoseLife();
        Destroy(otherCollider.gameObject);
    }
}
