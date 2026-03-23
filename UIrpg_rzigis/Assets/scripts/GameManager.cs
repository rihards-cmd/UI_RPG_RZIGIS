using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private Character enemy;

    [SerializeField] private TMP_Text playerName, playerHP, enemyName, enemyHP, playerWeapon;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateUI();
    }

    private void UpdateUI()
    {
        playerName.text = player.CharName;
        enemyName.text = enemy.CharName;
        playerHP.text = "HP:" + player.health.ToString("F1");
        enemyHP.text = "HP:" + enemy.health.ToString("F1");
        playerWeapon.text = "Active Weapon:" + player.ActiveWeaponName;
    }

    public void SwitchWeapon()
    {
        player.SwitchWeapon();
        UpdateUI();
    }

    public void AttackButton()
    {
        player.Attack(enemy);
        enemy.Attack(player);
        UpdateUI();
    }
}
