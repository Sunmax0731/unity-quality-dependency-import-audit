# unity-quality-dependency-import-audit

Unity品質・依存・Import・性能監査 は、アセット検品、品質スコア、Import設定、依存関係、性能診断をUnity Editor内でまとめて確認する。

## 何を解決するか

Unity制作では品質、依存、Import、性能の問題が別々に見つかり、修正順を決めづらい。

## 差別化

プロジェクトの健康状態を1つの検品結果として出し、次の修正候補まで示す。

## 公開先

- GitHub Release / BOOTH

## 現在の到達点

- core / validators / report / review-model / CLI に責務を分割済み
- Unity EditorWindow + package の最小実装または配布用骨格を同梱済み
- 代表シナリオ `samples/representative-suite.json` で正常系、必須項目不足、warning、混在バッチを自動検証済み
- 厳格 QCDS は Quality、Cost、Delivery、Satisfaction の全観点 S+ で評価済み
- docs ZIP は `dist/unity-quality-dependency-import-audit-docs.zip`

## 主要コマンド

```powershell
npm test
npm start
```

## 重要ドキュメント

- [要件定義](docs/requirements.md)
- [仕様](docs/specification.md)
- [設計](docs/design.md)
- [手動テスト](docs/manual-test.md)
- [厳格手動テスト追補](docs/strict-manual-test-addendum.md)
- [QCDS評価](docs/qcds-evaluation.md)
- [厳格QCDS metrics](docs/qcds-strict-metrics.json)
- [トレーサビリティ](docs/traceability-matrix.md)

## 参照したアイデアパック

- created_idea: `D:\AI\UnityEditor\created_idea_001_unity-quality-dependency-import-audit`
- idea ZIP: `D:\AI\UnityEditor\created_idea_001_unity-quality-dependency-import-audit\idea_001_unity-quality-dependency-import-audit.zip`
- PICKUP rank: 32
- Domain: UnityEditor
