using System;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMoviment : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    public GameObject platform;
    public GameObject heightInfo;

    private float horizontalRotation;
    private float verticalRotation;

    private PlayerMovimentState state = PlayerMovimentState.StandingBy;

    private float initialPosition = 0f;
    public static float MaxHeight = 80;

    private void Awake()
    {
        initialPosition = platform.transform.position.y;
    }

    private void OnHorizontalMovement(InputValue input)
    {
        var value = input.Get<float>();

        horizontalRotation = value;
    }

    private void OnVerticalMovement(InputValue input)
    {
        var value = input.Get<float>();

        verticalRotation = value;
    }

    private void OnGoUp()
    {
        state = GetNewState(PlayerMovimentState.GoingUp);
    }

    private void OnGoDown()
    {
        state = GetNewState(PlayerMovimentState.GoingDown);
    }

    private void OnReset()
    {
        state = GetNewState(PlayerMovimentState.Reseting);
    }

    private void OnGoToHighest()
    {
        state = GetNewState(PlayerMovimentState.GoingToHighest);
    }

    PlayerMovimentState GetNewState(PlayerMovimentState newState)
        => state == newState ? PlayerMovimentState.StandingBy : newState;

    private void GoUp(float limit)
    {
        Move(1, limit, (limit, next) => next <= limit);
    }

    private void GoDown(float limit)
    {
        Move(-1, limit, (limit, next) => next >= limit);
    }

    private void Move(int aux, float limit, Func<float, float, bool> comparison)
    {
        var platformPosition = aux * speed * Time.deltaTime * platform.transform.up;

        var nextHeight = platformPosition.y + platform.transform.position.y;

        if (comparison(limit, nextHeight))
        {
            platform.transform.position += platformPosition;

            controller.Move(aux * speed * Time.deltaTime * transform.up);
        }
        else
        {
            state = PlayerMovimentState.StandingBy;
        }
    }

    private void Update()
    {
        Vector3 move = transform.right * horizontalRotation + transform.forward * verticalRotation;

        controller.Move(speed * Time.deltaTime * move);

        switch (state)
        {
            case PlayerMovimentState.GoingUp:
            case PlayerMovimentState.GoingToHighest:
                GoUp(MaxHeight);
                break;
            case PlayerMovimentState.GoingDown:
            case PlayerMovimentState.Reseting:
                GoDown(initialPosition);
                break;
            case PlayerMovimentState.StandingBy:
            default:
                break;
        }

        heightInfo.gameObject.transform.Find("Value").GetComponent<TextMeshPro>().text = $"{platform.transform.position.y.GetHeightValue(maxHeight: MaxHeight)}m";
    }
}