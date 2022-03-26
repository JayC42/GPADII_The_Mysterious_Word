using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField] private Transform container;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void OnMouseDown()
    {
        // disable gravity on RigidBody and set obj transform to container
        rb.useGravity = false;
        this.transform.position = container.position;
        this.transform.parent = GameObject.Find("Pickup Container").transform;
    }

    public void OnMouseUp()
    {
        this.transform.parent = null;
        rb.useGravity = true;
    }

}
