# Changelog

所有重要修改都会记录在这里。

格式参考 Keep a Changelog，版本号参考 SemVer。

## [Unreleased]

### Added
- 完成 Phase 3 Recipe 管理，支持从 `Config/recipe.json` 读取、显示、编辑并保存 Recipe 参数。
- MainForm 新增 `Save Recipe` 按钮。
- `RecipeService` 新增 Recipe JSON 保存功能，并输出格式化 JSON。
- 完成 Phase 4 State Machine 强化，新增明确状态转换检查、Alarm message 和流程步骤 log。
- MainForm 新增 Current Alarm Message 显示。

### Changed
- `LoggerService` 改为将 machine log 写入项目资料夹 `AOIEquipmentControlSystem/Logs`，方便直接查看运行记录。
- 更新 README、ROADMAP、TASKS，记录 Phase 4 完成状态。
- 更新 README、ROADMAP、TASKS，记录 Phase 3 完成状态。

## [0.2.1] - 2026-05-31

### Added
- 新增 `global.json`，固定 .NET SDK 版本，降低不同开发环境造成的 build 差异。
- 新增 `.editorconfig`，统一编码、换行、缩排与基础 C# 风格。
- 新增 `.gitkeep`，保留 Logs、Results、Images/Sample、Images/Result 等资料夹结构。
- 新增 `CHANGELOG.md`，记录版本修改说明。

### Changed
- 更新 `.gitignore`，忽略 Logs、Results、Images/Result 内的运行产物。
- 更新 `.csproj`，让 `Config/recipe.json` build 时复制到输出目录。
- MainForm 改用动态 layout panels，减少窗口缩放时文字被遮住的问题。
- 调整 MainForm 垂直空间分配，让 Recipe Parameters 和 Machine Log 更容易阅读。
- Machine Log 新增编号区块 header，方便辨识同一次 UI 操作产生的 log。
- Machine Log header 改为蓝色多行显示，凸显 Update、Action、Time、State 信息。

## [0.2.0] - 2026-05-30

### Added
- 新增基础 WinForms HMI 画面。
- 新增 `MachineService`，支持基础机台状态控制。
- 新增 Initialize、Start Auto、Stop、Reset、Clear Alarm 操作按钮。
- 新增 Machine Status、Device Connection Status、Recipe 参数区域、Log 显示区域与 Result DataGridView。

### Changed
- 更新 README、ROADMAP、TASKS，记录 Phase 2 完成状态。

## [0.1.0] - 2026-05-30

### Added
- 建立 C# WinForms 项目。
- 建立 Forms、Models、Services、Config、Logs、Images、Results 资料夹结构。
- 新增 `MachineState`、`Recipe`、`InspectionResult` model。
- 新增 `LoggerService`。
- 新增 sample `Config/recipe.json`。
- 新增 README、ROADMAP、TASKS、PROJECT_SPEC、AGENTS 项目文件。
