using UnityEngine;
using UnityEngine.UI;

public class FontManager : MonoBehaviour
{
    public Text textElement;

    private void Start()
    {
        // Load the PhoenixOne font from the assets folder
        Font phoenixOneFont = Resources.Load<Font>("PhoenixOne");

        // Set the font for the text element
        textElement.font = phoenixOneFont;
    }
}
