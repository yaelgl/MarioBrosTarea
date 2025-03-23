using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Ayuda : MonoBehaviour
{
    private UIDocument menu;
    private Button botonR;
    private Button Salir;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;

        botonR = root.Q<Button>("BotonR");
        botonR.RegisterCallback<ClickEvent, String>(Jugar,"Menu");
       
        Salir = root.Q<Button>("Salir");
        Salir.RegisterCallback<ClickEvent, String>(Jugar,"Menu");
    }

    private void Jugar(ClickEvent evt, String nombreEscena)
    {
        SceneManager.LoadSceneAsync(nombreEscena);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
