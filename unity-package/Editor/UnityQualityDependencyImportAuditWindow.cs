using UnityEditor;
using UnityEngine;

namespace Sunmax0731.UnityQualityDependencyImportAudit
{
    public sealed class UnityQualityDependencyImportAuditWindow : EditorWindow
    {
        [MenuItem("Tools/Sunmax0731/unity-quality-dependency-import-audit")]
        public static void Open() => GetWindow<UnityQualityDependencyImportAuditWindow>("unity-quality-dependency-import-audit");

        private void OnGUI()
        {
            GUILayout.Label("Unity品質・依存・Import・性能監査", EditorStyles.boldLabel);
            GUILayout.Label("Closed alpha editor package is importable.");
        }
    }
}
