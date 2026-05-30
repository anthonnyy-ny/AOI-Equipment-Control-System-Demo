# AOI Equipment Control System Demo

这是一个使用 C# WinForms 建立的自动光学检测设备控制系统 Demo。

项目目标是模拟工业自动化设备软件的基础结构，作为光学检测 / 自动化设备软件工程师作品集使用。后续会逐步加入 Recipe 参数管理、TCP/IP 设备通讯模拟器、OpenCvSharp AOI 影像检测、CSV 检测结果输出等功能。

## 项目文件

- [ROADMAP.md](ROADMAP.md)：项目开发路线图，适合审核整体进度。
- [TASKS.md](TASKS.md)：开发任务 checklist，适合逐项确认完成状态。
- [PROJECT_SPEC.md](PROJECT_SPEC.md)：项目规格说明。

## 目前开发状态

目前完成 Phase 4：State Machine 强化。

已完成内容：

- 建立基础资料夹结构
- 建立 `MachineState`、`Recipe`、`InspectionResult` model
- 建立 `LoggerService`
- 建立 `MachineService`
- 建立 `RecipeService`
- 建立 MainForm 基础 HMI 画面
- HMI 可以显示机台状态、设备连接状态、实际 JSON Recipe 参数、Log 讯息和基础 Result 表格
- Recipe 可以从 `Config/recipe.json` 读取、显示、编辑，并保存回 JSON
- MachineService 已强化状态转换规则、Alarm message 和流程步骤 log
- HMI 可以显示 Current Alarm Message

暂时尚未实作：

- TCP/IP Device Simulator
- OpenCvSharp / AOI image inspection
- CSV export
- SQL Server
- WPF
- Deep Learning

## 项目结构

```text
AOIEquipmentControlSystem/
├── Forms/
│   ├── MainForm.cs
│   ├── MainForm.Designer.cs
│   └── MainForm.resx
├── Models/
│   ├── MachineState.cs
│   ├── Recipe.cs
│   └── InspectionResult.cs
├── Services/
│   ├── LoggerService.cs
│   ├── MachineService.cs
│   └── RecipeService.cs
├── Config/
│   └── recipe.json
├── Logs/
├── Images/
└── Results/
```

## HMI 功能

MainForm 目前包含：

- Initialize button
- Start Auto button
- Stop button
- Reset button
- Clear Alarm button
- Save Recipe button
- Machine Status label
- Device Connection Status label
- Current Alarm Message label
- Recipe parameter display area
- Log display area
- Result DataGridView

## 状态流程

程序启动时，机台状态为 `Idle`。

正常流程：

```text
Initialize
→ Idle → Initializing → Ready

Start Auto
→ Ready → Running → Inspecting → Completed → Ready
```

异常流程：

```text
程序启动后直接按 Start Auto
→ MachineState 进入 Alarm
→ Alarm Message 显示 Cannot start auto. Machine is not ready.
→ Log 显示 ALARM: Cannot start auto. Machine is not ready.
→ 按 Clear Alarm 或 Reset 回到 Idle
```

## State Machine 验证

正常流程：

1. 启动 WinForms 程序。
2. 确认 `Machine Status` 为 `Idle`。
3. 点击 `Initialize`。
4. 确认状态变成 `Ready`。
5. 点击 `Start Auto`。
6. 确认 Machine Log 显示完整流程步骤：
   - Check machine ready
   - Move to capture position
   - Turn on light
   - Capture image
   - Run inspection
   - Save result
   - Complete cycle
7. 确认状态最后回到 `Ready`。

异常流程：

1. 启动 WinForms 程序。
2. 不按 `Initialize`，直接点击 `Start Auto`。
3. 确认状态进入 `Alarm`。
4. 确认 `Alarm Message` 显示 `Cannot start auto. Machine is not ready.`。
5. 点击 `Clear Alarm`。
6. 确认状态回到 `Idle`，`Alarm Message` 显示 `None`。

Stop / Reset 流程：

1. 点击 `Initialize` 后点击 `Stop`。
2. 确认状态变成 `Stopped`。
3. 在 `Stopped` 状态点击 `Start Auto`。
4. 确认进入 `Alarm` 或显示明确拒绝讯息。
5. 点击 `Reset`。
6. 确认状态回到 `Idle`，设备显示 `Disconnected`，`Alarm Message` 显示 `None`。

## 如何验证

在 repository 根目录执行：

```powershell
dotnet build .\AOIEquipmentControlSystem\AOIEquipmentControlSystem.csproj
```

预期结果：项目可以成功 build，且没有错误。

也可以使用 Visual Studio 打开项目后按下 Start 执行 WinForms 程序，并依照上方正常流程与异常流程测试按钮操作。

## Recipe 保存验证

手动测试步骤：

1. 启动 WinForms 程序。
2. 确认 Recipe Parameters 区域显示来自 `Config/recipe.json` 的参数。
3. 修改 `ProductName` 或 `Threshold`。
4. 点击 `Save Recipe`。
5. 确认 Machine Log 显示 `Recipe saved successfully.`。
6. 关闭程序后重新启动。
7. 确认修改后的 Recipe 仍然显示在 UI 上。
8. 打开 `AOIEquipmentControlSystem/Config/recipe.json`，确认 JSON 已更新且格式可读。

## Log 文件验证

程序运行时，Machine Log 会实时写入：

```text
AOIEquipmentControlSystem/Logs/yyyy-MM-dd_machine_log.txt
```

可以点击 `Initialize`、`Start Auto`、`Reset` 等按钮后打开当天 log 文件，确认最新操作已经追加到文件末尾。
