using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    private MenuManager menuManager;

    // Start is called before the first frame update
    void Start()
    {
        menuManager = GetComponent<MenuManager>();
        nameText.text = $"{MenuManager.PetName.petName}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackToMenu(){
       SceneManager.LoadScene(0);
    }
}
