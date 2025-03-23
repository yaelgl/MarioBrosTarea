using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Esta es la referencia al UXML cargado por el UI Builder
    private VisualElement rootElement;

    void OnEnable()
    {
        // Obtener el documento VisualTree y asociarlo a la raíz de la UI
        var visualTree = Resources.Load<VisualTreeAsset>("UI/Menu");  // Cambia la ruta a la ubicación de tu UXML
        rootElement = visualTree.CloneTree();
        var uiDocument = GetComponent<UIDocument>();
        uiDocument.rootVisualElement.Add(rootElement);

        // Obtener los botones y asignar los eventos de clic
        Button playButton = rootElement.Q<Button>("PlayButton"); // Reemplaza "PlayButton" por el nombre del ID de tu botón
        Button creditsButton = rootElement.Q<Button>("CreditsButton"); // Reemplaza "CreditsButton" por el nombre del ID de tu botón
        Button helpButton = rootElement.Q<Button>("HelpButton"); // Reemplaza "HelpButton" por el nombre del ID de tu botón

        playButton.clicked += LoadSampleScene;
        creditsButton.clicked += LoadCreditsScene;
        // helpButton.clicked += ShowHelp; // No lo implementamos por ahora
    }

    void LoadSampleScene()
    {
        // Cambiar la escena a "SampleScene"
        SceneManager.LoadScene("SampleScene");
    }

    void LoadCreditsScene()
    {
        // Cambiar la escena a "Creditos"
        SceneManager.LoadScene("Creditos");
    }

    // Esta función será para el botón de ayuda en el futuro
    // void ShowHelp()
    // {
    //     // Lógica para mostrar la ayuda (podemos mostrar una UI emergente o algo similar)
    // }
}
