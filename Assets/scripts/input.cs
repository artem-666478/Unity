using UnityEngine;

public class input : MonoBehaviour
{
    private PlayerInputAction inputAction;

    private void Awake()
    {
        inputAction = new PlayerInputAction();
        inputAction.Player.Enable();
    }

    public Vector2 GetMovementVectorNormalized()
    {
        Vector2 inputVector= inputAction.Player.Move.ReadValue<Vector2>();

        inputVector = inputVector.normalized;

        return inputVector;

    }
}
