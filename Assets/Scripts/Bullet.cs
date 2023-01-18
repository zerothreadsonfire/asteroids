using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
  public float speed = 500f;
  public float maxLifetime = 2f;

  private new Rigidbody2D rigidbody;

  private void Awake() {
    rigidbody = GetComponent<Rigidbody2D>();
  }

  public void project(Vector2 direction) {
    rigidbody.AddForce(direction * speed);
  }

  private void OnCollisionEnter2D(Collision2D collision) {
    Destroy(this.gameObject);
  }
}
