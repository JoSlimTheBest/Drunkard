using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterInputController : MonoBehaviour
{
    private PlayerAction _playerAction;
    public float speed=2f;
    public Animator _animator;
   


    private void Awake()
    {
        _playerAction = new PlayerAction();
        _playerAction.Enable();
        _animator = GetComponent<Animator>();
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


    private void CharacterMove(Vector2 direction)
    {
        if (direction.x != 0 || direction.y != 0)
        {
           

        }

        if (direction.x != 0 || direction.y != 0)
        {

            Vector3 real = new Vector3(-direction.y, 0, direction.x);
            GetComponent<Transform>().position += real * speed;
            // Преобразование направления из 2D в 3D
            Vector3 movementDirection = new Vector3(-direction.y, 0, direction.x);

            // Движение персонажа
            GetComponent<Transform>().position += movementDirection * speed * Time.deltaTime;

            // Поворот персонажа в направлении движения
            Transform characterTransform = GetComponent<Transform>();
            Quaternion targetRotation = Quaternion.LookRotation(movementDirection);
            characterTransform.rotation = Quaternion.Lerp(characterTransform.rotation, targetRotation, Time.deltaTime * 10); // Интерполяция для плавности


            // Включение анимации движения
            _animator.SetBool("isMoving", true);
        }
        else
        {
            // Выключение анимации движения
            _animator.SetBool("isMoving", false);    
        }
    }
}
