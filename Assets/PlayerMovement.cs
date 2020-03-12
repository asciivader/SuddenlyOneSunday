using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float sidewaysForce = 10f;
    void FixedUpdate () {

        if (Input.GetKey("d"))
        {
            rb.AddForce(new Vector2(sidewaysForce * Time.deltaTime, 0), ForceMode2D.Force);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(new Vector2(-sidewaysForce * Time.deltaTime, 0), ForceMode2D.Force);
        }
        
    }
}
