using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public Transform player;
    public Camera playerCamera;
    public float sensitivity = 100f;
    public float pickupRange = 10f;
    float xRotation = 0;
    private string selectableTag = "PickableObject";
    private Outline outline;
    private PickUp pickableObject;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        outline = gameObject.AddComponent<Outline>();
        pickableObject = gameObject.AddComponent<PickUp>();
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        player.Rotate(Vector3.up * mouseX);

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

        //Debug.DrawRay(transform.position, Vector3.forward * pickupRange, Color.green);

        // player's line of sight for interaction with objects
        //Ray ray = playerCamera.ScreenPointToRay(Input.mousePosition);
        Ray ray = playerCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, pickupRange))
        {
            //pickableObject.OnMouseDown();

            var selection = hit.transform;
            // outline obj while gazing at it 
            if (selection.CompareTag(selectableTag))
            {
                print("gazing at a pickable object");
                outline.OutlineMode = Outline.Mode.OutlineVisible;
                outline.OutlineColor = Color.yellow;
                outline.OutlineWidth = 8f;
            }
            // else
            // {

            //     outline.OutlineColor = Color.clear;
            //     outline.OutlineWidth = 0f;

            // }

        }

    }
}
