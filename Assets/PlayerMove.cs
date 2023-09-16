using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
  private int snapDistance = 4;
  private CharacterController controller;

  // Start is called before the first frame update
  void Start()
  {
    controller = gameObject.AddComponent<CharacterController>();
  }

  // Update is called once per frame
  void Update()
  {
    float horizontal = Input.GetAxisRaw("Horizontal");
    float vertical = Input.GetAxisRaw("Vertical");

    float xPos = horizontal * snapDistance;
    float yPos = vertical * snapDistance;
    float zPos = transform.position[2];

    Vector3 newPos = new Vector3(xPos, yPos, zPos);

    transform.position = newPos;
  }
}

