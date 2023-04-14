using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class FightSceneSetup : MonoBehaviour
{
    public TextMeshProUGUI playerHitpoints;
    public TextMeshProUGUI playerArmor;
    public TextMeshProUGUI playerAttack;
    private int playerHitpointAmount;
    private int playerArmorAmount;
    private int playerAttackAmount;

    public TextMeshProUGUI monsterHitpoints;
    public TextMeshProUGUI monsterArmor;
    public TextMeshProUGUI monsterAttack;
    private int monsterHitpointAmount;
    private int monsterArmorAmount;
    private int monsterAttackAmount; 
    // Start is called before the first frame update
    void Start()
    {
        this.playerHitpointAmount = Random.Range(10, 20);
        this.playerArmorAmount = Random.Range(10, 17);
        this.playerAttackAmount = Random.Range(1, 5);

        this.monsterHitpointAmount = Random.Range(10, 20);
        this.monsterArmorAmount = Random.Range(10, 17);
        this.monsterAttackAmount = Random.Range(1, 5);

        print(this.monsterHitpointAmount);
    }

    // Update is called once per frame
    void Update()
    {
        this.monsterHitpoints.text = "Monster Hitpoints: " + this.monsterHitpointAmount;
        this.monsterArmor.text = "Monster Armor: " + this.monsterArmorAmount;
        this.monsterAttack.text = "Monster Attack: " + this.monsterAttackAmount;

        this.playerHitpoints.text = "Player Hitpoints: " + this.playerHitpointAmount;
        this.playerArmor.text = "Player Armor: " + this.playerArmorAmount;
        this.playerAttack.text = "Player Attack: " + this.playerAttackAmount;
    }
}
