# Changelog

所有重要修改都会记录在这里。

格式参考 Keep a Changelog，版本号参考 SemVer。

## [Unreleased]

### Added
- 后续尚未发布的新功能或调整先记录在这里。

## [0.2.1] - 2026-05-31

### Added
- 新增 `global.json`，固定 .NET SDK 版本，降低不同开发环境造成的 build 差异。
- 新增 `.editorconfig`，统一编码、换行、缩排与基础 C# 风格。
- 新增 `.gitkeep`，保留 Logs、Results、Images/Sample、Images/Result 等资料夹结构。
- 新增 `CHANGELOG.md`，记录版本修改说明。

### Changed
- 更新 `.gitignore`，忽略 Logs、Results、Images/Result 内的运行产物。
- 更新 `.csproj`，让 `Config/recipe.json` build 时复制到输出目录。

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
