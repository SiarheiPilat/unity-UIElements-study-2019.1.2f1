using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class test3 : test0
{
    [MenuItem("UIElements examples/test3")]
    public static void OpenWindow()
    {
        EditorWindow window = GetWindow<test3>("test1 inline C# example");
        window.minSize = new Vector2(500, 250);
    }

    public override void DrawEditor()
    {
        VisualElement visualElement = new VisualElement();
        visualElement.name = "csharp-uss-visual-element";
    }
}
