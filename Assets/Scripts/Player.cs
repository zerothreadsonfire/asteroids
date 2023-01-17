using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  [SerializeField] float thrustSpeed = 1f;
  [SerializeField] float turnSpeed = 1f;

  private bool thrusting;
  private float turnDirection;

  private new Rigidbody2D rigidbody;
  
  private void Awake() {
    rigidbody = GetComponent<Rigidbody2D>();
    thrusting = false;
    turnDirection = 0.0f;
  }

  private void Update() {
    thrusting = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W);

    if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
      turnDirection = 1f;
    } else if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
      turnDirection = -1f;
    } else {
      turnDirection = 0f;
    }

  }

  private void FixedUpdate() {

    if(thrusting == true) {
      rigidbody.AddForce(this.transform.up * thrustSpeed);
    }

    if(turnDirection != 0f) {
      rigidbody.AddTorque(turnDirection * turnSpeed);
    }

  }
}
