using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void CatMode(){
        SceneManager.LoadScene(1);
    }

    public void DogMode(){
        SceneManager.LoadScene(2);
    }

    public void BackToMenu(){
        SceneManager.LoadScene(0);
    }
}
