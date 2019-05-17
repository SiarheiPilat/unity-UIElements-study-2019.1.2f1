using UnityEditor;
using UnityEngine;
using UnityEditor.UIElements;
using UnityEngine.UIElements;
using UnityEngine.UIElements.StyleSheets;

public class test1 : test0
{
    public override void DrawEditor()
    {
        #region VisualElement
        VisualElement visualElement = new VisualElement();
        visualElement.style.marginTop = 6;
        visualElement.style.marginBottom = 3;
        visualElement.style.marginLeft = 6;
        visualElement.style.marginRight = 6;
        visualElement.style.flexDirection = FlexDirection.Row;
        visualElement.style.backgroundColor = Color.white;
        visualElement.style.color = Color.gray;
        #endregion

        #region Label
        Label label = new Label();
        label.text = "Inline C# label";
        label.style.fontSize = 16;
        label.style.unityFontStyleAndWeight = FontStyle.Bold;
        label.style.backgroundColor = Color.yellow;
        label.style.borderBottomLeftRadius = 15;
        label.style.borderBottomRightRadius = 15;
        label.style.borderTopLeftRadius = 15;
        label.style.borderTopRightRadius = 15;
        label.style.paddingLeft = 10;
        label.style.width = 160;
        label.style.height = 20;
        label.style.marginLeft = 6;
        label.style.marginTop = 6;
        label.style.marginBottom = 5;
        visualElement.Add(label);
        #endregion

        #region TextField
        TextField textField = new TextField();
        textField.value = "Textfield value";
        textField.style.backgroundColor = Color.cyan;
        textField.style.fontSize = 15;
        textField.style.marginLeft = 3;
        textField.style.marginTop = 3;
        textField.style.marginBottom = 3;
        textField.style.marginRight = 3;
        textField.style.height = 25;
        textField.style.flexGrow = 1;
        visualElement.Add(textField);
        #endregion

        #region IntegerField
        IntegerField integerField = new IntegerField();
        integerField.value = 1144;
        integerField.style.fontSize = 14;
        integerField.style.height = 25;
        integerField.style.backgroundColor = Color.blue;
        integerField.style.marginTop = 3;
        integerField.style.marginRight = 3;
        integerField.style.borderLeftWidth = 3;
        integerField.style.borderRightWidth = 3;
        integerField.style.borderTopWidth = 3;
        integerField.style.borderBottomWidth = 3;
        integerField.style.minWidth = 100;
        visualElement.Add(integerField);
        #endregion

        #region VisualElement2
        VisualElement visualElement2 = new VisualElement();
        visualElement2.style.marginTop = 0;
        visualElement2.style.marginBottom = 6;
        visualElement2.style.marginLeft = 6;
        visualElement2.style.marginRight = 6;
        visualElement2.style.flexDirection = FlexDirection.Row;
        visualElement2.style.backgroundColor = Color.white;
        visualElement2.style.color = Color.gray;
        #endregion

        #region Buttons

        Button button = new Button();
        button.text = "Click me!";
        button.style.marginLeft = 5;
        button.style.marginBottom = 3;
        button.style.marginTop = 3;
        button.style.height = 25;
        button.style.width = 100;
        visualElement2.Add(button);

        Button button2 = new Button();
        button2.text = "Font size: 14";
        button2.style.marginLeft = 5;
        button2.style.marginBottom = 3;
        button2.style.marginTop = 3;
        button2.style.height = 25;
        button2.style.width = 140;
        button2.style.fontSize = 14;
        visualElement2.Add(button2);

        #endregion

        #region VisualElement3
        VisualElement visualElement3 = new VisualElement();
        visualElement3.style.marginTop = 0;
        visualElement3.style.marginBottom = 6;
        visualElement3.style.marginLeft = 6;
        visualElement3.style.marginRight = 6;
        visualElement3.style.flexDirection = FlexDirection.Row;
        visualElement3.style.backgroundColor = Color.green;
        visualElement3.style.color = Color.gray;
        #endregion

        //Foldout foldout = new Foldout();
        //foldout.text = "Foldout";
        //visualElement3.Add(foldout);

        MinMaxSlider minMaxSlider = new MinMaxSlider();
        minMaxSlider.label = "MinMaxSlider example";
        minMaxSlider.lowLimit = 0;
        minMaxSlider.highLimit = 100;
        minMaxSlider.minValue = 20;
        minMaxSlider.maxValue = 45;
        minMaxSlider.style.width = 300;
        visualElement3.Add(minMaxSlider);

        #region VisualElement4
        VisualElement visualElement4 = new VisualElement();
        visualElement4.style.marginTop = 0;
        visualElement4.style.marginBottom = 6;
        visualElement4.style.marginLeft = 6;
        visualElement4.style.marginRight = 6;
        visualElement4.style.flexDirection = FlexDirection.Row;
        visualElement4.style.backgroundColor = Color.magenta;
        visualElement4.style.color = Color.gray;
        #endregion



        root.Add(visualElement);
        root.Add(visualElement2);
        root.Add(visualElement3);
        root.Add(visualElement4);
    }

    [MenuItem("UIElements examples/test1 inline C#")]
    public static void OpenWindow()
    {
        EditorWindow window = GetWindow<test1>("test1 inline C# example");
        window.minSize = new Vector2(500, 250);
    }

}
