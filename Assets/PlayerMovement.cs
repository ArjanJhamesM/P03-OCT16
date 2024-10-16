using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;

    public PlayerInputs playerInputs;

    private Vector2 movement;

    private void Awake()
    {
        playerInputs = new PlayerInputs();
    }

    private void OnEnable()
    {
        playerInputs.Enable();
    }

    private void OnDisable()
    {
        playerInputs.Disable();
    }
    
    private void Update()
    {
        #region Legacy
        /*float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(x, 0, z);

        transform.Translate(move * Time.deltaTime * speed);

        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("ALLAHU AKBAR");
        }*/
        #endregion

        movement = playerInputs.Action.Movement.ReadValue<Vector2>();
        transform.Translate(new Vector3(movement.x, 0, movement.y) * Time.deltaTime * speed);
    }
}
