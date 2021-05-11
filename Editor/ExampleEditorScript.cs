using cz.vysinsky.unity.examplepackage.runtime;
using UnityEditor;

namespace cz.vysinsky.unity.examplepackage.editor
{
    [CustomEditor(typeof(ExampleBehaviour))]
    class ExampleEditorScript: Editor
    {
        public override void OnInspectorGUI()
        {
            ExampleBehaviour myTarget = (ExampleBehaviour)target;

            myTarget.ExampleProperty = EditorGUILayout.IntField("Example Property", myTarget.ExampleProperty);
            EditorGUILayout.LabelField("Example Property", myTarget.ExampleProperty.ToString());
        }
    }
}
