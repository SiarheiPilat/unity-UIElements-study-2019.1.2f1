using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;


public class uxml_changer : EditorWindow
{
    [MenuItem("Window/UIElements/uxml_changer")]
    public static void ShowExample()
    {
        uxml_changer wnd = GetWindow<uxml_changer>();
        wnd.titleContent = new GUIContent("uxml_changer");
    }

    public void OnEnable()
    {
        // Each editor window contains a root VisualElement object
        VisualElement root = rootVisualElement;

        // VisualElements objects can contain other VisualElement following a tree hierarchy.
        VisualElement label = new Label("UXML changer");
        root.Add(label);

        // Import UXML
        var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/Editor/uxml_changer.uxml");
        VisualElement labelFromUXML = visualTree.CloneTree();
        root.Add(labelFromUXML);

    }
}