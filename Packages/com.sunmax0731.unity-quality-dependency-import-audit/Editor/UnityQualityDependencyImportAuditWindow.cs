using UnityEditor;
using UnityEngine;

namespace Sunmax0731.UnityQualityDependencyImportAudit
{
    public sealed class UnityQualityDependencyImportAuditWindow : EditorWindow
    {
        [MenuItem("Tools/Sunmax0731/Unity品質・依存・Import・性能監査")]
        public static void Open()
        {
            GetWindow<UnityQualityDependencyImportAuditWindow>("Unity品質・依存・Import・性能監査");
        }

        private void OnGUI()
        {
            EditorGUILayout.LabelField("Unity品質・依存・Import・性能監査", EditorStyles.boldLabel);
            EditorGUILayout.HelpBox("プロジェクトの健康状態を1つの検品結果として出し、次の修正候補まで示す。", MessageType.Info);
            if (GUILayout.Button("Open documentation"))
            {
                Application.OpenURL("https://github.com/Sunmax0731/unity-quality-dependency-import-audit");
            }
        }
    }
}
