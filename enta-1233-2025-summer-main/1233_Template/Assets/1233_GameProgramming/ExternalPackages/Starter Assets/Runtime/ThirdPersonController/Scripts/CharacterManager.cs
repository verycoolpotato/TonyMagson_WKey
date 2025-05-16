using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    private GameManager gameManager;

    private void Awake()
    {
        gameManager = FindFirstObjectByType<GameManager>();
    }
    /*TO DO
     * -Player Health
     * -Damage Management
     * -Ammo Count (Could be split off into a separate gun controller script)
     * -Store player status effects (Speed up, regen, damage bonuses)
     * -Character Animation stuff?
     * -Character State (Cover/Running)
     */
    

}
