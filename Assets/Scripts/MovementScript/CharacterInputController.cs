using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInputController : MonoBehaviour
{
    private PlayerAction _playerAction;
    public float speed=2f;


    private void Awake()
    {
        _playerAction = new PlayerAction();
        _playerAction.Enable();
    }

    private void OnEnable()
    {
       
    }

    private void OnDisable()
    {

    }


    private void Update()
    {
        ReadMovement();
    }

    private void ReadMovement()
    {
        var inputDirection = _playerAction.Gameplay.Movement.ReadValue<Vector2>();
        CharacterMove(inputDirection);

    }


    private void CharacterMove(Vector2 directon)
    {
        if (directon.x != 0 || directon.y != 0)
            GetComponentInChildren<Transform>().position += new Vector3(-directon.y,0, directon.x) *speed;
       
    }
}
