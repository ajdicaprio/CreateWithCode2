using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton5 : MonoBehaviour
{
    private GameManager5 gameManagerScript;
    private Button button; //using UnityEngine.UI;
    public int difficulty;

    // Start is called before the first frame update
    void Start()
    {
        gameManagerScript = GameObject.Find("GameManager").GetComponent<GameManager5>();
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetDifficulty()
    {
        Debug.Log(button.gameObject.name + " was clicked");
        gameManagerScript.StartGame(difficulty);
    }
}
