# 需求变更记录

这个文件用来记录临时新想法、老板新增需求、功能变更或暂时不确定是否要做的项目。

原则：先记录，再评估，最后才决定是否进入 `ROADMAP.md` 和 `TASKS.md`。

## 状态说明

- `提出`：刚被提出，尚未决定是否要做。
- `接受`：决定要做，后续应排入对应 Phase。
- `延后`：有价值，但目前先不做。
- `拒绝`：不符合项目目标或会让项目过度复杂。
- `进行中`：已经开始实现。
- `完成`：功能已经完成，并同步更新相关文档。

## 优先级说明

- `必须`：不做会影响主要流程或作品集核心展示。
- `应该`：建议做，对项目完整度有帮助。
- `可选`：有时间再做，属于加分功能。
- `范围外`：目前不纳入本项目。

## 变更记录格式

```md
## CR-001 - 需求标题

- 状态：提出
- 优先级：应该
- 来源：老板想法 / 自己想法 / 面试准备 / Demo 优化
- 提出日期：2026-05-31
- 目标阶段：Phase 6 - AOI Image Inspection

### 需求内容

简短说明想新增或修改什么功能。

### 需求原因

说明为什么需要这个功能，它对作品集、Demo 或系统完整度有什么帮助。

### 影响范围

- UI：
- Services：
- Models：
- Config：
- Logs / Results：
- README / Docs：

### 决定

待评估。
```

## CR-001 - 手动选择图片执行 AOI 检测

- 状态：提出
- 优先级：可选
- 来源：Demo 优化想法
- 提出日期：2026-05-31
- 目标阶段：Phase 6 - AOI Image Inspection

### 需求内容

在 HMI 加入一个手动检测功能，让使用者可以选择一张 sample image，然后执行 AOI 检测。

### 需求原因

这个功能可以让 Demo 更容易展示影像检测效果，不一定要跑完整自动流程才看到 AOI 结果。

### 影响范围

- UI：可能新增手动选择图片按钮与图片显示区域。
- Services：复用后续的 `ImageProcessingService`。
- Results：检测结果显示到 DataGridView。
- README / Docs：需要补充手动检测操作说明。

### 决定

待评估。建议等 Phase 6 开始时再决定是否纳入。

## CR-002 - HMI Operation Experience Polish

- 状态：提出
- 优先级：应该
- 来源：Agent 建议 / Demo 优化想法
- 提出日期：2026-05-31
- 目标阶段：Phase 7.5 或 Phase 8 - 作品集整理

### 需求内容

改善 WinForms HMI 的工业设备操作体验，让画面更接近真实自动化设备软件。

可能包含：

- 顶部状态 Dashboard：Machine State、Device、Alarm、Recipe、Cycle Count。
- 按钮依照操作类型分组：Startup、Production、Safety / Recovery。
- 按钮根据机台状态启用或禁用，例如未 Initialize 前不可启动 Start Auto。
- Alarm Banner 显示目前异常，让 Alarm 状态更醒目。
- Log 显示不同等级，例如 INFO、ACTION、ALARM、ERROR。
- Result table 使用 OK / NG 颜色标识，让检测结果更容易扫描。

### 需求原因

目前 HMI 功能可用，但视觉与操作体验还比较像基础表单。这个需求可以提升作品集展示效果，让系统更像工业设备 HMI。

### 影响范围

- UI：MainForm layout、状态显示、按钮分组、Alarm 显示、Log 显示、Result table 样式。
- Services：可能需要调整 log level 或状态更新资料，但不应大改核心业务逻辑。
- Models：如果需要 Cycle Count 或 Log Level，可能新增简单 model 或 enum。
- Config：通常不需要修改。
- Logs / Results：可能只影响显示方式，不改变文件格式。
- README / Docs：完成后需要补充 HMI 操作说明与截图。

### 决定

接受方向，但暂不插队 Phase 5。

UI polish 分为两类处理：

- 当前 Phase 必要操作 UI：可以跟随当前 Phase 实作，例如 Phase 5 的 Communication Log、Device Status。
- 展示体验 UI：先记录在本文件，等 Phase 5、Phase 6、Phase 7 核心功能完成后，再统一安排到 Phase 7.5 或 Phase 8。

暂时不引入第三方 UI 套件、不改 WPF、不做复杂动画，保持 WinForms 项目轻量。
