# 文档同步检查表

这个文件用来避免功能做到后面才发现 Markdown 没有同步更新。

原则：不是每一次小修改都要更新所有文档，而是在完成一个功能、推进一个 Phase、接受一个新需求、或准备发布版本时，根据影响范围检查对应文件。

## 什么时候需要检查

以下情况必须检查本文件：

- 完成一个功能
- 完成或推进一个 Phase
- 接受一个临时需求
- 修改系统规格或使用方式
- 修改 HMI 操作流程
- 新增 service、model、config 或输出文件
- 准备 commit、tag 或 release

## 文档职责

| 文件 | 用途 | 什么时候更新 |
| --- | --- | --- |
| `README.md` | 给别人看的项目介绍、目前状态、运行和验证方式 | 功能改变使用方式、项目状态改变、需要补充验证步骤时 |
| `ROADMAP.md` | 阶段路线图和当前 Phase 状态 | Phase 开始、完成、拆分或调整顺序时 |
| `TASKS.md` | 具体任务 checklist | 任务完成、任务新增、任务拆分时 |
| `PROJECT_SPEC.md` | 系统规格和功能需求 | 功能需求、流程、画面需求、资料格式改变时 |
| `CHANGELOG.md` | 版本修改说明 | 完成 Phase、准备 commit/tag/release 时 |
| `CHANGE_REQUESTS.md` | 临时需求和新想法 | 有新 idea、老板需求、功能变更但尚未决定是否要做时 |
| `AGENTS.md` | 长期协作规则和开发原则 | 开发规则、文档规则、协作方式改变时 |
| `DOC_SYNC_CHECKLIST.md` | 文档同步规则 | 文档管理方式改变时 |

## 常见改动对应更新

### 新增 UI 功能

- [ ] `TASKS.md` 勾选或新增任务
- [ ] `README.md` 更新 HMI 功能和验证步骤
- [ ] `PROJECT_SPEC.md` 更新主画面需求
- [ ] `CHANGELOG.md` 记录版本修改

### 新增 Service 或 Model

- [ ] `TASKS.md` 勾选或新增任务
- [ ] `README.md` 更新项目结构
- [ ] `PROJECT_SPEC.md` 更新对应需求
- [ ] `CHANGELOG.md` 记录版本修改

### 完成一个 Phase

- [ ] `TASKS.md` 勾选该 Phase 完成项目
- [ ] `ROADMAP.md` 更新当前状态和下一阶段
- [ ] `README.md` 更新目前开发状态
- [ ] `CHANGELOG.md` 新增或整理版本段落
- [ ] 必要时更新 `PROJECT_SPEC.md`

### 接受临时需求

- [ ] `CHANGE_REQUESTS.md` 状态改为接受
- [ ] `ROADMAP.md` 加入目标 Phase
- [ ] `TASKS.md` 加入具体任务
- [ ] 必要时更新 `PROJECT_SPEC.md`

### 发布版本

- [ ] `CHANGELOG.md` 从 `[Unreleased]` 整理到正式版本号
- [ ] `README.md` 确认目前状态正确
- [ ] `ROADMAP.md` 确认当前 Phase 正确
- [ ] `TASKS.md` 确认 checklist 正确
- [ ] `dotnet build` 成功

## 最小同步原则

不要为了小修改更新所有文档。只更新和本次改动有关的文件。

例如：

- 修正一个按钮文字：通常只需要 `CHANGELOG.md`，甚至可以等下次版本整理。
- 新增 TCP simulator：需要更新 `TASKS.md`、`ROADMAP.md`、`README.md`、`PROJECT_SPEC.md`、`CHANGELOG.md`。
- 老板提出新想法但还没决定做：只需要更新 `CHANGE_REQUESTS.md`。
