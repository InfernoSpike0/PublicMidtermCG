using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed = 5f;
    float jumpForce = 10f;
    bool isGrounded = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space))
            if (isGrounded == true)
                {
                    isGrounded = false;
                    GetComponent<Rigidbody>().AddForce(Vector2.up * jumpForce, ForceMode.Impulse);
                }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
