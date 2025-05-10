using UnityEngine;
using System.Linq;
using UnityEngine.InputSystem;

public class PlayerHands : MonoBehaviour
{
    [HideInInspector] public Player Player;
    public Item Item;

    //Нужен DRY
    public void Use(InputAction inputAction) =>
    //по какой-то причине прямое сравнение action не работает, надо разбираться
        //Item.ActionsGroups.Single(x => x.ActionReference.action == inputAction).Act();
        Item.ActionsGroups.SingleOrDefault(x => x.ActionReference.action.id == inputAction.id)?.Act();

    public void AltUse(InputAction inputAction) =>
        Item.ActionsGroups.SingleOrDefault(x => x.ActionReference.action.id == inputAction.id)?.Act();
 
    public void Reload(InputAction inputAction) =>
        Item.ActionsGroups.SingleOrDefault(x => x.ActionReference.action.id == inputAction.id)?.Act();
}
