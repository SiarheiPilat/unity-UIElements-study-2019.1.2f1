using UnityEngine;
using UnityEditor;

public class test4 : test0
{
    public override void DrawEditor()
    {
        
    }

    [MenuItem("UIElements examples/test4: 1000 buttons")]
    public static void OpenWindow()
    {
        EditorWindow window = GetWindow<test4>("test4: 1000 buttons");
        window.minSize = new Vector2(500, 250);
    }
}
