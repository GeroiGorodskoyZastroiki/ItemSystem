using UnityEngine;

public class Gun : MonoBehaviour
{
    public GunData Data;
    public GunInstanceData InstanceData;
    public GunController Controller = new();

    void Start()
    {
        Controller.Gun = this;
        InstanceData.Ammo = Data.MaxAmmo;
    }

    public void Shoot() => 
        Controller.Shoot();
}
