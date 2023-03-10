using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButtonX5 : MonoBehaviour
{
    private Button button;
    private GameManagerX5 gameManagerX5script;
    public int difficulty;

    // Start is called before the first frame update
    void Start()
    {
        gameManagerX5script = GameObject.Find("Game Manager").GetComponent<GameManagerX5>();
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
    }

    /* When a button is clicked, call the StartGame() method
     * and pass it the difficulty value (1, 2, 3) from the button 
    */
    void SetDifficulty()
    {
        Debug.Log(button.gameObject.name + " was clicked");
        gameManagerX5script.StartGame(difficulty);
    }



}
