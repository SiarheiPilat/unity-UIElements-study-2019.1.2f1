using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;


public class a_thousand_buttons_b : EditorWindow
{
    [MenuItem("UIElements/a_thousand_buttons_b")]
    public static void ShowExample()
    {
        a_thousand_buttons_b wnd = GetWindow<a_thousand_buttons_b>();
        wnd.titleContent = new GUIContent("a_thousand_buttons_b");
    }

    public void OnEnable()
    {
        VisualElement root = rootVisualElement;
        for (int i = 0; i < 1000; i++)
        {
            Button button = new Button();
            button.text = "Random button";
            root.Add(button);
        }
    }
}