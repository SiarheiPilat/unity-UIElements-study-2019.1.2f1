using UnityEditor;
using UnityEngine;
using UnityEditor.UIElements;
using UnityEngine.UIElements;
using UnityEngine.UIElements.StyleSheets;

public abstract class test0 : EditorWindow
{
    public abstract void DrawEditor();
    protected test2 m_script;
    protected VisualElement root;

    protected void OnEnable()
    {
        m_script = FindObjectOfType<test2>();
        if (m_script == null)
            return;

        root = rootVisualElement;
        DrawEditor();
    }
}
