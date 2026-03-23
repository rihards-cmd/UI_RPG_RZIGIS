using UnityEngine;

public class Player : Character
{
    [SerializeField] private Weapon activeWeapon;
    [SerializeField] private Weapon[] weapons;

    public string ActiveWeaponName
    {
        get { return activeWeapon.weaponName; }
    }

    private int selectedWeaponID = 0;

    public void SwitchWeapon()
    {
        selectedWeaponID = (++selectedWeaponID) % weapons.Length;
        activeWeapon = weapons[selectedWeaponID];
    }
    
    public override void Attack(Character toHit)
    {
        toHit.TakeDamage(activeWeapon);
    }

}
