using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerControls Controls { get; private set; }
    public PlayerHands Hands { get; private set; }

    void Awake()
	{
        Controls = GetComponent<PlayerControls>();
        Hands = GetComponent<PlayerHands>();

        Hands.Player = Controls.Player = this;
	}
}