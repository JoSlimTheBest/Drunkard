using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInputController : MonoBehaviour
{
    private PlayerAction _playerAction;
    public float speed=2f;
    public Animator animator;


    private void Awake()
    {
        _playerAction = new PlayerAction();
        _playerAction.Enable();
        animator = GetComponentInChildren<Animator>();
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
        {
            Vector3 real = new Vector3(-directon.y, 0, directon.x);
            GetComponentInChildren<Transform>().position += real* speed;
            animator.StopPlayback();
        }
        else
        {
            
        }
           
       
    }
}
