using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField] private Transform container;
    private Rigidbody rb;
    Outline outline;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        outline = GetComponent<Outline>();
        outline.OutlineMode = Outline.Mode.OutlineHidden;
        
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

    public void OnMouseEnter()
    {
        outline.OutlineMode = Outline.Mode.OutlineVisible;
    }

    public void OnMouseExit() 
    {
        outline.OutlineMode = Outline.Mode.OutlineHidden;
    }
}
