using UnityEngine;

public class GunController
{
    public Gun Gun;

    public void Shoot()
    {
        if (Gun.InstanceData.Ammo == 0) return;
        
        Gun.InstanceData.Ammo--;
    }
}
