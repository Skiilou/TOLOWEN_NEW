using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCollider : MonoBehaviour
{
    public GameObject colliderActif;
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("test");
        colliderActif = collision.gameObject;
    }
}
