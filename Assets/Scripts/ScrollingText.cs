using UnityEngine;
using UnityEngine.UIElements;

public class ScrollingText : MonoBehaviour
{
    private VisualElement scrollingText;
    private float scrollSpeed = 30f;

    void Start()
    {
        // Obtener el UIDocument
        var uiDocument = GetComponent<UIDocument>();
        var root = uiDocument.rootVisualElement;

        // Obtener el Label con el nombre "scrollingText"
        scrollingText = root.Q<Label>("scrollingText");

        // Asegúrate de que el Label existe
        if (scrollingText == null)
        {
            Debug.LogError("No se encontró el Label con el nombre 'scrollingText' en el archivo .uxml.");
        }

        // Establecer la posición inicial del texto fuera de la pantalla
        scrollingText.style.top = new StyleLength(new Length(100, LengthUnit.Percent));
    }

    void Update()
    {
        // Desplazar el texto hacia arriba
        float currentTop = scrollingText.resolvedStyle.top;
        scrollingText.style.top = new StyleLength(new Length(currentTop - scrollSpeed * Time.deltaTime, LengthUnit.Pixel));

        // Reiniciar el texto si ha salido de la pantalla
        if (currentTop < -scrollingText.resolvedStyle.height)
        {
            scrollingText.style.top = new StyleLength(new Length(100, LengthUnit.Percent));
        }
    }
}
