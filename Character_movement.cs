using UnityEngine;
using System.Collections;

public class Player_2_movement : MonoBehaviour {

    public float speed;

    void Update() {

        if (Input.GetKey(KeyCode.D)) {
            GetComponent<Rigidbody2D>().AddForce(Vector2.right * speed);
        }
        if (Input.GetKey(KeyCode.W)) {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * speed);
        } 
        if (Input.GetKey(KeyCode.A)) {
            GetComponent<Rigidbody2D>().AddForce(-Vector2.right * speed);
        } 
        if (Input.GetKey(KeyCode.S)) {
            GetComponent<Rigidbody2D>().AddForce(-Vector2.up * speed);
        }
    }
}
