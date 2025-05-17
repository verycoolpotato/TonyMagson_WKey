using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject PlayerCharacter;

    private CharacterManager characterManager;

    private float scoreMultiplier;

   
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

    //Function to be called when player health reaches zero 
    public void PlayerDied()
    {
        //Call score functions, gameover screen, and disable player gameplay input
    }

    
    void EndScoreKeeping()
    {
        //determine final score. Set and save high scores. call scoreboard display funtion
    }

    //called when certain game length milestones are achieved
    void ScaleDifficulty()
    {
        //tell enemy controller to increase enemy difficulty, increase score multiplier
    }



    
}
