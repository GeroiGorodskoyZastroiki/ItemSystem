using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    [HideInInspector] public Player Player;

    //Нужен DRY
    public void OnUse(InputAction.CallbackContext context)
    {
        if (context.performed)
            Player.Hands.Use(context.action);
    }

    public void OnAltUse(InputAction.CallbackContext context)
    {
        if (context.performed)
            Player.Hands.AltUse(context.action);
    }

    public void OnReload(InputAction.CallbackContext context)
    {
        if (context.performed)
            Player.Hands.Reload(context.action);
    }
}
