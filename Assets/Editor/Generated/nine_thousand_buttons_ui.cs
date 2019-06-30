using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;

public class nine_thousand_buttons_ui : EditorWindow
{
    [MenuItem("UIElements/nine_thousand_buttons_ui")]
    public static void ShowExample()
    {
        nine_thousand_buttons_ui wnd = GetWindow<nine_thousand_buttons_ui> ();
        wnd.titleContent = new GUIContent("nine_thousand_buttons_ui");
    }

    public void OnEnable()
    {
        // Each editor window contains a root VisualElement object
        VisualElement root = rootVisualElement;

        // Import UXML
        var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/Editor/Generated/nine_thousand_buttons_ui.uxml");
        VisualElement labelFromUXML = visualTree.CloneTree();
        root.Add(labelFromUXML);
    }
}