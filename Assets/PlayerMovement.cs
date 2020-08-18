using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float raycastdistance = 1f;
    public float speed = 5f;
   Rigidbody rb;

    float x;
    float y;
    Vector3 input;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
       

    }
    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
        input.x = x;
        input.z = y;

        RaycastHit hit;
        if (Physics.Raycast(Vector3.zero, Vector3.right, out hit, raycastdistance))
        {
            Debug.Log("ray hit with" + hit.collider.gameObject.name);
        
        }
        
        Debug.DrawRay(Vector3.zero, Vector3.right * raycastdistance, Color.green);
    }
    private void FixedUpdate()
    {
        //Vector3 desiredposition = transform.position + new Vector3(x, y, 0f) * speed * Time.fixedDeltaTime;
        Vector3 velocity = input.normalized * speed;
        rb.velocity = velocity;

    }
    private int GetInt()
    {
        int n = 1;
        return n;
    }

}