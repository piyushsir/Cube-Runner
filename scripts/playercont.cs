using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class playercont : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    public float jumpForce;
    bool canJump;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && canJump)
        {
            rb.AddForce(Vector3.up * jumpForce,ForceMode.Impulse);
        }
    }
    private void OnCollisionEnter(Collision c)
    {
        if(c.gameObject.tag=="ground")
        {
            canJump=true;
        }
    }
    private void OnCollisionExit(Collision c)
    {
        if(c.gameObject.tag=="ground")
        {
            canJump=false;
        }
    }
    private void OnTriggerEnter(Collider c)
    {
        if(c.gameObject.tag=="obstacle")
        {
            SceneManager.LoadScene("games");
        }
    }
}
