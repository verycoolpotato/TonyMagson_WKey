using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject PlayerCharacter;

    private CharacterManager characterManager;

    private void Awake()
    {
        characterManager = PlayerCharacter.GetComponent<CharacterManager>();
    }
    /*TO DO
     * -Scoreboard
     * -Saving High Scores
     * -Player Death
     * -GameOver and Restart
     * -Global Difficulty (Raises based on how long player has survived)
     */
}
