export const productProfile = {
  "repository": "unity-quality-dependency-import-audit",
  "title": "Unity品質・依存・Import・性能監査",
  "domain": "UnityEditor",
  "hostApp": null,
  "rank": 32,
  "ideaNo": 1,
  "overview": "アセット検品、品質スコア、Import設定、依存関係、性能診断をUnity Editor内でまとめて確認する。",
  "problem": "Unity制作では品質、依存、Import、性能の問題が別々に見つかり、修正順を決めづらい。",
  "differentiation": "プロジェクトの健康状態を1つの検品結果として出し、次の修正候補まで示す。",
  "publish": "GitHub Release / BOOTH",
  "surface": "Unity EditorWindow + package",
  "entity": "unity audit case",
  "requiredFields": [
    "id",
    "title",
    "source",
    "assetPath",
    "importSetting",
    "dependency",
    "owner",
    "acceptance"
  ],
  "warningField": "performanceBudget",
  "benchmarkRepos": [
    "Sunmax0731/release-output-check-flow",
    "Sunmax0731/git-release-publish-assistant",
    "Sunmax0731/movie-telop-transcriber",
    "Sunmax0731/codex-remote-android"
  ]
};
