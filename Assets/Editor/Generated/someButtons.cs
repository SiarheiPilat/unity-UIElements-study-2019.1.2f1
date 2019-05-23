using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;

public class someButtons : EditorWindow
{
    [MenuItem("UIElements/someButtons")]
    public static void ShowExample()
    {
        someButtons wnd = GetWindow<someButtons> ();
        wnd.titleContent = new GUIContent("someButtons");
    }

    public void OnEnable()
    {
        // Each editor window contains a root VisualElement object
        VisualElement root = rootVisualElement;

        // Import UXML
        var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/Editor/Generated/someButtons.uxml");
        VisualElement labelFromUXML = visualTree.CloneTree();
        root.Add(labelFromUXML);
    }
}