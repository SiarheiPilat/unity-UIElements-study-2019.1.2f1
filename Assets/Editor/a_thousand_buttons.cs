using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;


public class a_thousand_buttons : EditorWindow
{
    [MenuItem("UIElements/a_thousand_buttons")]
    public static void ShowExample()
    {
        a_thousand_buttons wnd = GetWindow<a_thousand_buttons>();
        wnd.titleContent = new GUIContent("a_thousand_buttons");
    }

    public void OnEnable()
    {
        // Each editor window contains a root VisualElement object
        VisualElement root = rootVisualElement;

        // Import UXML
        var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/Editor/a_thousand_buttons.uxml");
        VisualElement labelFromUXML = visualTree.CloneTree();
        var styleSheet = AssetDatabase.LoadAssetAtPath<StyleSheet>("Assets/Editor/a_thousand_buttons.uss");
        root.Add(labelFromUXML);

        // A stylesheet can be added to a VisualElement.
        // The style will be applied to the VisualElement and all of its children.
        //VisualElement labelWithStyle = new Label("Hello World! With Style");
        //labelWithStyle.styleSheets.Add(styleSheet);
        //root.Add(labelWithStyle);
    }
}