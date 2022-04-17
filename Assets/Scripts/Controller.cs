using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float moveSpeed = 6;
    Rigidbody rigidbodyComponent;
    Camera viewCamera;
    Vector3 velocity;
    public Vector3 AimPos;
    // Start is called before the first frame update
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody> ();
        viewCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = viewCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, viewCamera.transform.position.y));
        AimPos = mousePos + Vector3.up * transform.position.y;
        transform.LookAt(AimPos);
        velocity = new Vector3 (Input.GetAxisRaw("Horizontal"), 0.0f, Input.GetAxisRaw("Vertical")).normalized * moveSpeed;
    }

    void FixedUpdate()
    {
        rigidbodyComponent.MovePosition(rigidbodyComponent.position + velocity * Time.fixedDeltaTime);
    }
}
