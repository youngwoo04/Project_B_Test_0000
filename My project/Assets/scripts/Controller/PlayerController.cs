using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movespeed = 1.0f;
    public GameObject PlayerPivot;
    Camera viewCamera;
    Vector3 velocity;
    public ProjectileController projectileController;


    // Start is called before the first frame update
    void Start()
    {
        viewCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousepos = viewCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, viewCamera.transform.position.y));

        Vector3 targetposition = new Vector3(mousepos.x, transform.position.y, mousepos.z);

        PlayerPivot.transform.LookAt(targetposition, Vector3.up);

        velocity = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * movespeed;

        if(Input.GetMouseButtonDown(0))
        {
            projectileController.FireProjectile();
        }

    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + velocity * Time.fixedDeltaTime);
    }

}
