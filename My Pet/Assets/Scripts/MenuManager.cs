using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public InputField inputField;

    public class PetName{
        public static string petName = "";
    }
    
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CatMode(){
        PetName.petName = inputField.text; 

        SceneManager.LoadScene(1);
    }

    public void DogMode(){
        PetName.petName = inputField.text;

        SceneManager.LoadScene(2);
    }

    public void ExitGame(){
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else 
            Application.Quit();
        #endif
    }
}
