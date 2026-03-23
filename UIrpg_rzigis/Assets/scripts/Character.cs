using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public float health;
    [SerializeField] private string charName;

    public string CharName
    {
        get { return charName; }
    }

    public abstract void Attack(Character toHit);

    void Start()
    {
        Debug.Log("player:"+charName);
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        Debug.Log(CharName + "got hit for" + damage + "damage, current health:" + health);
    }

    public void TakeDamage(Weapon weapon)
    {
        float damage = weapon.GetDamage();
        TakeDamage(damage);
    }

}
