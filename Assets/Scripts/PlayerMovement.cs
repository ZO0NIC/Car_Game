using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardMove = 500f;
    public float PlayerMove = 500f;

    void Update()
    {
        if(Input.GetKey("d"))
        {
            rb.AddForce(PlayerMove * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-PlayerMove * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        rb.AddForce(0, 0, forwardMove * Time.deltaTime);
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
